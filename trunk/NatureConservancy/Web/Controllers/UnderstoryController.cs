
using System.Web.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class UnderstoryController : ControllerBase
    {
        protected IRepository<Understory> UnderstoryRepository;
        public UnderstoryController(ISurveyRepository surveyRepository, IRepository<Understory> UnderstoryRepository)
            : base(surveyRepository)
        {
            this.UnderstoryRepository = UnderstoryRepository;
        }

        public ActionResult New(int surveyId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(int surveyId, Understory understory)
        {
            UnderstoryRepository.Save(understory);
            var survey = surveyRepository.Load(surveyId);
            survey.AddUnderstory(understory);
            UnderstoryRepository.Save(understory);
            return NewUnderstory(survey);
        }

    }
}
