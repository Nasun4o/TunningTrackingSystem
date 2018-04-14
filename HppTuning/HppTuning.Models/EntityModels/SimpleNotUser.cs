using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HppTuning.Models.EntityModels
{
    public class SimpleNotUser
    {
        public SimpleNotUser()
        {
            this.Cars = new List<Car>();
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
