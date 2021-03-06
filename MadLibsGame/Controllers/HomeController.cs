using Microsoft.AspNetCore.Mvc;
using MadLibsGame.Models;

namespace MadLibsGame.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult MadLibsForm()
        {
            return View();
        }

        [Route("/mad_libs_results")]
        public ActionResult MadLibsResults()
        {
            MadLibs newGame = new MadLibs();
            newGame.SetOccupation(Request.Query["occupation"]);
            newGame.SetNounOne(Request.Query["nounOne"]);
            newGame.SetNounTwo(Request.Query["nounTwo"]);
            newGame.SetNounThree(Request.Query["nounThree"]);
            newGame.SetNounFour(Request.Query["nounFour"]);
            newGame.SetAdjectiveOne(Request.Query["adjectiveOne"]);
            newGame.SetAdjectiveTwo(Request.Query["adjectiveTwo"]);
            newGame.SetVerbOne(Request.Query["verbOne"]);
            newGame.SetVerbTwo(Request.Query["verbTwo"]);
            newGame.SetVerbThree(Request.Query["verbThree"]);
            return View(newGame);
        }
    }
}
