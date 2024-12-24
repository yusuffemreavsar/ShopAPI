using Core.Entities.Concrete;
using DataAccess.Repositories.Abstract;

namespace Business.BusinessRules.Auth
{
    public class AuthBusinessRules
    {
        private readonly IUserReadRepository _userReadRepository;
        public AuthBusinessRules(IUserReadRepository userReadRepository)
        {
            _userReadRepository = userReadRepository;   
        }


        public async void UserExistsAsync(string email)
        {
            var user = await _userReadRepository.GetByEmailAsync(email);
            if (user == null)
            {
                throw new Exception($"User with email '{email}' not found.");
            }
           
        }

    }
}
