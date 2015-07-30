using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViscocityDestructorBlogSite.Startup))]
namespace ViscocityDestructorBlogSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
