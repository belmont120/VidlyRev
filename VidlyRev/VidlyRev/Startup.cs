using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyRev.Startup))]
namespace VidlyRev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
