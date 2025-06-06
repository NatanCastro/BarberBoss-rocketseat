FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/BarberBoss.WebAPI/BarberBoss.WebAPI.csproj", "src/BarberBoss.WebAPI/"]
RUN dotnet restore "src/BarberBoss.WebAPI/BarberBoss.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/BarberBoss.WebAPI"
RUN dotnet build "./BarberBoss.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./BarberBoss.WebAPI.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BarberBoss.WebAPI.dll"]
