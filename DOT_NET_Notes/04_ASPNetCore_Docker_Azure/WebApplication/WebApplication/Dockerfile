#	Build aspnet base image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
#	Build app sdk app dependencies
FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
#	Restore app packages dependencies.
COPY WebApplication.csproj .
RUN dotnet restore WebApplication.csproj
COPY . .
#	build app in release mode. Files are created into /app/build
RUN dotnet build WebApplication.csproj  -c Release -o /app/build
#	publish a release version
FROM build AS publish
#	Packs the application and its dependencies in release mode. Files are 
#	created into a "publish" folder for deployment to a hosting system.
RUN dotnet publish "WebApplication.csproj" -c Release -o /app/publish
#	Create final image
FROM base as final
WORKDIR /app
#	Just copies the built artifact from the previous stage into this new stage.
COPY --from=publish /app/publish .
#	Execute the container's starting script
CMD ["dotnet", "WebApplication.dll"]