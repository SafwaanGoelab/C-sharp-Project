using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(C_sharp_Project.Startup))]
namespace C_sharp_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
