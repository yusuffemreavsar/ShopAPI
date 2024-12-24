using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context
{
    public class ShopAPIDbContext : DbContext
    {
        public ShopAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<User> Users { get; set; }
        DbSet<OperationClaim> OperationClaims { get; set; }
        DbSet<UserOperationClaim> UserOperations { get; set; }
    }
}
