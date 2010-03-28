using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class SuccessMessage
    {
        public SuccessMessage(object entity, string message)
        {
            this.Message = message;
            this.Entity = entity;
        }

        public object Entity { get; private set; }
        public string Message { get; private set; }
    }

    public class SiteController : Controller
    {
        private IRepository<Site> siteRepository;

        public SiteController(IRepository<Site> siteRepository)
        {
            this.siteRepository = siteRepository;
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(Site site)
        {
            siteRepository.Save(site);
            return Json(new SuccessMessage(site, "complete"));
        }
    }

}

