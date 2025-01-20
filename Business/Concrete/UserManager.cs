using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Repositories.Abstract;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;

        public UserManager(IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository)
        {
            _userWriteRepository = userWriteRepository;
            _userReadRepository = userReadRepository;
        }

        public async Task<User?> GetByEmail(string email)
        {
            User? user = await _userReadRepository.GetByEmailAsync(email);
            return user;
        }

        public Task<User> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
