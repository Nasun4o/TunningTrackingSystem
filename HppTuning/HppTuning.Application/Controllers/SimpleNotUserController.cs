using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HppTuning.Models.ViewModels.SimpleUser;
using HppTuning.Services;

namespace HppTuning.Application.Controllers
{
    public class SimpleNotUserController : Controller
    {
        private readonly UserService _userService;

        public SimpleNotUserController()
        {
                this._userService = new UserService();
        }

        [HttpGet]
        public ActionResult GetUserCars()
        {
           var carModel =  this._userService.GetUserCar();

            return this.View(carModel);
        }

        [HttpGet]
        public ActionResult NewSimpleUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewSimpleUser([Bind(Exclude = "Id")] SimpleUserViewModel simpleUserViewModel)
        {
            if (ModelState.IsValid)
            {
                this._userService.AddNewUser(simpleUserViewModel);
                return RedirectToAction("Add", "Car");
            }

            return View(simpleUserViewModel);
        }





        // GET: SimpleNotUser
        public ActionResult Index()
        {
            return View();
        }
    }
}