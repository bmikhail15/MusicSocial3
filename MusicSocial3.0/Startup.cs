using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicSocial3._0.Startup))]
namespace MusicSocial3._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
