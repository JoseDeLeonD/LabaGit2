#FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
#WORKDIR /src

#COPY ["LabaGit.csproj", "./"]
#RUN dotnet restore "LabaGit.csproj"

#COPY . .
#RUN dotnet publish "LabaGit.csproj" -c Release -o /app/publish

#FROM mcr.microsoft.com/dotnet/runtime:9.0
#WORKDIR /app
#COPY --from=build /app/publish .
#ENTRYPOINT ["dotnet", "LabaGit.dll"]


FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["LabaGit/LabaGit.csproj", "LabaGit/"]

RUN dotnet restore "LabaGit/LabaGit.csproj"

COPY . .

WORKDIR "/src/LabaGit"

RUN dotnet publish "LabaGit.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "LabaGit.dll"]
