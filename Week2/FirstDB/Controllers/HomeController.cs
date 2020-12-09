using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstDB.Models;

namespace FirstDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyContext _context;
        // private readonly ILogger<HomeController> _logger;

        // dependency injection
        public HomeController(MyContext context)
        {
            // this will give us access to interacting with the DB
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
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
