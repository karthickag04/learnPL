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
    public class TrainerController : Controller
    {
        private readonly ILogger<TrainerController> _logger;

        public TrainerController(ILogger<TrainerController> logger)
        {
            _logger = logger;
        }

         [Route("Trainer/Dashboard")]
        public IActionResult Dashboard()
        {
            return View("Dashboard", "_LayoutTrainer");
        }
        public IActionResult MyCourses()
        {
            return View("MyCourses", "_LayoutTrainer");
        }
        public IActionResult ScheduleSessions()
        {
            return View("ScheduleSessions", "_LayoutTrainer");
        }
        public IActionResult ManageTrainees()
        {
            return View("ManageTrainees", "_LayoutTrainer");
        }
        public IActionResult Grades()
        {
            return View("Grades", "_LayoutTrainer");
        }
        public IActionResult Resources()
        {
            return View("Resources", "_LayoutTrainer");
        }
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}