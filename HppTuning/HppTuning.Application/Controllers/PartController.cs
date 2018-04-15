using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HppTuning.Models.ViewModels.Part;
using HppTuning.Services;


namespace HppTuning.Application.Controllers
{
    public class PartController : Controller
    {
        private readonly PartService _partService;

        public PartController(PartService partService)
        {
            _partService = partService;
        }

        [HttpGet]
        public ActionResult AddPart()
        {
            SimplePartViewModel simplePartViewModel = new SimplePartViewModel();
            return View(simplePartViewModel);
        }

        [HttpPost]
        public ActionResult AddPart(int id)
        {
            return View();
        }

    }
}