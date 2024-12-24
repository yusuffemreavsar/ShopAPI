using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concrete
{
    public class UserReadRepository: ReadRepository<User> ,IUserReadRepository
    {
        public UserReadRepository(ShopAPIDbContext shopAPIDbContext): base(shopAPIDbContext)
        {
            
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            User? user= await Table.SingleOrDefaultAsync(u=>u.Email == email);

            return user;
        }
    }
}
