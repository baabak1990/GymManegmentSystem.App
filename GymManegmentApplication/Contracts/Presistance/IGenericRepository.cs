namespace GymManegmentApplication.Contracts.Presistance;

public interface IGenericRepository<T> where T : class
{
    Task<T> Get(int id);
    Task<IReadOnlyList<T>> GetAll();
    Task<T> Add(T entity);
    Task Delete(T entity);
    Task Update(T entity);
    Task<bool> IsExisted(int  id);
}