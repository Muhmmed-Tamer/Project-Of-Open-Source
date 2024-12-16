using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Open_Source_Project.Data;
using Open_Source_Project.ExtensionMethods;
using Open_Source_Project.Models;
using System.Reflection.Metadata;

namespace Open_Source_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ContextData>(Options => { Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); });
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
                Options =>
                {
                    Options.Password.RequiredLength = 4;
                    Options.Password.RequireNonAlphanumeric = false;
                    Options.Password.RequireUppercase = false;
                    Options.Password.RequireLowercase = false;
                    Options.User.RequireUniqueEmail = true;
                }
                ).AddEntityFrameworkStores<ContextData>();

            builder.Services.AddInterfacesAndClasses();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
