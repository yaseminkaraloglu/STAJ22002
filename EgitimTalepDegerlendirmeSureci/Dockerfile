FROM mcr.microsoft.com/dotnet/core/aspnet:3.1.3-bionic AS base
RUN apt-get update && apt-get install -y tzdata
WORKDIR /app
COPY . /app