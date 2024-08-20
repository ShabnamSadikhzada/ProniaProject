using Microsoft.EntityFrameworkCore;

namespace LabProniaTask.MVC.Repository.Abstracts;

public interface IRepository<T> where T : class
{
    DbSet<T> Table { get; }
}
