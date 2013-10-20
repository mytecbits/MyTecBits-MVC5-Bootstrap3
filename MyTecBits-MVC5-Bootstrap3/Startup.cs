using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyTecBits_MVC5_Bootstrap3.Startup))]
namespace MyTecBits_MVC5_Bootstrap3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
