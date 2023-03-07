using System.ComponentModel.DataAnnotations;

namespace AnimeCatalog.ViewModels
{
	public class CreateAnimeViewModel
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		[RegularExpression(@"^[0-9]*$",
		 ErrorMessage = "Characters are not allowed.")]
		public string SeasonsAndSeries { get; set; }
		[Required]
		public string Tags { get; set; }
	}
}
