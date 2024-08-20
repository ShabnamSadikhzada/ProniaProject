namespace LabProniaTask.MVC.Repository.Abstracts;

public interface IReadRepository<T> : IRepository<T> where T : class
{
    IQueryable<T> GetAll(bool isTracking = false, params string[] includes);
}
