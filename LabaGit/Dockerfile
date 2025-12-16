FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["LabaGit.csproj", "./"]
RUN dotnet restore "LabaGit.csproj"

COPY . .
RUN dotnet publish "LabaGit.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/runtime:9.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "LabaGit.dll"]