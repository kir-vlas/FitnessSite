using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessCentreSite.Controllers
{
    public class SheduleController : Controller
    {
        // GET: Shedule
        public ActionResult Index()
        {
            return View("Shedule");
        }
    }
}