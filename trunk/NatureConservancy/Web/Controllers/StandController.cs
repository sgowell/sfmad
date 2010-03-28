using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class StandController : Controller
    {
        private IRepository<Stand> standRepository;

        public StandController(IRepository<Stand> ecoRegion)
        {
            this.standRepository = ecoRegion;
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Stand stand)
        {
            standRepository.Save(stand);
            return Json(new SuccessMessage(stand, "complete"));
        }

        [HttpPost]
        public ActionResult All()
        {
            var sites = standRepository.FindAll().OrderBy(s => s.Name);
            return Json(sites);
        }
    }
}
