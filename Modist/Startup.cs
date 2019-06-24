using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Modist.Startup))]
namespace Modist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
