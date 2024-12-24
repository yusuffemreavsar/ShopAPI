using Business.Abstract;
using Business.Dtos.Auth.Login;
using Business.Dtos.Auth.Register;

namespace Business.Concrete
{
    
    public class AuthManager : IAuthService
    {
        public Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<RegisterResponseDto> Register(RegisterRequestDto registerRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
}
