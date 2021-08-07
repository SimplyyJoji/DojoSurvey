using Microsoft.AspNetCore.Mvc;

namespace HelloASP
{
  public class HomeController : Controller
  {
    //Requests
    //localhost 5000/
    //short way to set up a route
    [HttpGet("")]
    public IActionResult Index()
    {
      return View();
    }
    [HttpPost]
    [Route("Results")]
    public IActionResult Results(string Name, string Location, string Language, string Comment)
    {
    // Do something with form input
      ViewBag.Name = Name;
      ViewBag.Location = Location;
      ViewBag.Language = Language;
      ViewBag.Comment = Comment;

      return View("Results", ViewBag);

    }

}

}