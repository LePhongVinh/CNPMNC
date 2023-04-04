using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LVCMOBILE.Startup))]
namespace LVCMOBILE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
