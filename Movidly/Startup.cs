using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movidly.Startup))]
namespace Movidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
