using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace faverTest00.Controllers
{
    public class GuessingController : Controller
    {
        // GET: Guessing
        public ActionResult IndexforGuessing()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IndexforGuessing(int guessN)
        {
            if (Session["randN"] == null)
            {
                Random rand = new Random();

                Session["randN"] = rand.Next(1, 101);
                Session["guessCounter"] = 0;
            }
            Session["guessCounter"] = (int)Session["guessCounter"] + 1;
            Session["Guess"] = guessN;

            int randN = (int)Session["randN"];

            if (guessN < randN)
            {
                ViewBag.Message = " The Number is Low";

            }

            else if (guessN > randN)
            {
                ViewBag.Message = " The Number is High ";


            }

            else if (guessN == randN)
            {
                ViewBag.Message = " congratulation !  ";


            }

            else
            {
                ViewBag.Message = " wrong input!  ";


            }

            ViewBag.Guesscounter = "Number" + Session["guessCounter"];

            ViewBag.rand = randN.ToString(); 
ViewBag.Message1 = "Hint : try vlaues located around " + (randN - 3 ) ;

        

            return View();
        }
        
    }
}