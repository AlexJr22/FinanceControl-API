using System.Linq.Expressions;

namespace FinanceControl.Domain.Interfaces;

public interface IRequests<T>
{
    Task<T> GetAsync(Expression<Func<T, bool>> predicate);
    Task<IEnumerable<T>> GetAllAsync();
    Task<bool> PostAsync(T item);
    Task<bool> PutAsync(T item);
    Task<bool> DeleteAsync(Guid id);
}
