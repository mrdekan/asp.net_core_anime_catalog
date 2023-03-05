using AnimeCatalog.Interfaces;
using AnimeCatalog.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimeCatalog.Controllers
{
    public class AnimeController : Controller
    {
		private readonly IAnimeRepository _animeRepository;
        public AnimeController(IAnimeRepository animeRepository)
        {
			_animeRepository = animeRepository;

		}
		public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            /*Anime anime = new Anime();
            anime.Name = "Dagashi kashi";
            anime.Description = "The Dagashi Kashi anime loosely follows the plot of the manga, where in any order tells the life of Kokonotsu Shikada living in the countryside. It all started from an argument between his father, Yō Shikada who wanted him to become the successor of the family business about candy.";
            anime.Id = id;
            anime.Views = 788;
            anime.Mark = 9.3f;
            anime.Image = "https://m.media-amazon.com/images/M/MV5BYzIwMTc0MTktODVjYS00YmMzLWJmYzItNTc1ZjBiZDkyM2EwXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg";
            anime.SeeasonsAndSeries = "12";*/
            Anime anime = await _animeRepository.GetByIdAsync(id);
			return View(anime);
        }
    }
}
