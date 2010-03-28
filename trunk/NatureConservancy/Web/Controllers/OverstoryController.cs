using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class OverstoryController : ControllerBase
    {
        protected IRepository<Overstory> OverstoryRepository;
        public OverstoryController(ISurveyRepository surveyRepository, IRepository<Overstory> overstoryRepository)
            : base(surveyRepository)
        {
            this.OverstoryRepository = overstoryRepository;
        }

        public ActionResult New(int surveyId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(int surveyId, Overstory overstory)
        {
            OverstoryRepository.Save(overstory);
            var survey = surveyRepository.Load(surveyId);
            survey.Overstories.Add(overstory);
            
            return NewOverstory(survey);
        }

    }
}
