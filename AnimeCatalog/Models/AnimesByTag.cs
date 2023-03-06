namespace AnimeCatalog.Models
{
	public class AnimesByTag
	{
		public IEnumerable<Anime> Animes { get; set; }
		public string Tag { get; set; }
	}
}
