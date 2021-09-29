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
WORKDIR /usr/share/nginx/html

COPY --from=publish /publish/wwwroot /usr/local/webapp/nginx/html
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

[Configure a GitHub action to create a container instance](https://docs.microsoft.com/en-us/azure/container-instances/container-instances-github-action)

### Prerequisites
I already have created the Azure container registry.
If you don't have one, create an Azure container registry in the Basic tier using the Azure CLI, Azure portal, or other methods. Take note of the resource group used for the deployment, which is used for the GitHub workflow.

### Create service principal for Azure authentication
In the GitHub workflow, you need to supply Azure credentials to authenticate to the Azure CLI. The following example creates a service principal with the Contributor role scoped to the resource group for your container registry.

First, get the resource ID of your resource group. Substitute the name of your group in the following `az group show` command:
```
groupId=$(az group show \
  --name <resource-group-name> \
  --query id --output tsv)
```

Use az ad sp create-for-rbac to create the service principal:
```
az ad sp create-for-rbac \
  --scope $groupId \
  --role Contributor \
  --sdk-auth
```
Output is similar to:
```
{
  "clientId": "xxxx6ddc-xxxx-xxxx-xxx-ef78a99dxxxx",
  "clientSecret": "xxxx79dc-xxxx-xxxx-xxxx-aaaaaec5xxxx",
  "subscriptionId": "xxxx251c-xxxx-xxxx-xxxx-bf99a306xxxx",
  "tenantId": "xxxx88bf-xxxx-xxxx-xxxx-2d7cd011xxxx",
  "activeDirectoryEndpointUrl": "https://login.microsoftonline.com",
  "resourceManagerEndpointUrl": "https://management.azure.com/",
  "activeDirectoryGraphResourceId": "https://graph.windows.net/",
  "sqlManagementEndpointUrl": "https://management.core.windows.net:8443/",
  "galleryEndpointUrl": "https://gallery.azure.com/",
  "managementEndpointUrl": "https://management.core.windows.net/"
}
```

### Update service principal for registry authentication

Update the Azure service principal credentials to allow push and pull access to your container registry. This step enables the GitHub workflow to use the service principal to authenticate with your container registry and to push and pull a Docker image.

Get the resource ID of your container registry. Substitute the name of your registry in the following `az acr show` command:
```
registryId=$(az acr show \
  --name <registry-name> \
  --query id --output tsv)
```

Use `az role assignment create` to assign the AcrPush role, which gives push and pull access to the registry. Substitute the client of your service principal:
```
az role assignment create \
  --assignee <ClientId> \
  --scope $registryId \
  --role AcrPush
```

### Save credentails to GitHub repo
- In the GitHub UI, navigate to your forked repository and select Settings > Secrets.
- Select `Add a new secret ` to add the following secrets:
| `AZURE_CREDENTIALS` | The entire JSON output from the service principal creation step |
|---|---|
| `REGISTRY_LOGIN_SERVER` | The login server name of your registry (all lowercase). Example: myregistry.azurecr.io |
| `REGISTRY_USERNAME` | The `clientId` from the JSON output from the service principal creation |
| `REGISTRY_PASSWORD` | The `clientSecret` from the JSON output from the service principal creation |
| `RESOURCE_GROUP` | The name of the resource group you used to scope the service principal |


### Create GitHub Workflow

- In the GitHub UI, select Actions > New workflow.
- Select Set up a workflow yourself.
- In Edit new file, paste the following YAML contents to overwrite the sample code. Accept the default filename `main.yml`, or provide a filename you choose.
- Select Start commit, optionally provide short and extended descriptions of your commit, and select Commit new file.

```yml
on: [push]
name: Linux_Container_Workflow

jobs:
    build-and-deploy:
        runs-on: ubuntu-latest
        steps:
        # checkout the repo
        - name: 'Checkout GitHub Action'
          uses: actions/checkout@main
          
        - name: 'Login via Azure CLI'
          uses: azure/login@v1
          with:
            creds: ${{ secrets.AZURE_CREDENTIALS }}
        
        - name: 'Build and push image'
          uses: azure/docker-login@v1
          with:
            login-server: ${{ secrets.REGISTRY_LOGIN_SERVER }}
            username: ${{ secrets.REGISTRY_USERNAME }}
            password: ${{ secrets.REGISTRY_PASSWORD }}
        - run: |
            docker build . -t ${{ secrets.REGISTRY_LOGIN_SERVER }}/sampleapp:${{ github.sha }}
            docker push ${{ secrets.REGISTRY_LOGIN_SERVER }}/sampleapp:${{ github.sha }}

        - name: 'Deploy to Azure Container Instances'
          uses: 'azure/aci-deploy@v1'
          with:
            resource-group: ${{ secrets.RESOURCE_GROUP }}
            dns-name-label: ${{ secrets.RESOURCE_GROUP }}${{ github.run_number }}
            image: ${{ secrets.REGISTRY_LOGIN_SERVER }}/sampleapp:${{ github.sha }}
            registry-login-server: ${{ secrets.REGISTRY_LOGIN_SERVER }}
            registry-username: ${{ secrets.REGISTRY_USERNAME }}
            registry-password: ${{ secrets.REGISTRY_PASSWORD }}
            name: sample-app
            location: 'west us'
```

### Validate workflow
After you commit the workflow file, the workflow is triggered. To review workflow progress, navigate to Actions > Workflows.

When the workflow completes successfully, get information about the container instance named aci-sampleapp by running the `az container show` command. Substitute the name of your resource group:
```
az container show \
  --resource-group <resource-group-name> \
  --name sample-app \
  --query "{FQDN:ipAddress.fqdn,ProvisioningState:provisioningState}" \
  --output table
```