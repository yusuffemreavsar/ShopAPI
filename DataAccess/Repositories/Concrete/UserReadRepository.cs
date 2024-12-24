using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Context;
using DataAccess.Repositories.Abstract;

namespace DataAccess.Repositories.Concrete
{
    public class UserReadRepository: ReadRepository<User> ,IUserReadRepository
    {
        public UserReadRepository(ShopAPIDbContext shopAPIDbContext): base(shopAPIDbContext)
        {
            
        }
    }
}
