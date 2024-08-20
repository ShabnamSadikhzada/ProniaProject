using LabProniaTask.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace LabProniaTask.MVC.Context;

public class AppDbContext : DbContext
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<SliderItem> Items { get; set; }

}
