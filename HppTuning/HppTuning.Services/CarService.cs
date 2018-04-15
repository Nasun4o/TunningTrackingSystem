using System.Collections.Generic;
using HppTuning.Models.EntityModels;
using HppTuning.Models.ViewModels.Car;

namespace HppTuning.Services
{
    public class CarService : Service
    {

        public CarUserViewModel GetCarModelWithSimpleUsersList()
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
                SimpleNotUserId = model.UserId
                
            };
            this.Context.Cars.Add(cuvm);
            this.Context.SaveChanges();
        }
    }
}
