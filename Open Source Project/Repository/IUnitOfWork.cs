using Microsoft.AspNetCore.Identity;
using Open_Source_Project.Models;

namespace Open_Source_Project.Repository
{
    public interface IUnitOfWork
    {
        public ITableRepository Table { get; }
        public IUser_TableRepository User_Table { get; }
        //Application User
        public UserManager<ApplicationUser> User_Manager { get; set; }
        public SignInManager<ApplicationUser> SignInManager { get; set; } 
        public RoleManager<IdentityRole> RoleManager { get; set; }
    }
}
