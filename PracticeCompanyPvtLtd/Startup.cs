using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticeCompanyPvtLtd.Startup))]
namespace PracticeCompanyPvtLtd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
