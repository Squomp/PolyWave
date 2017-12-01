using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PolyWave.Startup))]
namespace PolyWave
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
