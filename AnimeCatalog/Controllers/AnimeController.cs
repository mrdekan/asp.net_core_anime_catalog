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
            Anime anime = await _animeRepository.GetByIdAsync(id);
			return View(anime);
        }
		[HttpGet]
		public async Task<IActionResult> Tag(string tag)
		{
			var animes = await _animeRepository.GetAnimeByTags(tag);
			AnimesByTag animesByTag = new AnimesByTag();
			animesByTag.Animes = animes;
			animesByTag.Tags = tag;
			return View(animesByTag);
		}
	}
}
