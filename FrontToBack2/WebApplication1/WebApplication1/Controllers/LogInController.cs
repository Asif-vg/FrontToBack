using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "LogIn";
            return View();
        }
    }
}
