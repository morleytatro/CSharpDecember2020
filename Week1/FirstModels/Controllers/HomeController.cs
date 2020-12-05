using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstModels.Models;

namespace FirstModels.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var tacoBell = new Business(){
                Name = "Taco Bell",
                NumEmployees = 15,
                City = "Seattle",
                State = "WA"
            };

            return View(tacoBell);
        }

        [HttpGet("restaurants/new")]
        public IActionResult NewRestaurantPage()
        {
            return View();
        }

        [HttpPost("restaurants")]
        public IActionResult CreateRestaurant(Business newBusiness)
        {
            // Note that we are rendering the form page to show errors
            if(!ModelState.IsValid)
            {
                return View("NewRestaurantPage");
            }

            return View(newBusiness);
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
