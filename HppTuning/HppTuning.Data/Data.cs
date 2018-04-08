using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HppTuning.Data
{
    public class Data
    {
        private static HppDbContext _context;

        public static HppDbContext Context => _context ?? (_context = new HppDbContext());

    }
}
