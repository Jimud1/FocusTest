using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(FirstCentral.Focus.Startup))]

namespace FirstCentral.Focus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
