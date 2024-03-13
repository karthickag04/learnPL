using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvccsharpv11.Models;
using Microsoft.Data.SqlClient;

namespace mvccsharpv11.Controllers;

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

    public IActionResult Login()
    {
        return View();
    }

    void connectionString(){
        con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS ; database=tmys; User ID=CADBATCH01; Password=CAD@123pass; TrustServerCertificate=True; ";
    }

    [HttpPost]
    public IActionResult VerifyLogin(LoginModel lmodel){

        connectionString();
        con.Open();
        com.Connection=con;
        com.CommandText="select * from tbl_login where username='" + lmodel.username + "' and password='" + lmodel.password + "' ;";
        dr=com.ExecuteReader();
        if(dr.Read()){
            con.Close();

            if(lmodel.username=="Trainer"){
                 return RedirectToAction("Index", "Trainer");
            }
            else if(lmodel.username=="Trainee"){
                 return RedirectToAction("Index", "Trainee");
            }
            else{
                return RedirectToAction("Index", "Home");

            }

        }
        else
        {
         con.Close();
         return View("Error");
        
        }
    }

    public IActionResult Index()
    {
        return View();
    }

   

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
