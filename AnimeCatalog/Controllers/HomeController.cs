using AnimeCatalog.Interfaces;
using AnimeCatalog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AnimeCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly IAnimeRepository _animeRepository;
		public HomeController(ILogger<HomeController> logger, IAnimeRepository animeRepository)
        {
            _logger = logger;
            _animeRepository = animeRepository;

		}

        public async Task<IActionResult> Index()
        {
            var animes = await _animeRepository.GetAll();
            return View(animes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}