FROM mcr.microsoft.com/dotnet/aspnet:8.0 as base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["Babylon.Analysis.Api/Babylon.Analysis.Api.csproj", "Babylon.Analysis.Api/"]
COPY ["Babylon.Analysis.Api.Tests/Babylon.Analysis.Api.Tests.csproj", "Babylon.Analysis.Api.Tests/"]

RUN dotnet restore "Babylon.Analysis.Api/Babylon.Analysis.Api.csproj"

COPY . .
WORKDIR "/src/Babylon.Analysis.Api/"
RUN dotnet build "Babylon.Analysis.Api.csproj" -c Release -o /app/build

WORKDIR "/src/Babylon.Analysis.Api.Tests/"
RUN dotnet test "Babylon.Analysis.Api.Tests.csproj"

WORKDIR "/src/Babylon.Analysis.Api/"
FROM build as publish
RUN dotnet publish "Babylon.Analysis.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base as final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Babylon.Analysis.Api.dll"]
