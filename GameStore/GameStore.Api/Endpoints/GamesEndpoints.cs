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
        group.MapGet("/", (GameStoreContext dbContext) => 
            dbContext.Games
                    .Include(game => game.Genre) // to prevent N + 1 Problem
                    .Select(game => game.ToGameSummaryDto())
                    .AsNoTracking()); // don't need tracking of the return entities, just send them back to client

        // GET /games/1
        group.MapGet("/{id}", (int id, GameStoreContext dbContext) => {
            Game? game = dbContext.Games.Find(id);

            return game is null ? Results.NotFound() : Results.Ok(game.ToGameDetailsDto());
        })
        .WithName(GetGameEndpointName);

        // POST /games
        group.MapPost("/", (CreateGameDto newGame, GameStoreContext dbContext) => {

            Game game = newGame.ToEntity();

            dbContext.Games.Add(game);
            dbContext.SaveChanges(); // transform all of the changes that have been tracked by Entity Framework 
            // and translates that into whatever SQL statements needs to be executed into database to insert the new record into the table games

            return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game.ToGameDetailsDto());
        });
        // .WithParameterValidation(); // will recognized the data annotation in CreateGameDto
        // but we can also apply for all endpoints in the group variables

        // PUT /games/1
        group.MapPut("/{id}", (int id, UpdateGameDto updatedGame, GameStoreContext dbContext) => {
            var existingGame = dbContext.Games.Find(id);

            if (existingGame is null) {
                return Results.NotFound();
            }

            // Entry: to locate the current entity inside that DBContext
            dbContext.Entry(existingGame)
                    .CurrentValues
                    .SetValues(updatedGame.ToEntity(id));

            dbContext.SaveChanges(); 

            return Results.NoContent(); 
        });

        // DELETE /games/1
        group.MapDelete("/{id}", (int id, GameStoreContext dbContext) => {
            
            // batch delete for efficiency memory
            dbContext.Games
                .Where(game => game.Id == id)
                .ExecuteDelete();

            return Results.NoContent();
        });

        return group;
    }
}
