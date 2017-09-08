using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServerControlDemo.Startup))]
namespace ServerControlDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
