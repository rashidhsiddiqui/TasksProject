using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TasksProjectMVC5App.Startup))]
namespace TasksProjectMVC5App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
