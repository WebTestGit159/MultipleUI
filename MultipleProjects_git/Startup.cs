using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultipleProjects_git.Startup))]
namespace MultipleProjects_git
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
