using BankAccounts.Services.Infrastructure;
using BankAccounts.Services.Services;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace BankAccountsAPI.Plumbing
{
    public class ControllerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Install(new ServiceInstaller());

            container.Register(
                Component.For<ICreditReportService>()
                         .ImplementedBy<CreditReportService>()
                         .LifeStyle.Transient);

            container.Register(
                Component.For<ICustomerService>()
                         .ImplementedBy<CustomerService>()
                         .LifeStyle.Transient);

        }
    }
}