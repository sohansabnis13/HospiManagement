using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospiManagement.Startup))]
namespace HospiManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
