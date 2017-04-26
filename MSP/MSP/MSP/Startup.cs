using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSP.Startup))]
namespace MSP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
