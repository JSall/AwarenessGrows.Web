using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AwarenessGrows.Web.Startup))]
namespace AwarenessGrows.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
