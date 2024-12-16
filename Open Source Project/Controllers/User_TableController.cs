using Microsoft.AspNetCore.Mvc;
using Open_Source_Project.Repository;
using System.Security.Claims;
using Open_Source_Project.Models;
using Microsoft.AspNetCore.Authorization;


namespace Open_Source_Project.Controllers
{
    [Authorize]
    public class User_TableController : Controller
    {
        IUnitOfWork UnitOfWork;
        public User_TableController(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
        //[HttpPost]
        public IActionResult BookTable(int TableId)
        {
            User_Table user_table = new User_Table();
            ClaimsIdentity UserIdentity =(ClaimsIdentity) User.Identity;
            string ApplicationUserId = UserIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            // Table Status Is Not Available
            if(TableId != 0)
            {
                Table  TableUserWouldToBookIt = UnitOfWork.Table.GetById(TableId);
                TableUserWouldToBookIt.Status = Utility.TableNotAvailable;
                //Map User_Table 
                user_table.TableId = TableId;
                user_table.ApplicationUserId = ApplicationUserId;
                UnitOfWork.User_Table.Add(user_table);
                UnitOfWork.User_Table.Save();
                UnitOfWork.Table.Save();
                return View("BookTableView", TableUserWouldToBookIt);
            }
            ModelState.AddModelError("", "You Must Select A Table ");
            return RedirectToAction("Index", controllerName:"Home");
        }
        public async Task<IActionResult> AllBookedATableByUser(string id)
        {
            List<User_Table> User_Tables = new List<User_Table>();
            ApplicationUser LoginUser =  await UnitOfWork.User_Manager.FindByIdAsync(id);
            if (User.IsInRole("Admin"))
            {
                User_Tables = UnitOfWork.User_Table.GetAll();
            }
            else
            {
                User_Tables = UnitOfWork.User_Table.BookedTableByUser(id);
            }
            return View("AllBookedATableByUser", User_Tables);
        }



    }
}
