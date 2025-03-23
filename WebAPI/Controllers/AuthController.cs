using Microsoft.AspNetCore.Mvc;
using WebAPI.DTOs.Auth;
using WebAPI.Services.Abstraction;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<RegisterResponseDTO>> RegisterAsync([FromBody] RegisterRequestDTO registerRequest)
        {
            var response = await _authService.RegisterAsync(registerRequest);
            if (response == null) { return BadRequest(); }
            return Ok(response);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<LoginResponseDTO>> LoginAsync([FromBody] LoginRequestDTO loginRequest)
        {
            var response = await _authService.LoginAsync(loginRequest);
            if (response == null) { return Unauthorized(); }
            return Ok(response);
        }
    }
}
