FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR ../
COPY ["FinanceManagerBackend.Api/FinanceManagerBackend.Api.csproj", "FinanceManagerBackend.Api/"]
COPY ["FinanceManagerBackend.Data/FinanceManagerBackend.Data.csproj", "FinanceManagerBackend.Data/"]
COPY ["FinanceManagerBackend.Core/FinanceManagerBackend.Core.csproj", "FinanceManagerBackend.Core/"]
RUN dotnet restore "FinanceManagerBackend.Api/FinanceManagerBackend.Api.csproj"
COPY . .
WORKDIR "/FinanceManagerBackend.Api"
RUN dotnet build "FinanceManagerBackend.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FinanceManagerBackend.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinanceManagerBackend.Api.dll"]
