using Core.Entities.Concrete;

namespace Core.DataAccess.Abstract
{
    public interface IWriteRepository<T>:IBaseRepository<T> where T :BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> DeleteByIdAsync(Guid id);

    }
}
