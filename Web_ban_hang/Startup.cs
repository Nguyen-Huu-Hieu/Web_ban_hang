using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_ban_hang.Startup))]
namespace Web_ban_hang
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
