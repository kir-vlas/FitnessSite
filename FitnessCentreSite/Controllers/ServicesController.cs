using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessCentreSite.Controllers
{
    public class ServicesController : Controller
    {

        // GET: Services
        public ActionResult Index()
        {
            return View("Gym");
        }

        public ActionResult Body()
        {
            return View("Body");
        }

        public ActionResult Cardio()
        {
            return View("Cardio");
        }

        public ActionResult Karate()
        {
            return View("Karate");
        }

        public ActionResult Taybok()
        {
            return View("Taybok");

        }
    }
}