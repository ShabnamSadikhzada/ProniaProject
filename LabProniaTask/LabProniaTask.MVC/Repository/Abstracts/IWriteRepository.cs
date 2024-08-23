namespace LabProniaTask.MVC.Repository.Abstracts;

public interface IWriteRepository<T> : IRepository<T> where T : class
{
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}
