using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Food_Spot.Startup))]
namespace Food_Spot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
