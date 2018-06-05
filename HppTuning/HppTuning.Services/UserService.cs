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

        //public void AddNewUser(SimpleUserViewModel model)
        //{
        //    MyUserInfo user = new MyUserInfo()
        //    {
        //        FullName = model.FullName,
        //        PhoneNumber = model.PhoneNumber
                 
        //    };
        //    this.Context.Users.Add(user);
        //    this.Context.SaveChanges();
        //}

        public SimpleUserWithCarsModel GetUserCar()
        {
            var data = this.Context.Cars.Include("MyUserInfo").ToArray();
            SimpleUserWithCarsModel carsWithUserViewModel = new SimpleUserWithCarsModel();
            List<SimpleCarUserViewModel> carUserView = new List<SimpleCarUserViewModel>();
            foreach (var item in data)
            {
                SimpleCarUserViewModel scuvm = new SimpleCarUserViewModel
                {
                    FullName = item.MyUserInfo.FullName,
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
