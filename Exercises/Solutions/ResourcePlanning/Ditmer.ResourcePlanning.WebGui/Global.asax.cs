using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.Windsor.Installer;
using Ditmer.ResourcePlanning.WebGui.Infrastructure.Windsor;

namespace Ditmer.ResourcePlanning.WebGui
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private readonly WindsorBootstrapper _bootstrapper = new WindsorBootstrapper();

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            _bootstrapper.Setup(FromAssembly.This());
            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(_bootstrapper.Container.Kernel));     
        }
    }
}
