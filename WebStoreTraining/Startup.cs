using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebStoreTraining.Startup))]
namespace WebStoreTraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
