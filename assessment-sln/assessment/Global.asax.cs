﻿using assessment.DataAccess;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Unity;

namespace assessment
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var container = this.AddUnity();
            container.RegisterType<ICarrierRepo, CarrierRepoInMem>();
        }
    }
}