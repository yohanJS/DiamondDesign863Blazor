using Microsoft.AspNetCore.Identity;
using PocBlazorApp.Models;

namespace PocBlazorApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ICollection<UserPrimaryInfo>? userPrimaryInfo { get; set; }
    }

}
