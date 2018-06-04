using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HppTuning.Models.EntityModels;
using HppTuning.Models.ViewModels.Race;
using HppTuning.Services;

namespace HppTuning.Application.Controllers
{
    public class RaceController : Controller
    {
        private RaceService raceService;

        public RaceController()
        {
              this.raceService = new RaceService();
        }

        // GET: RaceHistory
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult NewRace()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewRace([Bind(Include = "FrontTiresPressure, RearTiresPressure, FrontCoiloverClicks, RearCoiloverClicks, Notes, TimeOfHistoryCreated")] RacingViewModel raceModel)
        {
            if (ModelState.IsValid)
            {
                this.raceService.AddNewRaceHistory(raceModel);
                return RedirectToAction("NewRace", "Race");
            }
          
            return View(raceModel);
        }

        [HttpGet]
        public ActionResult RaceHistory()
        {
            //Application user should replace SimpleUser
            ApplicationUser user = new ApplicationUser();
            return View();
        }
    }
}