#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DapperMicroOrm/DapperMicroOrm.csproj", "DapperMicroOrm/"]
RUN dotnet restore "DapperMicroOrm/DapperMicroOrm.csproj"
COPY . .
WORKDIR "/src/DapperMicroOrm"
RUN dotnet build "DapperMicroOrm.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DapperMicroOrm.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DapperMicroOrm.dll"]