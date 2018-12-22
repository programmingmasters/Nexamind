FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Nexamind/Nexamind.csproj", "Nexamind/"]
RUN dotnet restore "Nexamind/Nexamind.csproj"
COPY . .
WORKDIR "/src/Nexamind"
RUN dotnet build "Nexamind.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Nexamind.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Nexamind.dll"]