using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChartInMVC.Startup))]
namespace ChartInMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
