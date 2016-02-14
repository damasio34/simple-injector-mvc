using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(simple_injector_mvc.Startup))]
namespace simple_injector_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
