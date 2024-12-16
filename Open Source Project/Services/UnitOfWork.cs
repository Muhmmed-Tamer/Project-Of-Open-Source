using Microsoft.AspNetCore.Identity;
using Open_Source_Project.Models;
using Open_Source_Project.Repository;

namespace Open_Source_Project.Services
{
    public class UnitOfWork : IUnitOfWork
    {

        public UnitOfWork(ITableRepository table , IUser_TableRepository user_Table , UserManager<ApplicationUser> UserManager ,
            SignInManager<ApplicationUser> SignInManager,RoleManager<IdentityRole> RoleManager) {
            this.Table = table;
            this.User_Table = user_Table;
            this.SignInManager = SignInManager;
            this.User_Manager = UserManager;
            this.RoleManager = RoleManager;
        }
        public ITableRepository Table { get; }

        public IUser_TableRepository User_Table { get; }

        public UserManager<ApplicationUser> User_Manager { get; set; }
        public SignInManager<ApplicationUser> SignInManager { get; set; }
        public RoleManager<IdentityRole> RoleManager { get; set; }
    }
}
