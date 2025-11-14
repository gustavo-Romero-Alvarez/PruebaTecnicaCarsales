using System.Text.Json.Serialization;

namespace PruebaTecnicaCarsalesBack.Models
{
    public class EpisodeDto
    {
        public PaginationInfo Info { get; set; }
        public List<EpisodeItem> Results { get; set; }
    }

    public class PaginationInfo
    {
        public int Count { get; set; }
        public int Pages { get; set; }
        public string Next { get; set; }
        public string Prev { get; set; }
    }

    public class EpisodeItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonPropertyName("air_date")]
        public string AirDate { get; set; }

        [JsonPropertyName("episode")]
        public string EpisodeCode { get; set; }
        public List<string> Characters { get; set; }
        public string Url { get; set; }
        public string Created { get; set; }
    }
}
