namespace DesignPatternsWebApi.DesignPatterns.Repository;

public interface IRepository<T>
{
    void Add(T entity);
    IEnumerable<T> GetAll();
}