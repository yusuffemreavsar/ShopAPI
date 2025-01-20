using Core.Entities.Concrete;
using System.Linq.Expressions;

namespace Core.DataAccess.Abstract
{
    public interface IReadRepository<T>:IBaseRepository<T> where T: BaseEntity
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> predicate);
        Task<T> FirstorDefaultAsnc(Expression<Func<T, bool>> predicate);

    }
}
