using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleRazorPdf.Startup))]
namespace SampleRazorPdf
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
