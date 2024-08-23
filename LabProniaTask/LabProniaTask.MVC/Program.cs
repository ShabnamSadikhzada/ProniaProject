using LabProniaTask.MVC.Context;
using LabProniaTask.MVC.Models;
using LabProniaTask.MVC.Repository.Abstracts;
using LabProniaTask.MVC.Repository.Concrets;
using Microsoft.EntityFrameworkCore;

namespace LabProniaTask.MVC;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        string connectionString = builder.Configuration.GetConnectionString("default");
        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        builder.Services.AddScoped<IWriteRepository<Product>, WriteRepository<Product>>();
        builder.Services.AddScoped<IReadRepository<Product>, ReadRepository<Product>>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
