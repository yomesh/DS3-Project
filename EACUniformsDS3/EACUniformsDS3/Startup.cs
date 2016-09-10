using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EACUniformsDS3.Startup))]
namespace EACUniformsDS3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
