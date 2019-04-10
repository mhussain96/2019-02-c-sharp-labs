using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcPWx.Startup))]
namespace MvcPWx
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
