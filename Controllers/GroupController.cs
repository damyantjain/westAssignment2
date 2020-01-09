using System;
using System.Collections.Generic;
using System.Linq;
using Demo.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.Contexts;
using Demo.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo.Controllers
{
    public class GroupController : Controller
    {

        private DemoDbContext context;

        public GroupController(DemoDbContext context)
        {
            this.context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            GroupIndexViewModel vm = new GroupIndexViewModel()
            {
                Groups = context.Groups.ToList()

            };

            return View(vm);
        }
        public async Task<IActionResult> Create(GroupIndexViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", vm);
            }

            vm.NewGroup.GroupID = Guid.NewGuid();
            context.Groups.Add(vm.NewGroup);
            
            await context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
       

    }
}
