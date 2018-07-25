using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitnessCentreSite.Models;
using FitnessCentreSite.Service;

namespace FitnessCentreSite.Controllers
{
    public class HomeController : Controller
    {
        IAbonOrderService ordersServ;
        public HomeController(IAbonOrderService ord)
        {
            ordersServ = ord;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Send(AbonOrder abonOrder)
        {
            ordersServ.Save(abonOrder);
            return View("Index");
        }
    }
}