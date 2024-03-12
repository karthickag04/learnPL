using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvccsharp.Models;
using Microsoft.Data.SqlClient;

namespace mvccsharp.Controllers;

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
    void connectionString(){
        con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS; database=cad_pfl; integrated security = SSPI; TrustServerCertificate=True;";
    }

    [HttpPost]
    public IActionResult VerifyLogin(LoginModel lmodel){


        connectionString();
        con.Open();
        com.Connection=con;
        com.CommandText="select * from usr_log where usr_name='" +lmodel.usr_name+ "' and pw='" +lmodel.pw+ "' ;";
        dr=com.ExecuteReader();
        if(dr.Read()){
            con.Close();
            return View("Success");

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
