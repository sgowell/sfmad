using System.Web.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class ControllerBase : Controller
    {
        protected ISurveyRepository surveyRepository;
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var routeData = filterContext.RouteData;
            if (routeData.Values.ContainsKey("surveyId"))
                ViewData["SurveyId"] = routeData.Values["surveyId"];
        }

        public ControllerBase(ISurveyRepository surveyRepository)
        {
            this.surveyRepository = surveyRepository;
        }

        protected ActionResult NewWoodyDebris(Survey survey)
        {
            return RedirectToAction("New", "WoodyDebris", new {surveyId = survey.Id});
        }

        protected ActionResult NewDeerHerbivory(Survey survey)
        {
            return RedirectToAction("New", "DeerHerbivory", new { surveyId = survey.Id });
        }
        protected ActionResult NewOverstory(Survey survey)
        {
            return RedirectToAction("New", "Overstory", new { surveyId = survey.Id });
        }
    }
}