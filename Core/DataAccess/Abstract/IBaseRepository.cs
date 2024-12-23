using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.Abstract
{
    public interface IBaseRepository<T> where T : class
    {
        DbSet<T> Table { get; }
    }
}
