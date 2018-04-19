using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HppTuning.Data;
using HppTuning.Services.Dependancies;

namespace HppTuning.Services
{
    
    public abstract class Service 
    {
        protected Service()
        {
            this.Context = Data.Data.Context;
        }

        public HppDbContext Context { get; set; }

    }
}
