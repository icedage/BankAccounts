using BankAccounts.Presentation.Presenters;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using GatewayAPI.GatewayController;

namespace BankAccounts.Presentation
{
    public class ControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IBankAccountPresenter>()
                         .ImplementedBy<BankAccountPresenter>());

            container.Register(
                Component.For<IGatewayController>()
                         .ImplementedBy<GatewayController>());
          
        }
    }
}