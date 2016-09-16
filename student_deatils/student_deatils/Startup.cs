using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(student_deatils.Startup))]
namespace student_deatils
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
