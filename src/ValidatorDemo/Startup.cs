using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValidatorDemo.Startup))]
namespace ValidatorDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
