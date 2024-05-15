FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS backend
WORKDIR /src
COPY Games.Mvc.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish  -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS final
WORKDIR /app
COPY --from=backend /app .

ENTRYPOINT ["dotnet", "Games.Mvc.dll"]