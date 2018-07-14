using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PFinal.Startup))]
namespace PFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
