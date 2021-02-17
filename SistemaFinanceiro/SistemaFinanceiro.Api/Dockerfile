#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["SistemaFinanceiro.Api/SistemaFinanceiro.Api.csproj", "SistemaFinanceiro.Api/"]
COPY ["SistemaFinanceiro.Domain/SistemaFinanceiro.Domain.csproj", "SistemaFinanceiro.Domain/"]
COPY ["SistemaFinanceiro.Service/SistemaFinanceiro.Service.csproj", "SistemaFinanceiro.Service/"]
COPY ["SistemaFinanceiro.Configuracoes/SistemaFinanceiro.Configuracoes.csproj", "SistemaFinanceiro.Configuracoes/"]
RUN dotnet restore "SistemaFinanceiro.Api/SistemaFinanceiro.Api.csproj"
COPY . .
WORKDIR "/src/SistemaFinanceiro.Api"
RUN dotnet build "SistemaFinanceiro.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SistemaFinanceiro.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SistemaFinanceiro.Api.dll"]