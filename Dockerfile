# Use Windows-based .NET SDK image
FROM mcr.microsoft.com/dotnet/sdk:8.0-nanoserver-ltsc2022 AS build
WORKDIR /app

# Copy everything
COPY . .

# Restore dependencies
RUN dotnet restore

# Build the application
RUN dotnet build -c Release -o out --no-restore

# Test stage
FROM build AS test
WORKDIR /app
RUN dotnet add package NUnit3TestAdapter --version 4.5.0
RUN dotnet add package Microsoft.NET.Test.Sdk --version 17.6.3
RUN mkdir C:\app\TestResults