using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Data;
using Web.Models;

namespace Web.Controllers
{
    public class GroundCoverController : ControllerBase
    {
        protected IRepository<GroundCover> GroundCoverRepository;
        public GroundCoverController(ISurveyRepository surveyRepository, IRepository<GroundCover> groundCoverRepo)
            : base(surveyRepository)
        {
            this.GroundCoverRepository = groundCoverRepo;
        }

        public ActionResult New(int surveyId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(int surveyId, GroundCover cover)
        {
            GroundCoverRepository.Save(cover);
            var survey = surveyRepository.Load(surveyId);
            survey.GroundCover = cover;
            return NewGroundCover(survey);
        }
    }
}
