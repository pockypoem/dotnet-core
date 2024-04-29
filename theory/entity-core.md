# Entity Framework Core

## The Need for Object-Relational Mapping (O/RM)
![Image](./images/16-orm.png)


## What is Object Relational Mapping (O/RM)?
![Image](./images/17-what-is-orm.png)

## What is Entity Framework Core?
> A lightweight, extensible, open source, and cross-platform object-relational mapper for .NET

![Image](./images/18-entity-framework-core.png) 


----
Entities folder represent our data model

* DBContext is really an object that represents a session with database and that can be used to query and save instances of your entities

![Image](./images/19-db-context-chatgpt.png)
<br>

Kegunaan `GameStoreContext`: <br>
![Image](./images/20-game-store-context.png)


# The ASP.NET Core Configuration System
```csharp
var connString = "Data Source=GameStore.db"; // path location for sqlite db file

// register service
builder.Services.AddSqlite<GameStoreContext>(connString);
```

is not ideal to store connection string directly like that. There is betterway to store connection string: <br>
![Image](./images/21-better-way.png)



# Understanding Dependency Injection

## What is a Dependency?
![Image](./images/22-dependency.png)

## What is Dependency Injection?
![Image](./images/23-dependency-injection.png)

## Using Dependency Inversion
> Prinsip Inversi Dependensi (Dependency Inversion Principle) menyatakan bahwa kode seharusnya bergantung pada abstraksi daripada implementasi konkret. Artinya, dalam desain perangkat lunak, kelas tingkat tinggi seharusnya tidak tergantung pada kelas tingkat rendah secara langsung. Sebaliknya, keduanya harus bergantung pada abstraksi. Dengan menerapkan prinsip ini, perubahan dalam kelas tingkat rendah (implementasi) tidak akan mempengaruhi kelas tingkat tinggi (abstraksi), sehingga memudahkan untuk mengubah atau memperluas kode dengan lebih fleksibel. Prinsip ini adalah salah satu dari lima prinsip desain solid (SOLID principles) yang dikemukakan oleh Robert C. Martin.

![Image](./images/24-dependency-inversion.png)


## When should instances be created?
![Image](./images/25-when-should-use.png) <br>


### The Transient Service Lifetime
* Let's say that my logger is a very lightweight and stateless service, so it is okay to create a new instance every single time any class need it. 
* In that case, you would register MyLogger with `AddTransient<MyLogger>()` method
![Image](./images/26-transient-service-lifetime.png) <br>

### The Scoped Service Lifetime
* What if my logger is a class that keeps track of some sort of state that needs to be shared across multiple classes that participate in an HTTP Request
* In that case, you would register MyLogger with `AddScoped<MyLogger>()` method
![Image](./images/27-scoped-service-lifetime.png) <br>

### The Singleton Service Lifetime
* Let's say that MyLogger is not cheap to instantiate and it keeps track of a state that should be shared with all classes that requested during the entire lifetime of your application
* then you would register MyLogger with the `AddSingleton<MyLogger>()` method
![Image](./images/28-singleton-service-lifetime.png)


## Info 3 Service Lifetime -chatgpt
![Image](./images/29-three-services-lifetime.png)

Contoh penerapan di ASP .NET Core: <br>
```csharp
// Contoh layanan Transient
services.AddTransient<ILoggerService, LoggerService>();

// Contoh layanan Scoped
services.AddScoped<IDatabaseService, DatabaseService>();

// Contoh layanan Singleton
services.AddSingleton<IConfigurationService, ConfigurationService>();

```

Dalam contoh di atas, `LoggerService` akan dibuat ulang setiap kali diminta (transient), `DatabaseService` akan dibuat satu kali per permintaan HTTP (scoped), dan `ConfigurationService` akan dibuat sekali selama aplikasi berjalan (singleton).
