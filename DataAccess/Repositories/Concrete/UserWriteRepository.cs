using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Context;
using DataAccess.Repositories.Abstract;

namespace DataAccess.Repositories.Concrete
{
    public class UserWriteRepository:WriteRepository<User>,IUserWriteRepository
    {
        public UserWriteRepository(ShopAPIDbContext shopAPIDbContext) : base(shopAPIDbContext)
        {

        }
    }
}
