using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sistema_gestao.Startup))]
namespace Sistema_gestao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
