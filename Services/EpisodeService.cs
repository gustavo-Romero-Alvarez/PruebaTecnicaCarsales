using PruebaTecnicaCarsalesBack.Interfaces;
using PruebaTecnicaCarsalesBack.Models;

namespace PruebaTecnicaCarsalesBack.Services
{
    public class EpisodeService : IEpisodeService
    {
        private readonly IRickAndMortyClient _client;

        public EpisodeService(IRickAndMortyClient client)
        {
            _client = client;
        }

        public Task<EpisodeResponse> GetEpisodes(int page)
        {
            return _client.GetEpisodes(page);
        }

        public Task<CharacterResponse> GetCharacters(int page, string name, string status)
        {
            return _client.GetCharacters(page, name, status);
        }

        public Task<LocationResponse> GetLocations(int page)
        {
            return _client.GetLocations(page);
        }
    }
}
