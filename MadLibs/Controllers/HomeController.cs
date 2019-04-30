using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
      public ActionResult Form() { return View();}

      [Route("/game")]
      public ActionResult Game(string exlamation, string adverb, string noun, string adjective )
      {
        GameVariable newGame = new GameVariable ();
        newGame.SetExlamation(exlamation);
        newGame.SetAdverb(adverb);
        newGame.SetNoun(noun);
        newGame.SetAdjective(adjective);
         return View(newGame);
      }

  }
}
