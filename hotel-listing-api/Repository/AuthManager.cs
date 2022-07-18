using AutoMapper;
using hotel_listing_api.Contracts;
using hotel_listing_api.Data;
using hotel_listing_api.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace hotel_listing_api.Repository
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public AuthManager(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        async Task<IEnumerable<IdentityError>> IAuthManager.Register(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);

            user.UserName = userDto.Email;

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }

            return result.Errors;
        }
    }
}
