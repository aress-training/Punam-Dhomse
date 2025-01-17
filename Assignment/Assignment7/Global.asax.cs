﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Assignment
{
    public class MvcApplication : System.Web.HttpApplication
    {
        #region "Application_Start"
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        #endregion
    }
}
