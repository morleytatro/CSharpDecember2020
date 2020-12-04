using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Controllers
{
    // inheriting from the Controller class
    public class HelloController : Controller
    {
        // these are called Attributes
        [HttpGet("")]

        // the method name is called the Action
        public string HomeRoute()
        {
            return "Hello from the home page!";
        }

        // in Django, this would be "<str:name>/<str:stack>"

        [HttpGet("{name}/{stack}")]
        public string PostMethod(string stack, string name)
        {
            return $"Hello {name}; you are taking {stack}.";
        }

        [HttpGet("html")]
        public IActionResult SomeHtml()
        {
            ViewBag.MyName = "Morley Tatro";

            // this is how we did it in Django
            // return render(request, "GiveMeHtml.html", context)
            
            // note that ViewBag is analogous to the context dictionary
            // don't include file extension with the name
            return View("GiveMeHtml");
        }

        [HttpGet("redirect")]
        public IActionResult RedirectToOtherPage()
        {
            return RedirectToAction("SomeHtml");
        }
    }
}