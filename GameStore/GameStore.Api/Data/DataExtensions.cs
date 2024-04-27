using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;


// for execute migration when the app is start
public static class DataExtensions
{
    // extension method must be static
    public static void MigrateDb(this WebApplication app) {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();
        dbContext.Database.Migrate();
    }
}
