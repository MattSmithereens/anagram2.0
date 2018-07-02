using Microsoft.AspNetCore.Mvc;
using Anagram.Models;

namespace Anagram.Controllers
{
    public class HomeController : Controller

    {

        [Route("/Result")]
        public ActionResult Result()
        {
            return View();
        }

        [Route("/")]
        public ActionResult Input()
        {
            AnagramProgram myWordVariable = new AnagramProgram();
            myWordVariable.SetWord1(Request.Query["Word1"]);
            myWordVariable.SetWord2(Request.Query["Word2"]);
            return View("Input", myWordVariable);
        }
    }
} 
