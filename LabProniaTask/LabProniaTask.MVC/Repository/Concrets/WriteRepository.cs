using LabProniaTask.MVC.Context;
using LabProniaTask.MVC.Repository.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace LabProniaTask.MVC.Repository.Concrets;

public class WriteRepository<T> : IWriteRepository<T> where T : class
{
    public DbSet<T> Table => _context.Set<T>();

    private readonly AppDbContext _context;

    //Gelecekde Constructor Dependency Injection olacaq
    public WriteRepository(AppDbContext context)
    {
        _context = context;
    }

    public void Create(T entity)
    {
        Table.Add(entity);
    }

    public void Delete(T entity)
    {
        Table.Remove(entity);
    }

    public void Update(T entity)
    {
        Table.Update(entity);
    }
}
