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