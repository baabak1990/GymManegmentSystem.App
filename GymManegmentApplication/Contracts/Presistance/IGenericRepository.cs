namespace GymManegmentApplication.Contracts.Presistance;

public interface IGenericRepository<T> where T : class
{
    Task<T> Get(int id);
    Task<IReadOnlyCollection<T>> GetAll();
    Task<T> Add(T entity);
    Task<T> Delete(int id);
    Task<T> Update(T entity);
}