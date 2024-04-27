using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore"); // access connection string from appsettings
// register service
builder.Services.AddSqlite<GameStoreContext>(connString); // konfigurasi Dependency Injection


var app = builder.Build();


app.MapGamesEndpoints();

app.MigrateDb();



app.Run();
