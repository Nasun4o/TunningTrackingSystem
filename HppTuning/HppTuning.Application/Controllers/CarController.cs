using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            return this.View();
        }

        [HttpPost]
        public ActionResult Add(string model)
        {
            return View();
        }

        // GET: Car
        public ActionResult Index()
        {
            return View();
        }
    }
}