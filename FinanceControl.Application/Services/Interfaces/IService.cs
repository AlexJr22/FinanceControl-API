using System.Linq.Expressions;

namespace FinanceControl.Application.Services.Interfaces;

public interface IService<T>
{
    // get
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetAsync(Expression<Func<T, bool>> predicate);

    // post
    Task<T> PostAsync(T entity);

    // put 
    Task<T> PutAsync(T entity);

    // Delete
    Task<T> DeleteAsync(T entity);
}
