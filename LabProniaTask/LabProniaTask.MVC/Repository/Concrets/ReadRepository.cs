using LabProniaTask.MVC.Context;
using LabProniaTask.MVC.Repository.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace LabProniaTask.MVC.Repository.Concrets;

public class ReadRepository<T> : IReadRepository<T> where T : class
{
    private readonly AppDbContext _context;

    public ReadRepository(AppDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();


    public T GetById(int id)
    {
        T? entity = Table.Find(id);
        if (entity == null)
        {

            throw new Exception($"Entity not found with this id {id}");
        }

        return entity;
    }
}
