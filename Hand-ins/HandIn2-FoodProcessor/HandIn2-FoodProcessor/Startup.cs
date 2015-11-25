using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HandIn2_FoodProcessor.Startup))]
namespace HandIn2_FoodProcessor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
