using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeHos.Startup))]
namespace GeHos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
