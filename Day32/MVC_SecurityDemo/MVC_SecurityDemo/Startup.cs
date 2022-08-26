using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_SecurityDemo.Startup))]
namespace MVC_SecurityDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
