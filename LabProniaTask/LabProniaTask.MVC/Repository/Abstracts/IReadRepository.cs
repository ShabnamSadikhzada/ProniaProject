namespace LabProniaTask.MVC.Repository.Abstracts;

public interface IReadRepository<T> : IRepository<T> where T : class
{
    T GetById(int id);
}
