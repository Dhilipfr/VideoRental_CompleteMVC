using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewRental_CompleteMVC.Startup))]
namespace ViewRental_CompleteMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
