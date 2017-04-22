using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicSocial3.Startup))]
namespace MusicSocial3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            //app.UseIdentityManager(new IdentityManagerConfiguration()
            //{
            //    UserManagerFactory = Thinktecture.IdentityManager.MembershipReboot.UserManagerFactory.Create
            //});

            ConfigureAuth(app);
        }

        
    }
}
