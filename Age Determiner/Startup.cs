using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Age_Determiner.Startup))]
namespace Age_Determiner
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
