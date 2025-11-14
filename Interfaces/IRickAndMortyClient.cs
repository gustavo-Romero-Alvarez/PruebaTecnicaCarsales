using PruebaTecnicaCarsalesBack.Models;


namespace PruebaTecnicaCarsalesBack.Interfaces
{
    public interface IRickAndMortyClient
    {
        Task<EpisodeResponse> GetEpisodes(int page);
        Task<CharacterResponse> GetCharacters(int page, string name, string status);
        Task<LocationResponse> GetLocations(int page);
    }
}
