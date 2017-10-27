using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSP_Certificados.Startup))]
namespace MSP_Certificados
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
