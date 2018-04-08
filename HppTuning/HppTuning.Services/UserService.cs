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
                PhoneNumber = model.PhoneNumber,
                Id = model.Id
            };
            this.Context.SimpleNotUsers.Add(user);
            this.Context.SaveChanges();
            //this.Context.SimpleNotUsers.Add(user);
        }
    }
}
