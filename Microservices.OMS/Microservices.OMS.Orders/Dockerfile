#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Microservices.OMS.Orders/Microservices.OMS.Orders.csproj", "Microservices.OMS.Orders/"]
RUN dotnet restore "Microservices.OMS.Orders/Microservices.OMS.Orders.csproj"
COPY . .
WORKDIR "/src/Microservices.OMS.Orders"
RUN dotnet build "Microservices.OMS.Orders.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Microservices.OMS.Orders.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Microservices.OMS.Orders.dll"]