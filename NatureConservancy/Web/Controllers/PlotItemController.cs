﻿using System.Linq;
using System.Web.Mvc;
using Web.Data;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class PlotItemController : ControllerBase
    {
        protected IRepository<PlotItem> PlotItemRepository;
        public PlotItemController(ISurveyRepository surveyRepository, IRepository<PlotItem> plotItemRepo) : base(surveyRepository)
        {
            this.PlotItemRepository = plotItemRepo;
        }

        public ActionResult New(int surveyId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(int surveyId, PlotItem plotItem)
        {
            PlotItemRepository.Save(plotItem);
            var survey = surveyRepository.Load(surveyId);
            Plot parent = survey.GroundCover.Plots.Single(p => p.Id == plotItem.Plot.Id);
            parent.Add(plotItem);
            PlotItemRepository.Save(plotItem);
            var parentRepo = Container.Resolve<IRepository<Plot>>();
            parentRepo.Save(parent);

            return NewPlotItem(survey);
        }
    }
}
