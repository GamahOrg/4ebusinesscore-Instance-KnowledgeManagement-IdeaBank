#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Delivery/IdeaBank.API/Src/API/IdeaBank.API/IdeaBank.API.csproj","Delivery/IdeaBank.API/Src/API/IdeaBank.API/"]
RUN dotnet restore "Delivery/IdeaBank.API/Src/API/IdeaBank.API/IdeaBank.API.csproj"
COPY . .
WORKDIR "/src/Delivery/IdeaBank.API/Src/API/IdeaBank.API"
RUN dotnet build "IdeaBank.API.csproj" -c Release -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "IdeaBank.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app/publish
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IdeaBank.API.dll"]