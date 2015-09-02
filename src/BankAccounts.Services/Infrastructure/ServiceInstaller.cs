using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using AccountsAPI.Services.Services;
using AccountsAPI.Repository.Infrastructure;
using AccountsAPI.Repository;
using AccountsAPI.Repository.Repositories;
using AccountsAPI.Repository.Entities;

namespace AccountsAPI.Services.Infrastructure
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

            container.Register(
              Component.For<ICreditReportService>()
                       .ImplementedBy<CreditReportService>()
                       .LifeStyle.Transient);

             //container.Register(
             // Component.For<IRepository<Account>>()
             //          .ImplementedBy<AccountsRepository>()
             //          .LifeStyle.Transient);
        
        }


    }
}
