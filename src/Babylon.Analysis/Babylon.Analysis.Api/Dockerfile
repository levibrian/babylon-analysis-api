FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release

WORKDIR /src
COPY ["Babylon.Analysis.Api/Babylon.Analysis.Api.csproj", "Babylon.Analysis.Api/"]
RUN dotnet restore "Babylon.Analysis.Api/Babylon.Analysis.Api.csproj"

COPY . .
WORKDIR "/src/Babylon.Analysis.Api"
RUN dotnet build "Babylon.Analysis.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Babylon.Analysis.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Babylon.Analysis.Api.dll"]
