using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitnessCentreSite.Models;
using FitnessCentreSite.Service;

namespace FitnessCentreSite.Controllers
{
    public class AdminController : Controller
    {
        private IAbonOrderService _abonOrderService;

        public AdminController(IAbonOrderService ba)
        {
            _abonOrderService = ba;
        }


        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            IList<AbonOrder> list = _abonOrderService.ListAll();
            return View(list);
        }
    }
}