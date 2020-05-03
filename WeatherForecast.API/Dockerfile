FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["WeatherForecast.API/WeatherForecast.API.csproj", "WeatherForecast.API/"]
RUN dotnet restore "WeatherForecast.API/WeatherForecast.API.csproj"
COPY . .
WORKDIR "/src/WeatherForecast.API"
RUN dotnet build "WeatherForecast.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WeatherForecast.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WeatherForecast.API.dll"]