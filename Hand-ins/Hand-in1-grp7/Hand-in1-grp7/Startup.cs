using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hand_in1_grp7.Startup))]
namespace Hand_in1_grp7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
