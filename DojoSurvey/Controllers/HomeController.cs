using Microsoft.AspNetCore.Mvc;

namespace HelloASP
{
  public class HomeController : Controller
  {
    //Requests
    //localhost 5000/
    //short way to set up a route
    [HttpGet("")]
    public ViewResult Index()
    {
      return View();
    }

    
  //Projects
    [Route("projects")]
    [HttpGet]
    public ViewResult Project()
    {
      return View();
    }

    //localhost 5000/users/
    [HttpGet("view")]
    public ViewResult Contact()
  {
    return View();
  }

  }
}