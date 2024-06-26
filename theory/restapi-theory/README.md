## What are you going to build:
![Image](./images/01-system.png) <br>

* the frontend part using blazor is on [this video](https://youtu.be/RBVIclt4sOo?si=dcwnIIcGny1S6-OW)

## What this course covers
* Create ASP.NET Core Apps
* Understand REST APIs
* Implement CRUD Endpoints
* Data Transfer Objects (DTOs): to define the contract between API and frontend
* Extension Methods
* Route Groups
* Handle Invalid Inputs
* Entity Framework Core
* Configuration System
* Dependency Injection
* Service Lifetime
* Mapping Entities to DTOs
* Asynchronous Programming
* Frontend Integration

## Is this course for you?
* Basic C# or Java Knowledge
* Web Development Essentials
* Some Database Experience
* Beginner Level Tutorial

## Software Prerequisites
* [.NET](https://dotnet.microsoft.com/en-us/download)
* [Visual Studio Code](https://code.visualstudio.com/)

## Create Project
* `dotnet new list`: list of application template that you can create with your sdk
* atau bisa juga: ctrl + shift + p (buka command palete)
* .NET: New Project
* Lalu akan buka list template project yang tersedia
* Choose: ASP.NET Core Web API (if you already knew)
* but if you are beginner, choose: ASP.NET Core Empty [Choose this]
* pilih folder tempat project
* buat folder nama project
* kasih nama projects `GameStore.Api`


How to build:
* solution explorer > GameStore.Api > right click > build
* in folder .bin, you will find GameStore.Api.dll as a form of assembly compiler by C#

or
* open terminal
* `dotnet build`

How to run:
* press F5 (to select debugger)
* choose C#
* select launch configuration
* C#: Default Configuration and then will run the localhost

![Image](./images/02-localhost-first.png) <br>

> is not just only run the application but also in debug session

Prove, we are on debug session: <br>
![Image](./images/03-prove-on-debug-session.png)

If you want to run your app without debugging session: <br>
![Image](./images/04-without-debugging.png) 

or use terminal: `cd GameStore.Api` > `dotnet run`


## Packages:
* https://www.nuget.org/packages/MinimalApis.Extensions for filtering API and can combine with data annotation to handle invalid input
* https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/9.0.0-preview.3.24172.4 for ORM Sqlite
* https://www.nuget.org/packages/dotnet-ef/8.0.2
* https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/8.0.2


## For migration
Make sure you're in GameStore.Api
* `dotnet ef migrations add InitialCreate --output-dir Data\Migrations`
* execute migration: `dotnet ef database update`
* database will create
* create Data Extensions to automatically migrate up database when the app start running
* delete the db that we create before
* run again the app `dotnet run` to test that our automatic script for migration is succeed

Penambahan `"Microsoft.EntityFrameworkCore.Database.Command": "Warning"` pada appsettings.json artinya:
* Dari command `Microsoft.EntityFrameworkCore.Database.Command` tolong hanya tampilkan ketika ada warning atau error atau something critical, don't show me information messages (nanti logging messages nya jadi terlalu banyak) 


## For seeding data
* Add method for seeder Genre `OnModelCreating`
* in terminal: `dotnet ef migrations add SeedGenres --output-dir Data\Migrations`
* `dotner run` to see the new migration has applied