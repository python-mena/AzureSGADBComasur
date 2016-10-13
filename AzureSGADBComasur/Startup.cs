using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureSGADBComasur.Startup))]
namespace AzureSGADBComasur
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
