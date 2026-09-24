# syntax=docker/dockerfile:1.7-labs

# Build:
# docker build -t project:local .

# Run:
# docker run -p 8080:8080 project:local
# OR
# docker compose -f 'docker-compose.yaml' up -d --build 'app'

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

# Copy project files and publish
WORKDIR /build

COPY src src
COPY . .

RUN dotnet publish -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "UI.dll"]

# docker buildx build -t portfolio:latest .
# docker run -p 8080:8080 portfolio:latest

# docker tag $TAGGED_IMAGE $ACR_IMAGE
