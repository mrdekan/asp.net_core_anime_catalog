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
        public async Task<IActionResult> Detail(int id)
        {
            Anime anime = await _animeRepository.GetByIdAsync(id);
			return View(anime);
        }
		public async Task<IActionResult> Tag(string tag)
		{
			var animes = await _animeRepository.GetAnimeByTags(tag);
			AnimesByTag animesByTag = new AnimesByTag();
			animesByTag.Animes = animes;
			animesByTag.Tags = tag;
			return View(animesByTag);
		}
		[HttpPost]
		public async Task<IActionResult> Search(string name)
		{
			if (name==null)
				return RedirectToAction("Index", "Home");
			var animes = await _animeRepository.GetAnimeByName(name);
			AnimesBySearch animesByName = new AnimesBySearch();
			animesByName.Animes = animes;
			animesByName.SearchRequest = name;
			return View(animesByName);
		}
	}
}
