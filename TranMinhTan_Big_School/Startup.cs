using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranMinhTan_Big_School.Startup))]
namespace TranMinhTan_Big_School
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
