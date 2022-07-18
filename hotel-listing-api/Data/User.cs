using Microsoft.AspNetCore.Identity;

namespace hotel_listing_api.Data
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
