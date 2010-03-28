using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Data;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class UnderstoryItemController : ControllerBase
    {
        protected IRepository<UnderstoryItem> UnderstoryItemRepository;
        public UnderstoryItemController(ISurveyRepository surveyRepository, IRepository<UnderstoryItem> uItemRepo)
            : base(surveyRepository)
        {
            this.UnderstoryItemRepository = uItemRepo;
        }

        public ActionResult New(int surveyId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(int surveyId, UnderstoryItem uItem)
        {
            UnderstoryItemRepository.Save(uItem);
            var survey = surveyRepository.Load(surveyId);
            var parent = survey.Understories.Single(u => u.Id == uItem.Understory.Id);
            var parentRepo = Container.Resolve<IRepository<Understory>>();
            parent.Add(uItem);
            UnderstoryItemRepository.Save(uItem);
            parentRepo.Save(parent);
            return NewOverstoryItem(survey);
        }
    }
}
