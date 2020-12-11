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

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.AllStudents = _context.Students
                // note that the most recently added student will be on top
                .OrderByDescending(student => student.CreatedAt)
                .ToList();

            return View();
        }

        [HttpGet("students/new")]
        public IActionResult NewStudentPage()
        {
            return View();
        }

        [HttpPost("students")]
        public IActionResult CreateStudent(Student studentToCreate)
        {
            if(!ModelState.IsValid)
            {
                return View("NewStudentPage");
            }

            _context.Add(studentToCreate);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet("students/{id}/edit")]
        public IActionResult EditStudentPage(int id)
        {
            var studentToEdit = _context
                .Students
                .Find(id);

            return View(studentToEdit);
        }

        [HttpPost("students/{id}/update")]
        public IActionResult UpdateStudent(Student updatedStudent, int id)
        {
            if(!ModelState.IsValid)
            {
                // reconnecting the ID since the student object didn't have one
                // this could be changed by using a hidden input
                updatedStudent.StudentId = id;
                return View("EditStudentPage", updatedStudent);
            }

            var studentToUpdate = _context
                .Students
                .Find(id);
            
            studentToUpdate.FirstName = updatedStudent.FirstName;
            studentToUpdate.LastName = updatedStudent.LastName;
            studentToUpdate.Email = updatedStudent.Email;
            studentToUpdate.FavoriteNumber = updatedStudent.FavoriteNumber;
            studentToUpdate.UpdatedAt = DateTime.Now;

            // just like in Django!
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // coming from the asp-route-id in the view
        [HttpPost("students/{id}/delete")]
        public IActionResult DeleteStudent(int id)
        {
            var studentToDelete = _context
                .Students
                .Find(id);

            _context.Students.Remove(studentToDelete);
            _context.SaveChanges();

            return RedirectToAction("Index");
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
