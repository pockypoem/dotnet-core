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

    // map game entity back into game dto
    public static GameDto ToDto(this Game game) {
        return new (
            game.Id,
            game.Name,
            game.Genre!.Name, // genre never been null
            game.Price,
            game.ReleaseDate
        );
    }
}
