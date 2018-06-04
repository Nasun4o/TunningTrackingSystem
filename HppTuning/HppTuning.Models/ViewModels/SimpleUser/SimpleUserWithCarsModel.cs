using System.Collections.Generic;

namespace HppTuning.Models.ViewModels.SimpleUser
{
    public class SimpleUserWithCarsModel
    {
        public IEnumerable<SimpleCarUserViewModel> SimpleCarModels { get; set; }
    }
}
