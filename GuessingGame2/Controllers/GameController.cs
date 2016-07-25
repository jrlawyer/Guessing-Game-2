using GuessingGame2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingGame2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            Session["Answer"] = new Random().Next(GameModel.RangeMin, GameModel.RangeMax);
            return View();
        } //reference GameModel.RangeMin and GameModel.RangeMax

        /*private bool GuessWasCorrect(int guess)
        {
            return guess == (int)Session["Answer"];
        }
        */

        private int GuessWasCorrect(int guess)
        {
            return guess.CompareTo((int)Session["Answer"]);
        }
        
        
                   
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Index(GameModel model)
        {
            ViewBag.Win = GuessWasCorrect(model.Guess);
            return View(model);

        }
    }
}












//GameController


////get
//public ActionResult Index()  //request from user, creation of "Answer".
//{
//    Session["Answer"] = new Random(1, 10);
//    return View();

//}

//private bool GuessWasCorrect(int guess) //creating true/false, tieing guess and answer together.
//{
//    return guess == (int)Session["Answer"];
//}

//[HttpPost] //storing value in viewbag for index/view, creating a "correct" state for game.
//public ActionResult Index(GameModel.model)
//{
//    ViewBag.Win = GuessWasCorrect{model.Guess}
//    return View(Model);
//}






