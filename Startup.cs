using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(it.Startup))]
namespace it
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
