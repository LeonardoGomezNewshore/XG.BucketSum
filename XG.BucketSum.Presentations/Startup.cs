using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XG.BucketSum.Presentations.Startup))]
namespace XG.BucketSum.Presentations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
