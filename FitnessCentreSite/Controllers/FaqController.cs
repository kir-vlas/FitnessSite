using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessCentreSite.Controllers
{
    public class FaqController : Controller
    {
        public ActionResult Fraq()
        {
            return View("Faq");
        }
    }
}