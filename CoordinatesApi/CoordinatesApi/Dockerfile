FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CoordinatesApi/CoordinatesApi.WebApi.csproj", "CoordinatesApi/"]
COPY ["CoordinatesApi.Core/CoordinatesApi.Core.csproj", "CoordinatesApi.Core/"]
COPY ["CoordinatesApi.Data/CoordinatesApi.Data.csproj", "CoordinatesApi.Data/"]
COPY ["CoordinatesApi.Shared/CoordinatesApi.Shared.csproj", "CoordinatesApi.Shared/"]
RUN dotnet restore "CoordinatesApi/CoordinatesApi.WebApi.csproj"
COPY . .
WORKDIR "/src/CoordinatesApi"
RUN dotnet build "CoordinatesApi.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoordinatesApi.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoordinatesApi.WebApi.dll"]