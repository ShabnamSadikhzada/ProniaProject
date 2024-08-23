using LabProniaTask.MVC.Context;
using LabProniaTask.MVC.Models;
using LabProniaTask.MVC.Repository.Abstracts;
using LabProniaTask.MVC.Services.Abstrcats;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LabProniaTask.MVC.Services.Concrets;

public class ProductService : IProductService
{
    private readonly IReadRepository<Product> _readRepository;
    private readonly IWriteRepository<Product> _writeRepository;
    private readonly AppDbContext _context;

    public ProductService(IReadRepository<Product> readRepository, IWriteRepository<Product> writeRepository, AppDbContext context)
    {
        _readRepository = readRepository;
        _writeRepository = writeRepository;
        _context = context;
    }

    public void CreateProduct(Product product)
    {
        _context.Products.Add(product);
    }

    public void DeleteProduct(Product product)
    {
        _context.Products.Remove(product);
    }


    public Product GetProductById(int id)
    {
        Product? entity = _context.Products.Find(id);
        if (entity == null)
        {

            throw new Exception($"Entity not found with this id {id}");
        }

        return entity;
    }

    public void UpdateProduct(Product product)
    {
        _context.Products.Update(product);
    }
}
