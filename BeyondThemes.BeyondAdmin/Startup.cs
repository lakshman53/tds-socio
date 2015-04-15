using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TDS.Socio.Startup))]
namespace TDS.Socio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
