using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HppTuning.Application.Startup))]
namespace HppTuning.Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
