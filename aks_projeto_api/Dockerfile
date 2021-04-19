#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["aks_projeto_api/aks_projeto_api.csproj", "aks_projeto_api/"]
RUN dotnet restore "aks_projeto_api/aks_projeto_api.csproj"
COPY . .
WORKDIR "/src/aks_projeto_api"
RUN dotnet build "aks_projeto_api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "aks_projeto_api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "aks_projeto_api.dll"]