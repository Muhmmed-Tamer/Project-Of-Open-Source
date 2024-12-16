using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Open_Source_Project.Models;
using Open_Source_Project.Repository;
using Open_Source_Project.ViewModels;

namespace Open_Source_Project.Controllers
{
    public class AccountController : Controller
    {
        IUnitOfWork UnitOfWork;
        public AccountController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
       public IActionResult Register()
        {
            return View("Register");
        }
        [HttpPost]
        public async Task<IActionResult> SaveRegister(ApplicationRegisterUser User)
        {
            ApplicationUser Application_User = new ApplicationUser();
            if (ModelState.IsValid) 
            {
                Application_User.FirstName = User.FirstName;
                Application_User.LastName = User.LastName;
                Application_User.Email = User.Email;
                Application_User.UserName = User.FirstName.Trim() + User.LastName.Trim();
                Application_User.PasswordHash = User.Password;
                Application_User.PhoneNumber = User.PhoneNumber;

                IdentityResult RoleResult = await UnitOfWork.RoleManager.CreateAsync(new IdentityRole("RegularUser"));
                IdentityResult Result = await UnitOfWork.User_Manager.CreateAsync(Application_User , User.Password);
                if (Result.Succeeded&& RoleResult.Succeeded) 
                {
                     await UnitOfWork.SignInManager.SignInAsync(Application_User,true);
                    return RedirectToAction("Index" , controllerName: "Home");
                }
                ModelState.AddModelError("", "The Email Is Used To Register Before Change This Email Or Go To Login ");

            }
            return View("Register" , User);
        }
        public IActionResult Login()
        {
            return View("Login");
        }
        public async Task<IActionResult> SaveLogin(ApplicationLoginUser User)
        {
            if (ModelState.IsValid && User.LoginAs != "Not Role") 
            {
                ApplicationUser ApplicationUserFromDataBase  = await UnitOfWork.User_Manager.FindByEmailAsync(User.Email);
                if (ApplicationUserFromDataBase != null) {
                    bool VaildPassword = await  UnitOfWork.User_Manager.CheckPasswordAsync(ApplicationUserFromDataBase , User.Password);
                    IList<string> RoleOfLoginUser =await  UnitOfWork.User_Manager.GetRolesAsync(ApplicationUserFromDataBase);
                    
                    if (VaildPassword&& RoleOfLoginUser.Contains(User.LoginAs)) {
                        await UnitOfWork.SignInManager.SignInAsync(ApplicationUserFromDataBase, User.RememberMe);
                        return RedirectToAction("Index", controllerName:"Home");
                    }
                }
                ModelState.AddModelError("", "The Email Or Password Or Role Is Incorrect");
                return View("Login", User);
            }
            ModelState.AddModelError("LoginAs", "Please Select Your Role");
            return View("Login", User);
        }
        public IActionResult Logout()
        {
            UnitOfWork.SignInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        public IActionResult AccessDenied()
        {
            return View("AccessDenied");
        }
        [Authorize]
        public async Task<IActionResult> Profile(string id)
        {
            ApplicationUser AppUser = await UnitOfWork.User_Manager.FindByIdAsync(id);
            return View("Profile" , AppUser);
        }
    }
}
