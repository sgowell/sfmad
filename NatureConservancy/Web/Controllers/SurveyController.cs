using System.Web.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class SurveyController : ControllerBase
    {
    	
        public SurveyController(ISurveyRepository surveyRepository) : base(surveyRepository)
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Survey survey)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    surveyRepository.Save(survey);
                    return NewWoodyDebris(survey);
                }
                return View(survey);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateSpecies(Species species)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("CreateSpecies");

                }
                return View(species);
            }
            catch
            {
                return View(species);
            }
        }

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
        public ActionResult Edit(Survey editedSurvey)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    surveyRepository.SaveOrUpdate(editedSurvey);
                    return RedirectToAction("Index");
                }
                return View(editedSurvey);
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

                {
                    var surveyToDelete = surveyRepository.Load(id);
                    surveyRepository.Delete(surveyToDelete);
                    return RedirectToAction("Index");
                }
                return View(collection);
            }
            catch
            {
                return View();
            }
        }

        
        /// <summary>
        /// /Survey/$Id/Complete
        /// </summary>
        /// <param name="surveyId">Survey ID to be Updated</param>
        /// <returns>ActionResult based on Validation and Exception Handling</returns>
        [HttpPost]
        public ActionResult Complete(int surveyId)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var surveyToComplete = surveyRepository.Load(surveyId);
                    surveyToComplete.Completed = true;
                    surveyRepository.Save(surveyToComplete);
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch {
                return View(); }
        }
    }
}
