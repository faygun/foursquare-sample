using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GetMarketV2.Startup))]
namespace GetMarketV2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
