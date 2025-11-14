namespace PruebaTecnicaCarsalesBack.Models
{
    public class EpisodeResponse
    {
        public PaginationInfo Info { get; set; }
        public List<EpisodeItem> Results { get; set; }
    }
}

