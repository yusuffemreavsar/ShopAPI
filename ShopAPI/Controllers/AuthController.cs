using Business.Abstract;
using Business.Dtos.Auth.Register;
using Microsoft.AspNetCore.Mvc;



namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService; 
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            RegisterResponseDto response = await _authService.Register(registerRequestDto);

            return Ok(response);
        }

    }
}
