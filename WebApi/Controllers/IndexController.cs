using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class IndexController : Controller
    {
        [Route("[controller]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}