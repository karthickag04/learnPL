using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace brightskills.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

         [Route("Admin/Dashboard")]
        public IActionResult Dashboard()
        {
            return View("Dashboard", "_LayoutAdmin");
        }
        
        [Route("Admin/ManageCourses")]
        public IActionResult ManageCourses()
        {
            return View("ManageCourses", "_LayoutAdmin");
        }
        public IActionResult ManageSessions()
        {
            return View("ManageSessions", "_LayoutAdmin");
        }

        [Route("Admin/ManageUsers")]
         public IActionResult ManageUsers()
        {
            return View("ManageUsers", "_LayoutAdmin");
        }
        public IActionResult Reports()
        {
            return View("Reports", "_LayoutAdmin");
        }
        public IActionResult Settings()
        {
            return View("Settings", "_LayoutAdmin");
        }
       


       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}