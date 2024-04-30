using GameStore.Api.Data;
using GameStore.Api.Dtos;
using GameStore.Api.Entities;
using GameStore.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Endpoints;

public static class GamesEndpoints
{
    const string GetGameEndpointName = "GetGame";

    public static RouteGroupBuilder MapGamesEndpoints(this WebApplication app) {

        var group = app.MapGroup("games")
                        .WithParameterValidation(); // apply to all endpoints.

        // GET /games
        group.MapGet("/", async (GameStoreContext dbContext) => 
            await dbContext.Games
                    .Include(game => game.Genre) // to prevent N + 1 Problem
                    .Select(game => game.ToGameSummaryDto())
                    .AsNoTracking() // don't need tracking of the return entities, just send them back to client
                    .ToListAsync()); 

        // GET /games/1
        group.MapGet("/{id}", async (int id, GameStoreContext dbContext) => {
            Game? game = await dbContext.Games.FindAsync(id);

            return game is null ? Results.NotFound() : Results.Ok(game.ToGameDetailsDto());
        })
        .WithName(GetGameEndpointName);

        // POST /games
        group.MapPost("/", async (CreateGameDto newGame, GameStoreContext dbContext) => {

            Game game = newGame.ToEntity();

            dbContext.Games.Add(game);
            await dbContext.SaveChangesAsync(); // transform all of the changes that have been tracked by Entity Framework 
            // and translates that into whatever SQL statements needs to be executed into database to insert the new record into the table games

            return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game.ToGameDetailsDto());
        });
        // .WithParameterValidation(); // will recognized the data annotation in CreateGameDto
        // but we can also apply for all endpoints in the group variables

        // PUT /games/1
        group.MapPut("/{id}", async (int id, UpdateGameDto updatedGame, GameStoreContext dbContext) => {
            var existingGame = await dbContext.Games.FindAsync(id);

            if (existingGame is null) {
                return Results.NotFound();
            }

            // Entry: to locate the current entity inside that DBContext
            dbContext.Entry(existingGame)
                    .CurrentValues
                    .SetValues(updatedGame.ToEntity(id));

            await dbContext.SaveChangesAsync(); 

            return Results.NoContent(); 
        });

        // DELETE /games/1
        group.MapDelete("/{id}", async (int id, GameStoreContext dbContext) => {
            
            // batch delete for efficiency memory
            await dbContext.Games
                .Where(game => game.Id == id)
                .ExecuteDeleteAsync();

            return Results.NoContent();
        });

        return group;
    }
}
