using BankAccounts.Presentation.Infrastructure;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;


namespace BankAccounts.Presentation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private static WindsorContainer _container;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            RegisterContainer();
        }

        private static void RegisterContainer()
        {
            //Add Web API controllers into CastleWindsor
            _container.Register(AllTypes.FromThisAssembly()
                                        .BasedOn<IHttpController>()
                                        .WithService.DefaultInterfaces()
                                        .Configure(c => c.LifestylePerWebRequest()));



            //Tie Castle.Windsor to WebAPI
            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),
                                                               new WindsorHttpControllerActivator(_container));

        }
    }
}
