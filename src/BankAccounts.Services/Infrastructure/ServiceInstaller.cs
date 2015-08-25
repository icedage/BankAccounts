using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using BankAccounts.Services.Services;
using BankAccounts.Repository.Infrastructure;

namespace BankAccounts.Services.Infrastructure
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        { 
            container.Install(new RepositoryInstaller());

            container.Register(
              Component.For<IAccountDetailsService>()
                       .ImplementedBy<AccountDetailsService>()
                       .LifeStyle.Transient);

            container.Register(
              Component.For<IAccountService>()
                       .ImplementedBy<AccountService>()
                       .LifeStyle.Transient);
        }
    }
}
