using System.Web.Mvc;
using Web.Data;
using Web.Models;

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
            survey.GroundCover.Plots.Add(plot);
            return NewPlot(survey);
        }
    }
}
