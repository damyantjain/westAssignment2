using System;
using System.Collections.Generic;
using System.Linq;
using Demo.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.Contexts;
using Demo.ViewModels;
using Npgsql;

//namespace Demo.Controllers
//{
//    public class LoginController : Controller
//    {

//       // public NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;Database=demo;User Id = postgres; Password=sewa;");



//        private DemoDbContext context;

//        public LoginController(DemoDbContext context)
//        {
//            this.context = context;
//        }

//        public IActionResult Login()
//        {
//            return View();

//        }
//        public IActionResult Verify(Login acc)
//        {
//            acc.LoginID = Guid.NewGuid();
//            context.Login.Find("1");


//           return View("Error");
//        }
//    }
//}
namespace Demo.Controllers
{
    public class LoginController : Controller
    {

        private DemoDbContext context;

        public LoginController(DemoDbContext context)
        {
            this.context = context;
        }
        // GET: /<controller>/
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Verify(Login acc)
        {
            if (!ModelState.IsValid)
            {
                return View("Login", acc);
            }
           
           // var check=context.Login.Find(1);
            //if(check.Equals("admin"))
            //{
            //    return View("Create");

            //}
            await context.SaveChangesAsync();

            return RedirectToAction("");
        }


    }
}
