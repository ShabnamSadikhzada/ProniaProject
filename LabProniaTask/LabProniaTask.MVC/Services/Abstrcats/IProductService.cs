using LabProniaTask.MVC.Models;
using LabProniaTask.MVC.Repository.Abstracts;

namespace LabProniaTask.MVC.Services.Abstrcats;

public interface IProductService
{
    Product GetProductById(int id);
    void CreateProduct(Product product);
    void DeleteProduct(Product product);
    void UpdateProduct(Product product);
}
