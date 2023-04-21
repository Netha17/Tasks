using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FederatedAuthentication.Startup))]
namespace FederatedAuthentication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
