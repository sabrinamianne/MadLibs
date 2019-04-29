using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

      [Route("/game")]
      public string Game() {return "Hello friend!"; }

  }
}
