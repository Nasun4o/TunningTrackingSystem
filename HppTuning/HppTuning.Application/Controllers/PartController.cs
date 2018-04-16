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

        public PartController()
        {
            this._partService = new PartService();
        }

        [HttpGet]
        public ActionResult ShowAllParts (int id)
        {
            AllPartsViewModel allPartsViewModel = _partService.ShowAllPartsForCarById(id);
            return View(allPartsViewModel);
        }


        [HttpGet]
        public ActionResult AddPart(int id)
        {
            SimplePartViewModel simplePartViewModel = _partService.SetPartFormGetModel(id);
            return View(simplePartViewModel);
        }

        [HttpPost]
        public ActionResult AddPart([Bind(Include = "Id,Name,Manufacturer,Price,PartBuyedFrom,DateOfPurchase,ExpectedDateOfDelivery,IsPartInstalled,CarId")]SimplePartViewModel simplePartViewModel)
        {
            if (ModelState.IsValid)
            {
                _partService.AddNewPart(simplePartViewModel);
                return RedirectToAction("AddPart","Part");
            }
            return View(simplePartViewModel);
        }

    }
}