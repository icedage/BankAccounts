using AccountsAPI.Presentation.Presenters;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GatewayAPI.GatewayController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankAccounts.Presentation
{
    public class ControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                                  .BasedOn<IController>()
                                  .LifestyleTransient());

          container.Register(
           Component.For<IBankAccountPresenter>()
                    .ImplementedBy<BankAccountPresenter>()
                    .LifeStyle.Transient);

          container.Register(
            Component.For<IGatewayController>()
            .ImplementedBy<GatewayController>()
            .LifeStyle.Transient);
        }
    }
}