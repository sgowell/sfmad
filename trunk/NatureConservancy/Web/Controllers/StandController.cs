using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class StandController : Controller
    {
        public ActionResult New()
        {
            return View(new Stand());
        }

        [HttpPost]
        public ActionResult New(Stand stand)
        {
            return View();
        }

    }
}
