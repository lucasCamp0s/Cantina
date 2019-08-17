using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cantina.Startup))]
namespace Cantina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
