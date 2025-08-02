# Use the official Microsoft .NET Framework 4.8 ASP.NET image
FROM mcr.microsoft.com/dotnet/framework/aspnet:4.8-windowsservercore-ltsc2022

# Set the working directory
WORKDIR /inetpub/wwwroot

# Copy published Web API files
COPY ./TestApp.API/ .

# Expose the default HTTP port
EXPOSE 80
