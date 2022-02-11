FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

RUN dotnet restore "MyBg/MyBg.csproj"
COPY . .
WORKDIR "/src/MyBg"
RUN dotnet build "MyBg.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyBg.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ["dotnet", "MyBg.dll"]