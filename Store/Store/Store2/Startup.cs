using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Store2.Startup))]
namespace Store2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
