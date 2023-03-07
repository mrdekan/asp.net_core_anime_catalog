namespace AnimeCatalog.Models
{
	public class AnimesBySearch
	{
		public IEnumerable<Anime> Animes { get; set; }
		public string SearchRequest { get; set; }
	}
}
