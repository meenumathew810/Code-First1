using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCodeFirstSample.Startup))]
namespace MvcCodeFirstSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
