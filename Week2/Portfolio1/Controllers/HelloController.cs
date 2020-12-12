// need to import Controller class to use it
// from django.contrib import url
using Microsoft.AspNetCore.Mvc;

// we're going to inherit from another class
public class HelloController : Controller
{
    // specify the route
    [HttpGet("")] // this will correspond to http://localhost:5000
    public string Homepage()
    {
        return "This is my Index!";
    }

    [HttpGet("projects")] // this will be http://localhost:5000/projects
    public string Projects()
    {
        return "These are my projects.";
    }

    [HttpGet("contact")]
    public ViewResult Contact()
    {
        // context = {
        //      "name": "Morley"
        // }
        // return render(request, "Contact.html", context)
        // returning the result of invoking the View function
        // analogous to what we did in Django

        // ViewBag allows us to pass data to the HTML
        ViewBag.Name = "Jason";
        ViewBag.LastName = "Irvin";

        return View();
    }
}