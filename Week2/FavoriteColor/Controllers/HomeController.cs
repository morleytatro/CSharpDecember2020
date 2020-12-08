using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace FavoriteColor.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.FavoriteColor = HttpContext.Session.GetString("FavoriteColor");

            // will look for /Views/Home/Index.cshtml
            return View();
        }

        [HttpPost("favorite-color")]
        public IActionResult SubmitFavoriteColor(string favoriteColor)
        {
            HttpContext.Session.SetString("FavoriteColor", favoriteColor);

            return RedirectToAction(nameof(this.Index));
            // return View("SubmitFavoriteColor", favoriteColor);
        }

        [HttpPost("reset-color")]
        public IActionResult ResetColor()
        {
            // HttpContext.Session.Remove("FavoriteColor");
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }
    }
}