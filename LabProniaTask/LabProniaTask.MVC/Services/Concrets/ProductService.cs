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
        _writeRepository.Create(product);
    }

    public void DeleteProduct(Product product)
    {
        _writeRepository.Delete(product);
    }


    public Product GetProductById(int id)
    {
        return _readRepository.GetById(id);
    }

    public void UpdateProduct(Product product)
    {
        _writeRepository.Update(product);
    }
}
