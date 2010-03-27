﻿
using System.Web.Mvc;

namespace Web.Controllers
{
    public class SurveyController : Controller
    {
        //
        // GET: /Survey/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Survey/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Survey/Create

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult CreateWoodyDebris() { return View(); }
        [HttpPost]
        public ActionResult CreateWoodyDebris(FormCollection collection)
        {
            try
            {
                return RedirectToAction("CreateOverstory");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CreateOverstory() { return View(); }
        [HttpPost]
        public ActionResult CreateOverstory(FormCollection collection)
        {
            try
            {
                return RedirectToAction("CreateSnags");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CreateSnags() { return View(); }
        [HttpPost]
        public ActionResult CreateSnags(FormCollection collection)
        {
            try
            {
                return RedirectToAction("CreateMicrotopography");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CreateMicrotopography() { return View(); }
        [HttpPost]
        public ActionResult CreateMicrotopography(FormCollection collection)
        {
            try
            {
                return RedirectToAction("CreateUnderstory");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CreateUnderstory() { return View(); }
        [HttpPost]
        public ActionResult CreateUnderstory(FormCollection collection)
        {
            try
            {
                return RedirectToAction("CreateDeerHerbivory");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CreateDeerHerbivory() { return View(); }
        [HttpPost]
        public ActionResult CreateDeerHerbivory(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //
        // POST: /Survey/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("CreateWoodyDebris");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Survey/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Survey/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Survey/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Survey/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
