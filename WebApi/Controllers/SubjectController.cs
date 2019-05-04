using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Contexts;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class SubjectController : Controller
    {
        private ApplicationContext db;

        public SubjectController(ApplicationContext ac)
        {
            db = ac;
        }

        [Route("[controller]")]
        public async Task<IActionResult> Index()
        {
            return View(await db.Subjects.ToListAsync());
        }


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