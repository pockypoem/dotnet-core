using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;


// for execute migration when the app is start
public static class DataExtensions
{
    // extension method must be static
    // Task merepresentasikan sebuah operasi yang sedang berjalan atau akan dijalankan secara asynchronous
    public static async Task MigrateDbAsync(this WebApplication app) {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
        await dbContext.Database.MigrateAsync();
    }
}
