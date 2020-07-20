using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PhofuLocks.Areas.Identity.Data;
using PhofuLocks.Data;

[assembly: HostingStartup(typeof(PhofuLocks.Areas.Identity.IdentityHostingStartup))]
namespace PhofuLocks.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PhofuDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PhofuDBContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<PhofuDBContext>();
            });
        }
    }
}