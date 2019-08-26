using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(slider1.Startup))]
namespace slider1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
