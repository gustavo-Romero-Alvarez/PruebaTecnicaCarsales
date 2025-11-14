using Microsoft.Extensions.Options;
using PruebaTecnicaCarsalesBack.Configuration;
using PruebaTecnicaCarsalesBack.Interfaces;
using PruebaTecnicaCarsalesBack.Models;
using System.Text.Json;

namespace PruebaTecnicaCarsalesBack.Clients
{
    public class RickAndMortyClient : IRickAndMortyClient
    {
        private readonly HttpClient _http;
        private readonly RickAndMortySettings _settings;

        public RickAndMortyClient(HttpClient http, IOptions<RickAndMortySettings> settings)
        {
            _http = http;
            _settings = settings.Value;
            _http.BaseAddress = new Uri(_settings.BaseUrl);
        }

        private async Task<T> GetAsync<T>(string endpoint)
        {
            var response = await _http.GetAsync(endpoint);
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public Task<EpisodeResponse> GetEpisodes(int page) =>
            GetAsync<EpisodeResponse>($"episode?page={page}");

        public Task<CharacterResponse> GetCharacters(int page, string name, string status) =>
            GetAsync<CharacterResponse>($"character?page={page}&name={name}&status={status}");

        public Task<LocationResponse> GetLocations(int page) =>
            GetAsync<LocationResponse>($"location?page={page}");
    }
}
