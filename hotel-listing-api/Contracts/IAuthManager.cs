using hotel_listing_api.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace hotel_listing_api.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(UserDTO userDto);
        Task<AuthResponseDTO> Login(LoginDTO loginDto);
        Task<string> CreateRefreshToken();
        Task<AuthResponseDTO> VerifyRefreshToken(AuthResponseDTO request);
    }
}
