FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PrimeiroProjeto/PrimeiroProjeto.csproj", "PrimeiroProjeto/"]
RUN dotnet restore "PrimeiroProjeto/PrimeiroProjeto.csproj"
COPY . .
WORKDIR "/src/PrimeiroProjeto"
RUN dotnet build "PrimeiroProjeto.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PrimeiroProjeto.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PrimeiroProjeto.dll"]
