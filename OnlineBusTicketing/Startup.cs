using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineBusTicketing.Startup))]
namespace OnlineBusTicketing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
