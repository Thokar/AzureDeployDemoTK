using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureDeployDemoTK.Startup))]
namespace AzureDeployDemoTK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
