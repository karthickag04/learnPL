using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvccsharpv12.Models;

namespace mvccsharpv12.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult VerifyLogin(LoginModel lmodel){

        if(lmodel.username=="Trainer"){

            return RedirectToAction("Index", "Trainer");
        }
        else if (lmodel.username=="Trainee"){

             return RedirectToAction("Index", "Trainee");
        }
        else{
             return RedirectToAction("Index", "Home");
        }

       
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CreateTrainer()
    {
        return View();
    }
    public IActionResult CreateCourse()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
