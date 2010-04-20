using System.Collections.Generic;
using System.Web.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class WoodyDebrisController : ControllerBase
    {
        protected IRepository<WoodyDebris> woodyDebrisRepository;
        public WoodyDebrisController(ISurveyRepository surveyRepository, IRepository<WoodyDebris> woodyRepo) : base(surveyRepository)
        {
            this.woodyDebrisRepository = woodyRepo;
        }

        public ViewResult New(int surveyId)
        {
            var survey = surveyRepository.Load(surveyId);
            IList<WoodyDebris> debrises = new List<WoodyDebris>();
            if (survey != null)
                debrises  = survey.WoodyDebris;
            return View(debrises);
        }

        [HttpPost]
        public ActionResult New(int surveyId, WoodyDebris woodyDebris)
        {
            woodyDebrisRepository.Save(woodyDebris);
            var survey = surveyRepository.Load(surveyId);            
            survey.WoodyDebris.Add(woodyDebris);
            return NewWoodyDebris(survey);
        }

        public ActionResult CreateOverstory(int surveyId)
        {
            var survey = surveyRepository.Load(surveyId);
            return NewOverstory(survey);
        }
    }
}