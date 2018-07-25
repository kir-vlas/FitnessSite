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
        private ITranerService _tranerService;

        public AdminController(IAbonOrderService ba, ITranerService ta)
        {
            _abonOrderService = ba;
            _tranerService = ta;
        }


        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            IList<AbonOrder> list = _abonOrderService.ListAll();
            return View(list);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult CreateTraner()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTraner(TranerViewModel model)
        {
            if (ModelState.IsValid)
            {
                Traner traner = new Traner() {Name = model.Name, Description = model.Description};
                _tranerService.Save(traner);
            }
            return RedirectToAction("Admin");
        }

        public ActionResult Traners()
        {
            IList<Traner> list = _tranerService.ListAll();
            return View(list);
        }

        public ActionResult DeleteTraner(int id)
        {
            Traner tr = _tranerService.GetTraner(id);
            _tranerService.Delete(tr);
            return RedirectToAction("Traners");
        }

        public ActionResult DeleteAbOrder(int id)
        {
            AbonOrder ord = _abonOrderService.GetOne(id);
            _abonOrderService.Delete(ord);
            return RedirectToAction("Admin");
        }
    }
}