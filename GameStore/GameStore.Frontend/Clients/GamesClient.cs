using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

// we are recieving that injected HTTP Client via dependency injection
public class GamesClient(HttpClient httpClient)
{

    public async Task<GameSummary[]> GetGamesAsync() 
        => await httpClient.GetFromJsonAsync<GameSummary[]>("games") ?? []; // if null return empty array

    public async Task AddGameAsync(GameDetails game)
        => await httpClient.PostAsJsonAsync("games", game);


    public async Task<GameDetails> GetGameAsync(int id)
        => await httpClient.GetFromJsonAsync<GameDetails>($"games/{id}")
            ?? throw new Exception("Could not find the game!");

    public async Task UpdateGameAsync(GameDetails updatedGame)
        => await httpClient.PutAsJsonAsync($"games/{updatedGame.Id}", updatedGame);


    public async Task DeleteGameAsync(int id)
        => await httpClient.DeleteAsync($"games/{id}");

}
