
using Microsoft.AspNetCore.Mvc;


namespace mvccsharpv12.Controllers
{

    [Route("[controller]")]
    public class TraineeController : Controller
    {

       [Route("Trainee/Index")]
          public IActionResult Index()
        {
            return View("Index", "_LayoutTrainee");
        }

          public IActionResult Assignment()
        {
            return View();
        }
          public IActionResult Materials()
        {
            return View();
        }


    }
}