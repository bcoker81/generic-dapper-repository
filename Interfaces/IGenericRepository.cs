namespace genericdappertest;

public interface IGenericRepository<T>
{
    Task<bool> Add(T entity);
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(int Id);
}