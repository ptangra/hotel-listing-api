using System.ComponentModel.DataAnnotations;

namespace hotel_listing_api.Models.Users
{
    public class UserDTO : LoginDTO
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
