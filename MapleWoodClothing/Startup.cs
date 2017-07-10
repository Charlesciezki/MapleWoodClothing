using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapleWoodClothing.Startup))]
namespace MapleWoodClothing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
