using Microsoft.AspNetCore.Mvc;


namespace ArtisanPOS.WebPortal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
