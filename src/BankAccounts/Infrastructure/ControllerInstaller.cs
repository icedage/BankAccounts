using AccountsAPI.Services.Infrastructure;
using AccountsAPI.Services.Services;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountsAPI.Infrastructure
{
    public class ControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
            .Pick().If(t => t.Name.EndsWith("Controller"))
            .Configure(configurer => configurer.Named(configurer.Implementation.Name))
            .LifestylePerWebRequest());

            container.Install(new ServiceInstaller());


            //container.Register(
            //   Component.For<ICreditReportService>()
            //            .ImplementedBy<CreditReportService>()
            //            .LifeStyle.Transient);

            container.Register(
               Component.For<ICustomerService>()
                        .ImplementedBy<CustomerService>()
                        .LifeStyle.Transient);
        }
    }
}