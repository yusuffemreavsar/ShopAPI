using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.DataAccess.Concrete
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly DbContext _dbContext;
        public ReadRepository(DbContext dbContext)
        {
            _dbContext=dbContext;
        }
        public DbSet<T> Table => _dbContext.Set<T>();

        public Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> FirstorDefaultAsnc(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

      

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
