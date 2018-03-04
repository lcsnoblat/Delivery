using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LumaDelivery.Startup))]
namespace LumaDelivery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
