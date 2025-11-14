namespace PruebaTecnicaCarsalesBack.Models
{
    public class CharacterResponse
    {
        public PaginationInfo Info { get; set; }
        public List<CharacterItem> Results { get; set; }
    }
}
