using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace faverTest00.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Fever(int? tem)

        {
            if (tem <= 32)
            {
                ViewBag.msg = "You ar not Ok ";

            }
            else if (tem >= 38)
            {
                ViewBag.msg = "You have a Fever , go seek some ICE  ";
            }

            else if (tem >= 32 || tem <= 38)
            {
                ViewBag.msg = "You ar Ok "; 
            }

        
            else
            {
                ViewBag.msg = " Enter the tem Value Pls  ";
            }
            return View();

        }
    }
}