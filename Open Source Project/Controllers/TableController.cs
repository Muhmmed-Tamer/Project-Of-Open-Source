using Microsoft.AspNetCore.Mvc;
using Open_Source_Project.Repository;
using Open_Source_Project.Models;
using Microsoft.AspNetCore.Authorization;

namespace Open_Source_Project.Controllers
{
    [Authorize(Roles ="Admin")]
    public class TableController : Controller
    {
        IUnitOfWork UnitOfWork;
        public TableController(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }
       public IActionResult Add()
        {
            return PartialView("Add");
        }
        [HttpPost]
        public IActionResult SaveAdd(Table table)
        {
            if (ModelState.IsValid) {
                UnitOfWork.Table.Add(table);
                UnitOfWork.Table.Save();
                return RedirectToAction("AllTables");
            }
            return PartialView("Add" , table);
        }
        public IActionResult AllTables()
        {
           List<Table> Tables =  UnitOfWork.Table.GetAll();
            return PartialView("AllTables", Tables);
        }
        public IActionResult Delete(int id) {
            UnitOfWork.Table.Delete(id);
            UnitOfWork.Table.Save();
            return RedirectToAction("AllTables");
        }
        public IActionResult Edit(int id)
        {
            Table Edittable = UnitOfWork.Table.GetById(id);
            return PartialView("Edit" , Edittable);
        }
        public IActionResult SaveEdit(int id,Table table)
        {
            if (!ModelState.IsValid) 
            {
                Table TableEdited = UnitOfWork.Table.GetById(id);
                TableEdited.TableName = table.TableName;
                TableEdited.Capacity = table.Capacity;
                TableEdited.Id = id;
                UnitOfWork.Table.Update(TableEdited);
                UnitOfWork.Table.Save();
                return RedirectToAction("AllTables");
            }
            return PartialView("Edit", table);
        }
    }
}
