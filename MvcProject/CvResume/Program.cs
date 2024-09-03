using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CvResume
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
           
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(
                            name: "default",
                            pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
