

using Microsoft.AspNetCore.Mvc;

namespace brightskills.Controllers
{
   [Route("[controller]")]
    public class TraineeController : Controller{


    [Route("Trainee/Dashboard")]
      public IActionResult Dashboard(){
        return View();
      }
      public IActionResult EnrollinCourse(){
        return View();
      }
      public IActionResult MyCourses(){
        return View();
      }
      public IActionResult ViewSessionSchedule(){
        return View();
      }
      public IActionResult Grades(){
        return View();
      }
      public IActionResult Resources(){
        return View();
      }
     

    }

}