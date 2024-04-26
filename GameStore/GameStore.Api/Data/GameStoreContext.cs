using GameStore.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

// <GameStoreContext> adalah parameter tipe generik yang menentukan bahwa opsi yang dikonfigurasi adalah untuk instance GameStoreContext.

// our context is ready to go ahead and map our objects (our entities) into proper databases
public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
{
    public DbSet<Game> Games => Set <Game>();

    public DbSet<Genre> Genres => Set<Genre>();
}
