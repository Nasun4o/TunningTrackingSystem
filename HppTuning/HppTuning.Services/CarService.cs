using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HppTuning.Models.EntityModels;
using HppTuning.Models.ViewModels.Car;
using HppTuning.Models.ViewModels.Account;

namespace HppTuning.Services
{
    public class CarService : Service
    {

        public CarUserViewModel ShowUsers()
        {
            CarUserViewModel carModel = new CarUserViewModel();
            List<SimpleNotUser> users = new List<SimpleNotUser>();


            foreach (var user in this.Context.SimpleNotUsers)
            {
                users.Add(user);
            }

            carModel.UsersList = users;
            return carModel;
        }

        public void AddCar(CarUserViewModel model)
        {
            Car cuvm = new Car()
            {
                HorsePower = model.HorsePower,
                Make = model.Make,
                Model = model.Model,
                NewtonMetre = model.NewtonMetre,
                Type = model.Type,
                Id = model.Id
            };
            this.Context.Cars.Add(cuvm);
            this.Context.SaveChanges();
        }
    }
}
