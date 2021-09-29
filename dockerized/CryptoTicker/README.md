# Crypto Dotnet Ticker

A website that provides crypto price information. In this workshop we will:

- Implement a function in Azure Functions that runs only when data changes in an Azure Cosmos DB collection.
- Implement a function in Azure Functions to broadcast changes to connected clients using SignalR Service.
- Update the client web application to respond to SignalR messages.
- Use Azure Storage to host our Blazor site.

## Dockerizing our blazor app

### NGINX

We're going to be using NGINX to serve our application inside our container.
As NGINX configuration is all opt-in it doesn't handle different mime types unless we tell it to. Also we will need to add in a mime type for wasm as this is not included in NGINXs default mime type list.
```
events { }
http {
    include mime.types;
    types {
        application/wasm wasm;
    }

    server {
        listen 80;

        location / {
            root /usr/local/webapp/nginx/html;;
            try_files $uri $uri/ /index.html =404;
        }
    }
}
```
We've setup a simple web server listening on port 80 with files being served from `/usr/local/webapp/nginx/html;`. The try_files configuration tells NGINX to serve the `index.html` whenever it can't find the requested file on disk.

Above in the `server` block we've included the default mime types as well as a custom mime type for `wasm` files.

### Adding the Dokcerfile

This is the dockerfile in the root folder of our project
```
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /src

COPY CryptoTicker.csproj .
RUN dotnet restore "CryptoTicker.csproj"
COPY . .
RUN dotnet build "CryptoTicker.csproj" -c Release -o /build

FROM build-env AS publish
RUN dotnet publish "CryptoTicker.csproj" -c Release -o /publish

FROM nginx:alpine AS final
WORKDIR /usr/local/webapp/nginx/html

COPY --from=publish /publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf
```

Breaking down the above dockerfile
#### Part 1

```
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /src
COPY CryptoTicker.csproj .
RUN dotnet restore "CryptoTicker.csproj"
COPY . .
RUN dotnet build "CryptoTicker.csproj" -c Release -o /build
```

This first section is going to build our app. We're using Microsofts official .NET Core 5 SDK image as the base for the build.
We set the `WORKDIR` in the container to `/src` and then `COPY` over the `csproj` file from our project. Next we run a dotnet restore before copying over the rest of the files from our project to the container. Finally, we build the project by `RUN` `dotnet build` on our project file setting the configuration to release.

#### Part 2

```
FROM build AS publish
RUN dotnet publish "CryptoTicker.csproj" -c Release -o /app/publish
```

The next section publishes our app. This is pretty straightforward, we use the previous section as a base and then `RUN` the `dotnet publish` command to publish the project.

#### Part 3
```
FROM nginx:alpine AS final
WORKDIR /usr/local/webapp/nginx/html
COPY --from=publish /publish/wwwroot .
COPY nginx.conf /etc/nginx/nginx.conf
```

The last section produces our final image. We use the `nginx:alpine` image as a base and start by setting the `WORKDIR` to `/usr/local/webapp/nginx/html` - this is the directory where we'll serve our application from. Next, we `COPY` over our published app from the previous publish section to the current working directory. Finally, we `COPY` over the `nginx.conf` we created earlier to replace the default configuration file.


### Building the image
Now we have our dockerfile all setup and ready to go we need to build our image.
```
docker build -t crypto-ticker-with-docker .
```

### Starting the Container
```
docker run -p 8080:80 crypto-ticker-with-docker
```
This command tells Docker to start a container with the tag `crypto-ticker-with-docker`. The `-p` maps port `8080` on the host to port `80` in the container.


## Deploying to Azure

[Deploy a custom container to App Service using GitHub Actions](https://docs.microsoft.com/en-us/azure/app-service/deploy-container-github-action?tabs=service-principal)

### Prerequisites
I already have created the Azure container registry and the App Service for containers.
If you don't have one, create an Azure container registry in the Basic tier using the Azure CLI, Azure portal, or other methods. Take note of the resource group used for the deployment, which is used for the GitHub workflow.

### Create service principal for Azure authentication
You can create a service principal with the az ad sp create-for-rbac command in the Azure CLI. Run this command
```
az ad sp create-for-rbac --name "myApp" --role contributor \
                            --scopes /subscriptions/<subscription-id>/resourceGroups/<group-name>/providers/Microsoft.Web/sites/<app-name> \
                            --sdk-auth
```                            

In the example, replace the placeholders with your subscription ID, resource group name, and app name. The output is a JSON object with the role assignment credentials that provide access to your App Service app. Copy this JSON object for later. Output is similar to:
```json
{
    "clientId": "<GUID>",
    "clientSecret": "<GUID>",
    "subscriptionId": "<GUID>",
    "tenantId": "<GUID>",
    (...)
}
```

### Configure the GitHub secret for authentication

In GitHub, browse your repository, select Settings > Secrets > Add a new secret.

To use user-level credentials, paste the entire JSON output from the Azure CLI command into the secret's value field. Give the secret the name like AZURE_CREDENTIALS.

When you configure the workflow file later, you use the secret for the input creds of the Azure Login action. For example:
```yml
- uses: azure/login@v1
  with:
    creds: ${{ secrets.AZURE_CREDENTIALS }}
```

### Configure GitHub secrets for your registry
Define secrets to use with the Docker Login action. The example in this document uses Azure Container Registry for the container registry.

- Go to your container in the Azure portal or Docker and copy the username and password. You can find the Azure Container Registry username and password in the Azure portal under Settings > Access keys for your registry.

- Define a new secret for the registry username named `REGISTRY_USERNAME`.

- Define a new secret for the registry password named `REGISTRY_PASSWORD`.

### Create GitHub Workflow

- In the GitHub UI, select Actions > New workflow.
- Select Set up a workflow yourself.
- In Edit new file, paste the following YAML contents to overwrite the sample code. Accept the default filename `main.yml`, or provide a filename you choose.
- Select Start commit, optionally provide short and extended descriptions of your commit, and select Commit new file.

```yml
on: [push]

name: Linux_Container_Node_Workflow

jobs:
  build-and-deploy:
    runs-on: ubuntu-latest
    defaults:
          run:
            working-directory: ./dockerized/CryptoTicker
    steps:
    # checkout the repo
    - name: 'Checkout GitHub Action' 
      uses: actions/checkout@main
    
    - name: 'Login via Azure CLI'
      uses: azure/login@v1
      with:
        creds: ${{ secrets.AZURE_CREDENTIALS }}
    
    - uses: azure/docker-login@v1
      with:
        login-server: mycontainer.azurecr.io
        username: ${{ secrets.REGISTRY_USERNAME }}
        password: ${{ secrets.REGISTRY_PASSWORD }}
    - run: |
        docker build . -t mycontainer.azurecr.io/myapp:${{ github.sha }}
        docker push mycontainer.azurecr.io/myapp:${{ github.sha }}     
      
    - uses: azure/webapps-deploy@v2
      with:
        app-name: 'myapp'
        images: 'mycontainer.azurecr.io/myapp:${{ github.sha }}'
    
    - name: Azure logout
      run: |
        az logout
```