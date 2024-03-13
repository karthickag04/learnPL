using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mvccsharpv11.Controllers
{
    //  [Route("[controller]")]
    public class TrainerController : Controller
    {
        private readonly ILogger<TrainerController> _logger;

        public TrainerController(ILogger<TrainerController> logger)
        {
            _logger = logger;
        }

        //  [Route("Trainer/Index")]
        public IActionResult Index()
        {
            return View("Index", "_LayoutTrainer");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}