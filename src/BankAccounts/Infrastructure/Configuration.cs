using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using BankAccounts.Identity.Infrastructure;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BankAccountsAPI.Infrastructure
{
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "SuperPowerUser",
                Email = "taiseer.joudeh@gmail.com",
                EmailConfirmed = true,
                FirstName = "Taiseer",
                LastName = "Joudeh",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-3)
            };

            manager.Create(user, "MySuperP@ss!");

            if (roleManager.Roles.Count() == 0)
            {
                roleManager.Create(new IdentityRole { Name = "SuperAdmin" });
                roleManager.Create(new IdentityRole { Name = "Admin"});
                roleManager.Create(new IdentityRole { Name = "User"});
            }

            var adminUser = manager.FindByName("SuperPowerUser");

            foreach(var role in roleManager.Roles)
            {
                manager.AddToRole(adminUser.Id, role.Name);
            }
        }
    }
}