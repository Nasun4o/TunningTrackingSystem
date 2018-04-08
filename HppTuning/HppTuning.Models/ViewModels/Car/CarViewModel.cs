using System.Collections.Generic;
using HppTuning.Models.EntityModels;

namespace HppTuning.Models.ViewModels.Car
{
    public class CarViewModel
    {
        public CarViewModel()
        {
                this.Users = new List<SimpleNotUser>();
        }

        public int Id { get; set; }
        public double HorsePower { get; set; }
        public double NewtonMetre { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public IEnumerable<SimpleNotUser> Users { get; set; }
        public int UserId { get; set; }
    }
}
