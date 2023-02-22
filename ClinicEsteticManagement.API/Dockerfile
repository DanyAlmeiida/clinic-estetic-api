FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ClinicEsteticManagement.API/ClinicEsteticManagement.API.csproj", "ClinicEsteticManagement.API/"]
COPY ["ClinicEsteticManagement.Application/ClinicEsteticManagement.Application.csproj", "ClinicEsteticManagement.Application/"]
COPY ["ClinicEsteticManagement.Domain/ClinicEsteticManagement.Domain.csproj", "ClinicEsteticManagement.Domain/"]
COPY ["ClinicEsteticManagement.Persistence/ClinicEsteticManagement.Persistence.csproj", "ClinicEsteticManagement.Persistence/"]
RUN dotnet restore "ClinicEsteticManagement.API/ClinicEsteticManagement.API.csproj"
COPY . .
WORKDIR "/src/ClinicEsteticManagement.API"
RUN dotnet build "ClinicEsteticManagement.API.csproj" -c Release -o /app/build
RUN dotnet tool update --global dotnet-ef
RUN export PATH="$PATH:$HOME/.dotnet/tools/"
RUN dotnet-ef database update

FROM build AS publish
RUN dotnet publish "ClinicEsteticManagement.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ClinicEsteticManagement.API.dll"]
