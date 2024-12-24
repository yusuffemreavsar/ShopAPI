using Business.Dtos.Auth.Login;
using Business.Dtos.Auth.Register;

namespace Business.Abstract
{
    public interface IAuthService
    {
        Task<LoginResponseDto> Login (LoginRequestDto loginRequestDto);
        Task<RegisterResponseDto> Register(RegisterRequestDto registerRequestDto);
    }
}
