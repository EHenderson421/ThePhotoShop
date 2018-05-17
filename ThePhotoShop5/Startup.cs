using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThePhotoShop5.Startup))]
namespace ThePhotoShop5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
