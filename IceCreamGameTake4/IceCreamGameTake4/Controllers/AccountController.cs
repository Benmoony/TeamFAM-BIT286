using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IceCreamGameTake4.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IceCreamGameTake4.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult InstructorLogin()
        {
            return View();
        }

        [HttpGet]
        public ActionResult InstructorCreateAccount()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InstructorCreateAccount(InstructorRegisterModel irm)
        {
            return View("InstructorLogin");
        }
    }
}
