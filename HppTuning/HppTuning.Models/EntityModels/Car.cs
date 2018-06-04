using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HppTuning.Models.EntityModels
{
    public class Car
    {
        public Car()
        {
            this.Parts = new HashSet<Part>();
        }

        public int Id { get; set; }
        public double HorsePower { get; set; }
        public double NewtonMetre { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        
        public virtual ICollection<Part> Parts { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
