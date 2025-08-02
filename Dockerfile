# Use the ASP.NET 4.8 base image
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2022

SHELL ["powershell", "-Command"]

# Set working directory
WORKDIR /inetpub/wwwroot

# Copy published app
COPY TestApp/bin/Release/ ./

# Expose the port your API uses
EXPOSE 80
