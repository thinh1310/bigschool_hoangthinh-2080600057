using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hoangthinh_2080600057.Startup))]
namespace hoangthinh_2080600057
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
