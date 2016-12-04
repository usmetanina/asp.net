using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(openid.Startup))]
namespace openid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
