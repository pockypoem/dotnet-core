using GameStore.Api.Dtos;
using GameStore.Api.Entities;

namespace GameStore.Api.Mapping;

public static class GameMapping
{
    // map game dto to game entity
    public static Game ToEntity(this CreateGameDto game) {
        // only care about DTO
        return new() {
            Name = game.Name,
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    } 

    public static Game ToEntity(this UpdateGameDto game, int id) {

        return new() {
            Id = id,
            Name = game.Name,
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    }

    // map game entity back into game dto
    public static GameSummaryDto ToGameSummaryDto(this Game game) {
        return new (
            game.Id,
            game.Name,
            game.Genre!.Name, // genre never been null
            game.Price,
            game.ReleaseDate
        );
    }

    public static GameDetailsDto ToGameDetailsDto(this Game game) {
        return new (
            game.Id,
            game.Name,
            game.GenreId,
            game.Price,
            game.ReleaseDate
        );
    }
}
