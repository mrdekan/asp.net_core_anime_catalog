using System.ComponentModel.DataAnnotations;

namespace AnimeCatalog.Models
{
    public class Anime
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Views { get; set; }
        public float Mark { get; set; }
        public string Image { get; set; }
        public string SeeasonsAndSeries { get; set; }
    }
}
