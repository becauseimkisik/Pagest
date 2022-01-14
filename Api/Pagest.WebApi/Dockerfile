#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Api/Pagest.WebApi/Pagest.WebApi.csproj", "Api/Pagest.WebApi/"]
COPY ["Infrastructure/Pagest.Infrastructure.Persistence/Pagest.Infrastructure.Persistence.csproj", "Infrastructure/Pagest.Infrastructure.Persistence/"]
COPY ["Core/Pagest.Domain/Pagest.Domain.csproj", "Core/Pagest.Domain/"]
COPY ["Application/Pagest.Application/Pagest.Application.csproj", "Application/Pagest.Application/"]
COPY ["Infrastructure/Pagest.Infrastructure.Authentication/Pagest.Infrastructure.Authentication.csproj", "Infrastructure/Pagest.Infrastructure.Authentication/"]
RUN dotnet restore "Api/Pagest.WebApi/Pagest.WebApi.csproj"
COPY . .
WORKDIR "/src/Api/Pagest.WebApi"
RUN dotnet build "Pagest.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Pagest.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_URLS http://*:5000
ENTRYPOINT ["dotnet", "Pagest.WebApi.dll"]