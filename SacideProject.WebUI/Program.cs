using SacideProject.Business.Abstract;
using SacideProject.Business.Concrete;
using SacideProject.Data.Abstract;
using SacideProject.Data.Concrete;

namespace SacideProject.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var services = builder.Services;
            services.AddScoped<IDanismanService, DanismanManager>();
            services.AddScoped<ITerapiService, TerapiManager>();
            services.AddScoped<IDanismanRepository, DanismanRepository>();
            services.AddScoped<ITerapiRepository, TerapiRepository>();


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}