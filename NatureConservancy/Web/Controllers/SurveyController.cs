
using System;
using System.Web.Mvc;
using Web.Models;

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

        //
        // POST: /Survey/Create

        [HttpPost]
        public ActionResult Create(Survey survey)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("CreateWoodyDebris");
                }
                return View(survey);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AddWoodyDebris()
        {
            return View();
        }


        public ActionResult CreateSpecies(Species species)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("CreateSpecies");

                }
                else
                {
                    return View(species);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPost]
        public ActionResult AddWoodyDebris(WoodyDebris woodyDebris)
        {

            return RedirectToAction("CreateWoodyDebris");
            try
            {
                if (ModelState.IsValid)
                { return RedirectToAction("CreateWoodyDebris"); }
                return View(woodyDebris);
            }
            catch
            {

                return View();
            }

        }


        public ActionResult CreateWoodyDebris() { return View(); }
        [HttpPost]
        public ActionResult CreateWoodyDebris(FormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("CreateOverstory");
                }
                return View(collection);
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
                if (ModelState.IsValid)
                {
                    return RedirectToAction("CreateSnags");
                }
                return View(collection);
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
                if (ModelState.IsValid)
                {
                    return RedirectToAction("CreateMicrotopography");
                }
                return View(collection);
            }
            catch
            {
                return View();
            }
        }
        public ActionResult CreateMicrotopography() { return View(); }
        [HttpPost]
        public ActionResult CreateMicrotopography(Microtopography microtopography)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("CreateUnderstory");
                }
                return View(microtopography);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AddUnderstory()
        {
            return View();
        }

        public ActionResult AddUnderstory(UnderstoryItem understoryItem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("CreateUnderstory");
                }
                return View(understoryItem);
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
                if (ModelState.IsValid)
                {
                    return RedirectToAction("CreateDeerHerbivory");
                }
                return View(collection);
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
                if (ModelState.IsValid)
                { return RedirectToAction("CreateGroundCoverSpeciesAbundance"); }
                return View(collection);
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
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                return View(collection);
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
                if (ModelState.IsValid)
                { return RedirectToAction("Index"); }
                return View(collection);
            }
            catch
            {
                return View();
            }
        }
    }
}
