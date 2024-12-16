using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Open_Source_Project.Models;

namespace Open_Source_Project.Controllers
{
   [Authorize]
    public class HomeController : Controller
    {        

        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult Chef()
        {
            return View("Chef");
        }
        public IActionResult About()
        {
            return View("About");
        }
        public IActionResult Menu()
        {
            return View("Menu");
        }
        public IActionResult BookATable()
        {
            return View("BookATable");
        }
        public IActionResult Gallery()
        {
            return View("Gallery");
        }
        public IActionResult Events()
        {
            return View("Events");
        }
        public IActionResult Specials()
        {
            return View("Specials");
        }
    }
}
