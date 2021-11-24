using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            ViewBag.Name = "Home";
            return View();
        }

        
    }
}
