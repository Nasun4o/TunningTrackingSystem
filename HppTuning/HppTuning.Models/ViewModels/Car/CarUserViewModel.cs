using System.Collections.Generic;
using HppTuning.Models.EntityModels;

namespace HppTuning.Models.ViewModels.Car
{
    public class CarUserViewModel
    {
        public CarUserViewModel()
        {
                this.UsersList = new List<ApplicationUser>();
        }

        public int Id { get; set; }
        public double HorsePower { get; set; }
        public double NewtonMetre { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public IEnumerable<ApplicationUser> UsersList { get; set; }
        public int UserId { get; set; }
    }
}
