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
        private readonly UserService service;
        public SimpleNotUserController()
        {
                this.service = new UserService();
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
                this.service.AddNewUser(simpleUserViewModel);
                return RedirectToAction("Index", "Home");
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