using SimpleInjector;
using SimpleInjector.Integration.Web;
using SSWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SWWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //InitializeContainer();
        }

        //private void InitializeContainer()
        //{
        //    var container = new Container();

        //    container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

        //    container.Verify();
        //}
    }
}
