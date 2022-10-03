namespace MetricsAgent.Services;

public interface IRepository<T>
    where T : class
{    
    IList<T> GetAll();
    void Create(T item);    
    void Update(T item);
    void Delete(int id);
    
}