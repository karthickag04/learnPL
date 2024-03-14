using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using mvccsharpv12.Models;

namespace mvccsharpv12.Controllers;

public class HomeController : Controller
{
    SqlConnection con=new SqlConnection();
    SqlCommand com=new SqlCommand();
    SqlDataReader? dr;
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

    void connectionStr(){
        con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS ; database=tmys; User ID=CADBATCH01; Password=CAD@123pass; TrustServerCertificate=True; ";

    }

    [HttpPost]
    public IActionResult VerifyLogin(LoginModel lmodel){


        connectionStr();
        con.Open();
       
        com.Connection=con;
        com.CommandText="select * from tbl_login where username='" + lmodel.username + "' and password='" + lmodel.password + "' ;";
        dr=com.ExecuteReader();
        if(dr.Read()){
        
            if(lmodel.username=="trainer"){
     
                return RedirectToAction("Index", "Trainer");
            }
            else if (lmodel.username=="trainee"){

                return RedirectToAction("Index", "Trainee");
            }
            else{
                return RedirectToAction("Index", "Home");
            }


        }
        else{
            con.Close();
            return View("Error");
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
