using System.Web.Mvc;
using Web.Data;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class PlotController : ControllerBase
    {
        protected IRepository<Plot> plotRepository;
        public PlotController(ISurveyRepository surveyRepository, IRepository<Plot> plotRepo)
            : base(surveyRepository)
        {
            this.plotRepository = plotRepo;
        }

        public ActionResult New(int surveyId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(int surveyId, Plot plot)
        {
            plotRepository.Save(plot);
            var survey = surveyRepository.Load(surveyId);
            var parent = survey.GroundCover;
            parent.Add(plot);
            plotRepository.Save(plot);
            var parentRepo = Container.Resolve<IRepository<GroundCover>>();
            parentRepo.Save(parent);
            return NewPlot(survey);
        }
    }
}
