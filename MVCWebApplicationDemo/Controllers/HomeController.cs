using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCWebApplicationDemo.Models;

namespace MVCWebApplicationDemo.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Login()
        {
            ViewData["Message"] = "Login page.";

            return View();
        }

        public IActionResult SyncPage()
        {
            ViewData["Message"] = "Synchronization page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
