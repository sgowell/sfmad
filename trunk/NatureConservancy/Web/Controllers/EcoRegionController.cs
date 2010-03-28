using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class EcoRegionController : Controller
    {
        private IRepository<EcoRegion> ecoRegion;

        public EcoRegionController(IRepository<EcoRegion> ecoRegion)
        {
            this.ecoRegion = ecoRegion;
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(EcoRegion site)
        {
            ecoRegion.Save(site);
            return Json(new SuccessMessage(site, "complete"));
        }

        [HttpPost]
        public ActionResult All()
        {
            var sites = ecoRegion.FindAll().OrderBy(s => s.Name);

            return Json(sites);
        }
    }
}
