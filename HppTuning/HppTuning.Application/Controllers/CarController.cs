using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HppTuning.Models.ViewModels.Car;
using HppTuning.Services;

namespace HppTuning.Application.Controllers
{
    public class CarController : Controller
    {
        private CarService _carService;

        public CarController()
        {
            this._carService = new CarService();
        }


        [HttpGet]
        public ActionResult Add()
        {
            CarUserViewModel model = this._carService.ShowUsers();
            return this.View(model);
        }

        [HttpPost]
        public ActionResult Add([Bind(Exclude = "Id")] CarUserViewModel model)
        {
            if (ModelState.IsValid)
            {
               this._carService.AddCar(model);
                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        // GET: Car
        public ActionResult Index()
        {
            return View();
        }
    }
}