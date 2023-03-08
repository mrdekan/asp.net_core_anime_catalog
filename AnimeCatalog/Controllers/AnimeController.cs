using AnimeCatalog.Interfaces;
using AnimeCatalog.Models;
using AnimeCatalog.Services;
using AnimeCatalog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AnimeCatalog.Controllers
{
    public class AnimeController : Controller
    {
		private readonly IAnimeRepository _animeRepository;
		private readonly IPhotoService _photoService;
		public AnimeController(IAnimeRepository animeRepository, IPhotoService photoService)
        {
			_animeRepository = animeRepository;
			_photoService = photoService;
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
		public ActionResult Create() {
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(CreateAnimeViewModel animeVM)
		{
			if (ModelState.IsValid)
			{
				var result = await _photoService.AddPhotoAsync(animeVM.Image);
				var anime = new Anime
				{
					Name = animeVM.Name,
					Description = animeVM.Description,
					Tags = animeVM.Tags,
					SeeasonsAndSeries = animeVM.SeasonsAndSeries.Replace("_", " "),
					Image = result.Url.ToString(),
					Mark = 0,
                    SeriesURL = "https://res.cloudinary.com/draodt7we/video/upload/v1678260940/file_example_MP4_640_3MG_wndezm.mp4",
                };
				_animeRepository.Add(anime);
				return RedirectToAction("Index");
			}
			else
			{
				ModelState.AddModelError("", "Photo upload failed");
			}
			return View(animeVM);
		}
		public async Task<IActionResult> Watched(string rate)
		{
			string[] arr = rate.Split('_');
			int Id = int.Parse(arr[0]);
			int mark = int.Parse(arr[1]);
			if (mark > 10 || mark <= 0) return RedirectToAction("Detail", new { id = Id });
			Anime anime = await _animeRepository.GetByIdAsyncNoTracking(Id);
			anime.Mark = (float)(((anime.Views) * anime.Mark + mark) / (anime.Views + 1)); 
			anime.Views++;
			_animeRepository.Update(anime);
			return RedirectToAction("Detail", new { id = Id });
		}
		public async Task<IActionResult> Series(string options)
		{
			string[] arr = options.Split("__");
			int number = 1, season = 1, Id=1;
            number = int.Parse(arr[0]);
			season = int.Parse(arr[1]);
			Id = int.Parse(arr[2]);
            Anime anime = await _animeRepository.GetByIdAsync(Id);
            Series series = new Series()
			{
				Season= season,
				Number= number,
				AnimeId = anime.Id,
				VideoURL = anime.SeriesURL,
				LastInSeason = (number == int.Parse(anime.SeeasonsAndSeries.Split(' ')[season-1]))
			};
            return View(series);
		}
	}
}
