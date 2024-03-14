using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mvccsharpv12.Controllers
{
    [Route("[controller]")]
    public class TrainerController : Controller
    {
        private readonly ILogger<TrainerController> _logger;

        public TrainerController(ILogger<TrainerController> logger)
        {
            _logger = logger;
        }

        [Route("Trainer/Index")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentDetails()
        {
            return View();
        }
        public IActionResult ViewAssignment()
        {
            return View();
        }
        public IActionResult CreateAssignment()
        {
            return View();
        }
        public IActionResult PostMaterials()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}