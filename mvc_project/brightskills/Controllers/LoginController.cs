using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using brightskills.Models;
using Microsoft.Data.SqlClient;

namespace brightskills.Controllers;

public class LoginController : Controller
{
    SqlConnection con=new SqlConnection();
    SqlCommand cmd=new SqlCommand();
    SqlDataReader? dr;
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Aboutus()
    {
        return View();
    }

    public IActionResult Contactus()
    {
        return View();
    }

     public IActionResult Login()
    {
        return View();
    }

    [HttpGet]
     public IActionResult Register()
    {
        return View();
    }


    void conStr(){
         con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS; database=tmys; User ID=CADBATCH01; Password=CAD@123pass; TrustServerCertificate=True; ";
    }
    
    [HttpPost]
     public IActionResult RegisterDB(RegisterModel rmodel)
    {   

        // conStr();
        // cmd.Connection=con;
        // cmd.CommandText="INSERT INTO tbl_reg_users (full_name, user_name, email_id, contact_number, password)VALUES (@Fullname, @Username, @emailid, @contactnumber, @password);";
        // cmd.Parameters.


        // if(true){
        //     return RedirectToAction("Login");
        // }
        // else{

        //     return RedirectToAction("Error");
        // }
        return View();
        
    }


     public IActionResult Services()
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
