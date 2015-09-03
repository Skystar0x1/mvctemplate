using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(xMvcApp.Startup))]
namespace xMvcApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
