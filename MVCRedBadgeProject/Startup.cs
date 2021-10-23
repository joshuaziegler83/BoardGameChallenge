using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRedBadgeProject.Startup))]
namespace MVCRedBadgeProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
