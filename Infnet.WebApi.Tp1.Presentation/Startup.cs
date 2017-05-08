using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Infnet.WebApi.Tp1.Presentation.Startup))]
namespace Infnet.WebApi.Tp1.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
