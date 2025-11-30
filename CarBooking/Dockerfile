FROM mcr.microsoft.com/dotnet/sdk:6.0 AS base
WORKDIR /app  
EXPOSE 443
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CarBooking/CarBooking.csproj", "CarBooking/"]
COPY ["Common/Common.csproj", "Common/"]
COPY ["DatabaseService/DatabaseService.csproj","DatabaseService/"]
COPY ["Model/Model.csproj","Model/"]
RUN dotnet restore "CarBooking.csproj"
COPY . .
WORKDIR "/src/CarBooking/CarBooking"
RUN dotnet build "CarBooking.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CarBooking.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CarBooking.dll"]
