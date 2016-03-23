using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(muster.Startup))]
namespace muster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
