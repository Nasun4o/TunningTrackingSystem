using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HppTuning.Models.EntityModels
{
    public class MyUserInfo
    {
        public MyUserInfo()
        {
            this.Cars = new List<Car>();
            this.RacingHistories = new List<RacingHistories>();
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<RacingHistories> RacingHistories { get; set; }
    }
}
