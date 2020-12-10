using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomensLeagues = _context.Leagues
                .Where(league => league.Name.Contains("Women"))
                .ToList();

            ViewBag.HockeyLeagues = _context.Leagues
                .Where(league => league.Sport.Contains("Hockey"))
                .ToList();

            ViewBag.DallasTeams = _context.Teams
                .Where(team => team.Location == "Dallas")
                .ToList();

            ViewBag.SortedByLocation = _context.Teams
                // passing in a "selector"
                .OrderBy(team => team.Location)
                .ToList();

            // descending sorting
            ViewBag.ReverseTeamName = _context.Teams
                .OrderByDescending(team => team.TeamName)
                .ToList();

            ViewBag.CooperNotJoshua = _context.Players
                .Where(player => player.LastName == "Cooper" && player.FirstName != "Joshua")
                .ToList();

            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}