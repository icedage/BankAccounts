using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using AccountsAPI.Repository.Entities;
using AccountsAPI.Repository.Repositories;
using AccountsAPI.Services.AccountBenefits.Classic;
using AccountsAPI.Services.AccountBenefits;
using AccountsAPI.Services.AccountBenefits.Gold;

namespace AccountsAPI.Repository.Infrastructure
{
    public class RepositoryInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register( Component.For<IRepository<Account>>()
                .ImplementedBy<AccountsRepository>()
                         .LifeStyle.Transient);

            container.Register(Component.For<IRepository<Customer>>()
                .ImplementedBy<CustomerRepository>()
                        .LifeStyle.Transient);

            //container.Register(Component.For<IRepository<Customer>>()
            //    .ImplementedBy<CustomerRepository>()
            //            .LifeStyle.Transient);

            container.Register(Component.For<IRepository<ClassicAccountBenefits>>()
                .ImplementedBy<ClassicAccountBenefitsRepository>()
                        .LifeStyle.Transient);

            container.Register(Component.For<IRepository<SilverAccountBenefits>>()
               .ImplementedBy<SilverAccountBenefitsRepository>()
                       .LifeStyle.Transient);

            container.Register(Component.For<IRepository<GoldAccountBenefits>>()
              .ImplementedBy<GoldAccountBenefitsRepository>()
                      .LifeStyle.Transient);
        }
    }
}
