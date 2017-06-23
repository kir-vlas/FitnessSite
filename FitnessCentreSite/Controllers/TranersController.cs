using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitnessCentreSite.Service;

namespace FitnessCentreSite.Controllers
{
    public class TranersController : Controller
    {

        private readonly ITranerService _tranerService;

        public TranersController(ITranerService traner)
        {
            _tranerService = traner;
        }
        
        public ActionResult Traners()
        {
            ViewBag.Traners = _tranerService.ListAll();
            return View();
        }
    }
}