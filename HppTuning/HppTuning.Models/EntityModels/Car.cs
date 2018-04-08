using System.Collections.Generic;

namespace HppTuning.Models.EntityModels
{
    public class Car
    {
        public int Id { get; set; }
        public double HorsePower { get; set; }
        public double NewtonMetre { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        //public SimpleNotUser Owner { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}
