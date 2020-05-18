using System;
using Fit4Life.Areas.Identity.Data;
using Fit4Life.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Fit4Life.Areas.Identity.IdentityHostingStartup))]

namespace Fit4Life.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<Fit4LifeDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Fit4LifeDbContextConnection")));
                services.AddDefaultIdentity<ApplicationUser>(options =>
                    {
                        options.Password.RequireLowercase = false;
                        options.Password.RequireUppercase = false;
                        options.SignIn.RequireConfirmedAccount = false;
                    })
                    .AddEntityFrameworkStores<Fit4LifeDbContext>();
            });
        }
    }
}
