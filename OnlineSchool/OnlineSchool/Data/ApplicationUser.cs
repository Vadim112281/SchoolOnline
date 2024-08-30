using Microsoft.AspNetCore.Identity;
using OnlineSchool.Enum;

namespace OnlineSchool.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string MediumName { get; set; }
        public string LastName { get; set; }
        public OwnRoles Role { get; set; } = OwnRoles.Student;
        
    }

}
