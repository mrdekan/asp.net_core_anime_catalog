using AnimeCatalog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AnimeCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Anime anime = new Anime();
            anime.Name = "Dagashi kashi";
            anime.Description = "Lorem ipsum";
            anime.Id = 1;
            anime.Views = 788;
            anime.Mark = 9.3f;
            anime.Image = "https://m.media-amazon.com/images/M/MV5BYzIwMTc0MTktODVjYS00YmMzLWJmYzItNTc1ZjBiZDkyM2EwXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_FMjpg_UX1000_.jpg";
            List<Anime> animeList = new List<Anime>();
            for(int i = 0; i <15; i ++) animeList.Add(anime);
            return View(animeList);
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