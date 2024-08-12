# Web API docker

## Dev-Certificates

```powershell
dotnet dev-certs https -ep $env:USERPROFILE\.aspnet\https\producto.digitaltwins.webapi.pfx -p <CREDENTIAL_PLACEHOLDER>
dotnet dev-certs https --trust 
```

En caso de que de el siguiente mensaje:

>A valid HTTPS certificate is already present.

Se puede exportar desde el **MMC Console**

## User Secrets

```powershell
dotnet user-secrets init -p producto.digitaltwins.webapi\producto.digitaltwins.webapi.csproj
dotnet user-secrets -p producto.digitaltwins.webapi\producto.digitaltwins.webapi.csproj set "Kestrel:Certificates:Development:Password" "<CREDENTIAL_PLACEHOLDER>"
```

## Docker build

```powershell
\Producto.DigitalTwins> docker buildx build -t producto.digitaltwins.webapi:1.0 -f  .\Producto.DigitalTwins.WebApi\Dockerfile .
```

## Docker Run

```powershell
docker run --rm -it -p 8080:8080 -p 8081:8081 -v $env:APPDATA\microsoft\UserSecrets\:/root/.microsoft/usersecrets -v $env:USERPROFILE\.aspnet\https:/root/.aspnet/https/ -e ASPNETCORE_HTTPS_PORTS=8081 -e ASPNETCORE_ENVIRONMENT=Development -e ASPNETCORE_Kestrel__Certificates__Default__Password="netadmin" -e ASPNETCORE_Kestrel__Certificates__Default__Path=/root/.aspnet/https/producto.digitaltwins.webapi.pfx producto.digitaltwins.webapi:1.0
```