# Booking App

Simple C# app to make reservations.

# Setup

## Steps to setup a dotnet project with asp.net core and a sqlite database

```{shell}
mkdir <PROJECTNAME>
cd <PROJECTNAME>
dotnet new sln
mkdir <APPNAME>
cd <APPNAME>
dotnet new reactredux   ##asp.net core 2.1.1 react
cd ..
dotnet sln add <APPNAME>/<APPNAME>.csproj
mkdir <APPNAME>.Tests
cd <APPNAME>.Tests
dotnet new xUnit
cd ..
dotnet sln add <APPNAME>.Tests/<APPNAME>.Tests.csproj
cd <APPNAME>.Tests
dotnet add reference ../<APPNAME>/<APPNAME>.csproj
dotnet add package Microsoft.AspNetCore.App --version 2.1.2 ## same as web project
cd ../<APPNAME>
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 2.1.8
dotnet add package Microsoft.EntityFrameworkCore.Design --version 2.1.8
```

# Links

## More documention

* [ASP.NET Core Setup database](https://docs.microsoft.com/en-us/ef/core/get-started/aspnetcore/new-db?tabs=netcore-cli)
* [ASP.NET Core 2.1 Web Application using PostgreSQL with Entity Framework](https://github.com/jasonsturges/postgresql-dotnet-core)
* [Unit Testing in ASP.NET Core Web API](https://code-maze.com/unit-testing-aspnetcore-web-api/)

# License

Copyright (c) 2019 David Rasch.

This program is released under license GPL v3 or later.
