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
    public IActionResult Results(string Name, string Location, string Language, string Comments)
    {
    // Do something with form input
      ViewBag.Name = Name;
      ViewBag.Location = Location;
      ViewBag.Language = Language;
      ViewBag.Comments = Comments;

      return View("Results", ViewBag);

    }

}

}