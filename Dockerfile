# Use the official Microsoft .NET Framework 4.8 ASP.NET image
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2022

# Set the working directory to IIS's default web root
WORKDIR /inetpub/wwwroot

# Copy the published Web API output (built by MSBuild)
COPY ./published-api/ .

# Expose the default HTTP port
EXPOSE 80
