#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.
# v0.0.5
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["RGO/RGO.csproj", "RGO/"]
COPY ["RGO.DataAccess/RGO.DataAccess.csproj", "RGO.DataAccess/"]
COPY ["RGO.Models/RGO.Models.csproj", "RGO.Models/"]
COPY ["RGO.Utility/RGO.Utility.csproj", "RGO.Utility/"]
RUN dotnet restore "./RGO/./RGO.csproj"
COPY . .
WORKDIR "/src/RGO"
RUN dotnet build "./RGO.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./RGO.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RGO.dll"]