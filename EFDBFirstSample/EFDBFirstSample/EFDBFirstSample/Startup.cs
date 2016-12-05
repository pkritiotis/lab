using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFDBFirstSample.Startup))]
namespace EFDBFirstSample
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
