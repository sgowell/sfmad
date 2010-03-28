using System.Web.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class DeerHerbivoryController : ControllerBase
    {
        protected IRepository<DeerHerbivory> DeerHerbivoryRepository;
        public DeerHerbivoryController(ISurveyRepository surveyRepository, IRepository<DeerHerbivory> deerHerbivoryRepository) : base(surveyRepository)
        {
            this.DeerHerbivoryRepository = deerHerbivoryRepository;
        }

        public ActionResult New(int surveyId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(int surveyId, DeerHerbivory deerHerbivory)
        {
            DeerHerbivoryRepository.Save(deerHerbivory);
            var survey = surveyRepository.Load(surveyId);
            survey.DeerHerbivory.Add(deerHerbivory);
            return NewDeerHerbivory(survey);
        }
    }
}
