using GameStore.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

// <GameStoreContext> adalah parameter tipe generik yang menentukan bahwa opsi yang dikonfigurasi adalah untuk instance GameStoreContext.

// our context is ready to go ahead and map our objects (our entities) into proper databases
public class GameStoreContext(DbContextOptions<GameStoreContext> options) : DbContext(options)
{
    public DbSet<Game> Games => Set <Game>();

    public DbSet<Genre> Genres => Set<Genre>();


    // this is one of the methods that going to be executed as soon as the migration is executed
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new {Id = 1, Name = "Fighting"},
            new {Id = 2, Name = "Roleplaying"},
            new {Id = 3, Name = "Sports"},
            new {Id = 4, Name = "Racing"},
            new {Id = 5, Name = "Kids and Family"}
        );
    }
}
