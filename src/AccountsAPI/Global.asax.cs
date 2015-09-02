using AccountsAPI.Infrastructure;
using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace AccountsAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            var container = new WindsorContainer();
            container.Install(FromAssembly.This());
            GlobalConfiguration.Configuration.DependencyResolver = new WindsorHttpDependencyResolver(container.Kernel);
        
        }
    }
}
