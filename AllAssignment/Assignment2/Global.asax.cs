﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Assignment2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        #region "Application_start"
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        #endregion
    }
}
