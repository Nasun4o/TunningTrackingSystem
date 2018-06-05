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
            CarUserViewModel model = this._carService.GetCarModelWithSimpleUsersList();
            return this.View(model);
        }

        [HttpPost]
        public ActionResult Add([Bind(Include = "Id, HorsePower, NewtonMetre, Make, Model, Type, UserInfo")] CarUserViewModel carUserModel)
        {
            if (ModelState.IsValid)
            {
               this._carService.AddCar(carUserModel);
                return RedirectToAction("Index", "Home");
            }
            return View(carUserModel);
        }

        // GET: Car
        public ActionResult Index()
        {
            return View();
        }
    }
}