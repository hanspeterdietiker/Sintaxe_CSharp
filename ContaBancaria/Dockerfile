FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ContaBancaria/ContaBancaria.csproj", "ContaBancaria/"]
RUN dotnet restore "ContaBancaria/ContaBancaria.csproj"
COPY . .
WORKDIR "/src/ContaBancaria"
RUN dotnet build "ContaBancaria.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ContaBancaria.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ContaBancaria.dll"]
