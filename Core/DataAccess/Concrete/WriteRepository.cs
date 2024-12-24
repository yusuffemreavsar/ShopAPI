using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.Concrete
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly DbContext _dbContext;
        public WriteRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbSet<T> Table => _dbContext.Set<T>();

        public async Task<T> AddAsync(T entity)
        {
            if(entity != null)
            {
              Table.Add(entity);
              _dbContext.SaveChanges();
            }
            return entity;
        }

        public Task<T> DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
