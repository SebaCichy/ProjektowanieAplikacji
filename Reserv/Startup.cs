using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Reserv.Startup))]
namespace Reserv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
