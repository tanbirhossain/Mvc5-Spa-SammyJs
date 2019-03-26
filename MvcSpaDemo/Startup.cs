using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcSpaDemo.Startup))]
namespace MvcSpaDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}


//https://www.c-sharpcorner.com/article/single-page-application-using-asp-net-mvc-and-jquery/