FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

RUN dotnet new console -n BonusApp

COPY Program.cs /app/BonusApp/Program.console

WORKDIR /app/BonusApp
RUN dotnet restore
RUN dotnet build --configuration Release --output /app/out

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "BonusApp.dll"]