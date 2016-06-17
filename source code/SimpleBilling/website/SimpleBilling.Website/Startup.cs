using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleBilling.Website.Startup))]
namespace SimpleBilling.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
