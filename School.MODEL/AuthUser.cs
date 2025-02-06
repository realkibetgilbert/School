using Microsoft.AspNetCore.Identity;

namespace School.MODEL
{
    public class AuthUser : IdentityUser<long>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsActive { get; set; }
    }
}
