using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NIIT.BookSotre.Web.Startup))]
namespace NIIT.BookSotre.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
