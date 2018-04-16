using AutoMapper;
using HppTuning.Models.EntityModels;
using HppTuning.Models.ViewModels.Part;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace HppTuning.Application
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            this.RegisterMaps();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void RegisterMaps()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<SimplePartViewModel, Part>();
                expression.CreateMap<Part, SimplePartViewModel>();
            });
        }
    }
}
