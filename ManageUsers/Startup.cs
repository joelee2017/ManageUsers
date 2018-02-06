using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManageUsers.Startup))]
namespace ManageUsers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
