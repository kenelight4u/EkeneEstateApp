using Microsoft.AspNetCore.Identity;

namespace ekeneEstateApp.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}