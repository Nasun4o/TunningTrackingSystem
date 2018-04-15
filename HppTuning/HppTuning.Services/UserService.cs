using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HppTuning.Models.EntityModels;
using HppTuning.Models.ViewModels.SimpleUser;

namespace HppTuning.Services
{
    public class UserService : Service
    {

        public void AddNewUser(SimpleUserViewModel model)
        {
            SimpleNotUser user = new SimpleNotUser()
            {
                FullName = model.FullName,
                PhoneNumber = model.PhoneNumber
                 
            };
            this.Context.SimpleNotUsers.Add(user);
            this.Context.SaveChanges();
        }

        public SimpleUserWithCarsModel GetUserCar()
        {
            var data = this.Context.Cars.Include("SimpleNotUser").ToArray();
            SimpleUserWithCarsModel carsWithUserViewModel = new SimpleUserWithCarsModel();
            List<SimpleCarUserViewModel> carUserView = new List<SimpleCarUserViewModel>();
            foreach (var item in data)
            {
                SimpleCarUserViewModel scuvm = new SimpleCarUserViewModel
                {
                    FullName = item.SimpleNotUser.FullName,
                    HorsePower = item.HorsePower,
                    Make = item.Make,
                    Model = item.Model,
                    NewtonMetre = item.NewtonMetre,
                    Type = item.Type,
                    Id = item.Id
                };


                carUserView.Add(scuvm);
            }
            carsWithUserViewModel.SimpleCarModels = carUserView;
            
            return carsWithUserViewModel;
        }
    }
}
