using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingAuth.Startup))]
namespace TestingAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
