# Booking App

Simple C# app to make reservations. ***WORK IN PROGRESS***

# Setup

## Steps to setup a dotnet project with asp.net core and a sqlite database

```{shell}
mkdir <PROJECTNAME>
cd <PROJECTNAME>
dotnet new sln
mkdir <APPNAME>
cd <APPNAME>
dotnet new reactredux
cd ..
dotnet sln add <APPNAME>/<APPNAME>.csproj
mkdir <APPNAME>.Tests
cd <APPNAME>.Tests
dotnet new xUnit
cd ..
dotnet sln add <APPNAME>.Tests/<APPNAME>.Tests.csproj
cd <APPNAME>.Tests
dotnet add reference ../<APPNAME>/<APPNAME>.csproj
dotnet add package Microsoft.AspNetCore.App  ## same as web project
cd ../<APPNAME>
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 2.2.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 2.2.0
dotnet add package Swashbuckle.AspNetCore
```

# Running

```{shell}
export ASPNETCORE_ENVIRONMENT=Development dotnet run
```
https://127.0.0.1:5001/

## View Swagger

https://127.0.0.1:5001/swagger/index.html

# Entity Framework

## Initial creation
```{shell}
dotnet ef migrations add InitialCreate
```

## Start with clean db
```{shell}
rm bookings.db
dotnet ef database update
```

# Upgrade dotnet version
https://docs.microsoft.com/en-us/aspnet/core/migration/21-to-22?view=aspnetcore-2.2&tabs=visual-studio-mac

# Tools

## Dotnet format

### Install
dotnet tool install -g dotnet-format

### Usage
dotnet format

## More tools

https://github.com/natemcmaster/dotnet-tools

# Links

## More documention

* [ASP.NET Core Setup database](https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/new-db?tabs=netcore-cli)
* [ASP.NET Core 2.1 Web Application using PostgreSQL with Entity Framework](https://github.com/jasonsturges/postgresql-dotnet-core)
* [Unit Testing in ASP.NET Core Web API](https://code-maze.com/unit-testing-aspnetcore-web-api/)
* [Test controller logic in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/testing?view=aspnetcore-2.2)
* [Building Single Page Applications on ASP.NET Core with JavaScriptServices](https://devblogs.microsoft.com/aspnet/building-single-page-applications-on-asp-net-core-with-javascriptservices/)
* [Getting started with swashbuckle](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-2.2&tabs=visual-studio)

# License

Copyright (c) 2019 David Rasch.

This program is released under license GPL v3 or later.
