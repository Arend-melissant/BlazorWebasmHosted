FROM mcr.microsoft.com/dotnet/aspnet:6.0.0-preview.4-focal AS base
WORKDIR /app
EXPOSE 5001
EXPOSE 80
EXPOSE 443


FROM mcr.microsoft.com/dotnet/sdk:6.0.100-preview.4-focal AS build
WORKDIR /src
COPY ["Server/BlazorWebasmHosted.Server.csproj", "Server/"]
RUN dotnet restore "Server/BlazorWebasmHosted.Server.csproj"
COPY . .
WORKDIR "/src/Server"
RUN dotnet build "BlazorWebasmHosted.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorWebasmHosted.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorWebasmHosted.Server.dll"]