using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore"); // access connection string from appsettings
// register service
builder.Services.AddSqlite<GameStoreContext>(connString); // konfigurasi Dependency Injection

// by doing with scoped life time
// ensures that a new instance of the DB Context is created and disposed for every single request
// builder.Services.AddScoped<GameStoreContext>


var app = builder.Build();


app.MapGamesEndpoints();

app.MigrateDb();



app.Run();
