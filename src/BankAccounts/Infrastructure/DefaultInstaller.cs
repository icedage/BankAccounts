﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountsAPI.Infrastructure
{
    public class DefaultInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                .Pick()
                .WithServiceDefaultInterfaces()
                .Configure(c => c.LifestyleTransient()));
        }
    }
}