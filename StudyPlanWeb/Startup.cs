using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudyPlanWeb.Startup))]
namespace StudyPlanWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
