using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankAccounts.Presentation.Startup))]
namespace BankAccounts.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
