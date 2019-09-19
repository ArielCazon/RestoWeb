using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestoWeb.Startup))]
namespace RestoWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
