using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitnessCentreSite.Models;
using FitnessCentreSite.Service;

namespace FitnessCentreSite.Controllers
{
    public class StoreController : Controller
    {
        private IGoodService _goodService;

        public StoreController(IGoodService gd)
        {
            _goodService = gd;
        }

        [Authorize]
        public ActionResult Store()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult AddToCart(int goodid)
        {
            Cart cart = Utils.Get<Cart>(Session, SessionKey.CART);
            if (cart == null)
                cart = new Cart();
            cart.AddItem(_goodService.GetOne(goodid),1);
            Utils.Set(Session,SessionKey.CART, cart);
            return RedirectToAction("Store");
        }
    }
}