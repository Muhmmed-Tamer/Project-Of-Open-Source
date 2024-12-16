using Microsoft.AspNetCore.Identity;

namespace Open_Source_Project.Models
{
    public class ApplicationUser  :IdentityUser
    {
        public string? FirstName {  get; set; }
        public string? LastName { get; set; }
        public ICollection<User_Table>? User_Tables { get; set; }
    }
}
