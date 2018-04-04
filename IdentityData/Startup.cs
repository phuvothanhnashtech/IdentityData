using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityData.Startup))]
namespace IdentityData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
