using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Form()
      {
        return View();
      }

      [Route("/madlib")]
      public ActionResult Madlib(string noun, string verb, string adjective, string location, string food, string skill, string malady, string state, string hobby)
      {
        MadLib ml = new MadLib();
        ml.Noun = noun;
        ml.Verb = verb;
        ml.Adjective = adjective;
        ml.Location = location;
        ml.Food = food;
        ml.Skill = skill;
        ml.Malady = malady;
        ml.State = state;
        ml.Hobby = hobby;
        return View(ml);
      }
    }
}