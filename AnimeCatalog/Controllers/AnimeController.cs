using Microsoft.AspNetCore.Mvc;

namespace AnimeCatalog.Controllers
{
    public class AnimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
