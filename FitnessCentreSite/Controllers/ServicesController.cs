﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessCentreSite.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Service
        public ActionResult Services()
        {
            return View();
        }

        public ActionResult ServicesUnit()
        {
            return View();
        }
    }
}