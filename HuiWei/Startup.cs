using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HuiWei.Startup))]
namespace HuiWei
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
