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