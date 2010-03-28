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

        public ActionResult New(int surveyId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(int surveyId, WoodyDebris woodyDebris)
        {
            woodyDebrisRepository.Save(woodyDebris);
            var survey = surveyRepository.Load(surveyId);            
            survey.WoodyDebris.Add(woodyDebris);
            return NewWoodyDebris(survey);
        }
    }
}