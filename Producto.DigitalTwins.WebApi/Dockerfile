FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 8090
EXPOSE 8091

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["./Producto.DigitalTwins.WebApi/Producto.DigitalTwins.WebApi.csproj", "Producto.DigitalTwins.WebApi/"]
COPY ["./Producto.DigitalTwins.Application/Producto.DigitalTwins.Application.csproj", "Producto.DigitalTwins.Application/"]
COPY ["./Producto.DigitalTwins.Domain/Producto.DigitalTwins.Domain.csproj", "Producto.DigitalTwins.Domain/"]
COPY ["./Producto.DigitalTwins.Contract/Producto.DigitalTwins.Contract.csproj", "Producto.DigitalTwins.Contract/"]
COPY ["./Producto.DigitalTwins.Infrastructure/Producto.DigitalTwins.Infrastructure.csproj", "Producto.DigitalTwins.Infrastructure/"]
RUN dotnet restore "./Producto.DigitalTwins.WebApi/Producto.DigitalTwins.WebApi.csproj"
COPY . .
WORKDIR "/src/Producto.DigitalTwins.WebApi"
RUN dotnet build "./Producto.DigitalTwins.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Producto.DigitalTwins.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Producto.DigitalTwins.WebApi.dll"]