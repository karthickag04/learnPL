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
    public class TraineeController : Controller
    {
        private readonly ILogger<TraineeController> _logger;

        public TraineeController(ILogger<TraineeController> logger)
        {
            _logger = logger;
        }

        //  [Route("Trainee/Index")]
       
        public IActionResult Index()
        {
            return View("Index", "_LayoutTrainee");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}