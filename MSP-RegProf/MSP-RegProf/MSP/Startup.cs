using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSP_RegProf.Startup))]
namespace MSP_RegProf
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
