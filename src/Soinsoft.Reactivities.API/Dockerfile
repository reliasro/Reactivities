FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["./Soinsoft.Reactivities.API/Soinsoft.Reactivities.API.csproj", "src/Soinsoft.Reactivities.API/"]
RUN dotnet restore "src\Soinsoft.Reactivities.API\Soinsoft.Reactivities.API.csproj"
COPY . .
WORKDIR "/src/Soinsoft.Reactivities.API"
RUN dotnet build "Soinsoft.Reactivities.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Soinsoft.Reactivities.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Soinsoft.Reactivities.API.dll"]
