using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SKPortfolio.Startup))]
namespace SKPortfolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
