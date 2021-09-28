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