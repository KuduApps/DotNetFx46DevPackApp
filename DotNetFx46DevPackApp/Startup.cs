using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetFx46DevPackApp.Startup))]
namespace DotNetFx46DevPackApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
