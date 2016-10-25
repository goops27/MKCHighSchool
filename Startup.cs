using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MKCWebApplication.Startup))]
namespace MKCWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
