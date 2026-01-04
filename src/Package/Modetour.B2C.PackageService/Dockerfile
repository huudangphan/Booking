FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app  
EXPOSE 443
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Package/Modetour.B2C.PackageService/Modetour.B2C.PackageService.csproj", "Modetour.B2C.PackageService/"]
COPY ["Package/ModetourB2C/ModetourB2C.csproj", "ModetourB2C/"]
COPY ["Package/Modetour.B2C.Commons/Modetour.B2C.Commons.csproj","Modetour.B2C.Commons/"]
COPY ["Package/Modetour.B2C.PackageService/Modetour.B2C.PackageService.csproj","Modetour.B2C.PackageService/"]
RUN dotnet restore "Modetour.B2C.PackageService/Modetour.B2C.PackageService.csproj"
COPY . .
WORKDIR "/src/Package/Modetour.B2C.PackageService"
RUN dotnet build "Modetour.B2C.PackageService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Modetour.B2C.PackageService.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Modetour.B2C.PackageService.dll"]
