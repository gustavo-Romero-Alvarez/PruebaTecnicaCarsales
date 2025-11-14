namespace PruebaTecnicaCarsalesBack.Models
{
    public class LocationResponse
    {
        public PaginationInfo Info { get; set; }
        public List<LocationItem> Results { get; set; }
    }
}
