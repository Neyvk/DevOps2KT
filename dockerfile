FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY TimerApp.csproj .
RUN dotnet restore TimerApp.csproj

COPY . .
RUN dotnet publish -c Release -o /app


FROM mcr.microsoft.com/dotnet/runtime:9.0
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "TimerApp.dll"]