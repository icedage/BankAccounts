using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using BankAccounts.Identity;

namespace BankAccountsAPI.Identity
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
                UserName = "SuperUser",
                Email = "IcewindDale@gmail.com",
                EmailConfirmed = true,
                FirstName = "Veronica",
                LastName = "Zotali",
                Level = 1,
                JoinDate = DateTime.Now.AddYears(-3)
            };

            manager.Create(user, "P@ssword123");

            if (roleManager.Roles.Count() == 0)
            {
                roleManager.Create(new IdentityRole { Name = "SystemUser" });
                roleManager.Create(new IdentityRole { Name = "Admin"});
            }

            var adminUser = manager.FindByName("SuperUser");

            foreach(var role in roleManager.Roles)
            {
                manager.AddToRole(adminUser.Id, role.Name);
            }
        }
    }
}