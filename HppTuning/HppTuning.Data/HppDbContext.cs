using Microsoft.AspNet.Identity.EntityFramework;

namespace HppTuning.Data
{
    using Models.EntityModels;
    using System.Data.Entity;

    public class HppDbContext : IdentityDbContext<ApplicationUser>
    {

        public HppDbContext()
            : base("name=DefaultConnection", throwIfV1Schema: false)

        {
        }

        public static HppDbContext Create()
        {
            return new HppDbContext();
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Part> Parts { get; set; }
        public virtual DbSet<SimpleNotUser> SimpleNotUsers { get; set; }
    }
}