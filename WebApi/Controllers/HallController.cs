using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Contexts;
using WebApi.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi
{
    public class HallController : Controller
    {
        private ApplicationContext db;
        // GET: /<controller>/

        public HallController(ApplicationContext ac)
        {
            db = ac;
        }

        [Route("[controller]")]
        public async Task<IActionResult> Index()
        {
            return View(await db.Hall.ToListAsync());
        }
        /*public IActionResult Create()
        {
            return View("Create");
        }*/
        [Route("[controller]/create")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("[controller]/create")]
        [HttpPost]
        public async Task<IActionResult> Create(Hall hall)
        {
            db.Hall.Add(hall);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }

}
