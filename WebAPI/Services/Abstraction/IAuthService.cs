using WebAPI.DTOs.Auth;

namespace WebAPI.Services.Abstraction
{
    public interface IAuthService
    {
        Task<LoginResponseDTO> LoginAsync(LoginRequestDTO loginRequest);
        Task<RegisterResponseDTO> RegisterAsync(RegisterRequestDTO registerRequest);
    }
}
