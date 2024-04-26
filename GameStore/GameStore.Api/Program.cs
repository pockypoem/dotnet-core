using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = "Data Source=GameStore.db"; // path location for sqlite db file

// register service
builder.Services.AddSqlite<GameStoreContext>(connString); // konfigurasi Dependency Injection


var app = builder.Build();


app.MapGamesEndpoints();



app.Run();
