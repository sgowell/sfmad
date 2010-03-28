using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class OverstoryItemController : ControllerBase
    {
        protected IRepository<OverstoryItem> OverstoryItemRepository;
        public OverstoryItemController(ISurveyRepository surveyRepository, IRepository<OverstoryItem> oItemRepo)
            : base(surveyRepository)
        {
            this.OverstoryItemRepository = oItemRepo;
        }

        public ActionResult New(int surveyId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(int surveyId, OverstoryItem oItem)
        {
            OverstoryItemRepository.Save(oItem);
            var survey = surveyRepository.Load(surveyId);
            var parent = survey.Overstories.Single(o => o.Id == oItem.Overstory.Id);
            parent.OverstoryItems.Add(oItem);
            
            return NewOverstoryItem(survey);
        }

    }
}
