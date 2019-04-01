using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(UI_MVC.Areas.Identity.IdentityHostingStartup))]
namespace UI_MVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}