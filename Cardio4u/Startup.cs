using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cardio4u.Startup))]
namespace Cardio4u
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
