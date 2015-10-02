using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMe.Startup))]
namespace TestMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
