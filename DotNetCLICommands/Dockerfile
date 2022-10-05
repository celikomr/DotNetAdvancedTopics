#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DotNetCLICommands/DotNetCLICommands.csproj", "DotNetCLICommands/"]
RUN dotnet restore "DotNetCLICommands/DotNetCLICommands.csproj"
COPY . .
WORKDIR "/src/DotNetCLICommands"
RUN dotnet build "DotNetCLICommands.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DotNetCLICommands.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DotNetCLICommands.dll"]