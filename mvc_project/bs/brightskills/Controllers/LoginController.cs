using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using brightskills.Models;
using Microsoft.Data.SqlClient;
using brightskills.Data;

namespace brightskills.Controllers;

public class LoginController : Controller
{
    SqlConnection con=new SqlConnection();
    SqlCommand cmd=new SqlCommand();
    SqlDataReader? dr;

        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

    // private readonly ILogger<LoginController> _logger;

    // public LoginController(ILogger<LoginController> logger)
    // {
    //     _logger = logger;
    // }

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


     public IActionResult VerifyLogin(LoginModel lmodel)
    {
        conStr();
        con.Open();
        cmd.Connection=con;
        cmd.CommandText="select * from tbl_login where username=@uname and password=@pass";
        cmd.Parameters.AddWithValue("@uname", lmodel.username);
        cmd.Parameters.AddWithValue("@pass", lmodel.password);

        dr=cmd.ExecuteReader();

        if(dr.Read()){


            // con.Close();

            string? jobrolecheck=dr["jobrole"].ToString();
            con.Close();
         


            if(jobrolecheck=="trainer")
            {
                
            return RedirectToAction("Dashboard","Trainer");
            }
            else if(jobrolecheck=="admin"){
                
                return RedirectToAction("Dashboard","Admin");
            }
                        
            else{
         
                    con.Close();
                    return View("Error");
    
             }

        }
        
        else{
              
                dr.Close();
                cmd.CommandText="select * from tbl_reg_users where user_name=@u_name and password=@_pass";
                cmd.Parameters.AddWithValue("@u_name", lmodel.username);
                cmd.Parameters.AddWithValue("@_pass", lmodel.password);
                dr=cmd.ExecuteReader();
                if(dr.Read()){
                    con.Close();
                    return RedirectToAction("Dashboard","Trainee");
                }
                else{
                    con.Close();
                    return View("Error");
                 }
        }   
       
    }

    [HttpGet]
     public IActionResult Register()
    {
        return View();
    }


    void conStr(){
         con.ConnectionString="data source=192.168.1.240\\SQLEXPRESS; database=tmys; User ID=CADBATCH01; Password=CAD@123pass; TrustServerCertificate=True; ";
    }
    
    // [HttpPost]
    //  public IActionResult RegisterDB(RegisterModel rmodel)
    // {   // // Method 01
    //     // conStr();
    //     // con.Open();
    //     // cmd.Connection=con;
    //     // cmd.CommandText="insert into tbl_reg_users(full_name,user_name ,email_id,contact_number,password) values ('"+rmodel.FullName+"','"+rmodel.UserName+"','"+rmodel.Email+"','"+rmodel.ContactNumber+"','"+rmodel.Password+"') ";

    //     // int rowAffected=cmd.ExecuteNonQuery();
    //     // if(rowAffected>0){
    //     //     return RedirectToAction("Login");
    //     // }
    //     // else{
    //     //     return View("Error");
    //     // }


    //     //Method 02
    //     conStr();
    //     con.Open();
    //     cmd.Connection=con;
    //     cmd.CommandText="insert into tbl_reg_users(full_name,user_name ,email_id,contact_number,password) values (@fullname,@username,@email,@contactnumber,@password) ";
    //     cmd.Parameters.AddWithValue("@fullname",rmodel.FullName);
    //     cmd.Parameters.AddWithValue("@username",rmodel.UserName);
    //     cmd.Parameters.AddWithValue("@email",rmodel.Email);
    //     cmd.Parameters.AddWithValue("@contactnumber",rmodel.ContactNumber);
    //     cmd.Parameters.AddWithValue("@password",rmodel.Password);

    //     int rowAffected=cmd.ExecuteNonQuery();
    //     if(rowAffected>0){
    //         con.Close();
    //         return RedirectToAction("Login");
    //     }
    //     else{
    //         con.Close();
    //         return View("Error");
    //     }
        
    // }




        [HttpPost]
        public IActionResult RegisterDB(RegisterModel rmodel)
        {
            if (ModelState.IsValid)
            {
                // Create a new entity using the provided RegisterModel
                var newUser = new RegisterModel
                {
                    FullName = rmodel.FullName,
                    UserName = rmodel.UserName,
                    Email = rmodel.Email,
                    ContactNumber = rmodel.ContactNumber,
                    Password = rmodel.Password
                };

                // Add the new entity to the RegUsers DbSet
                _context.RegUsers.Add(newUser);

                // Save changes to the database
                _context.SaveChanges();

                // Redirect to the login page upon successful registration
                return RedirectToAction("Login");
            }
            else
            {
                // If model state is not valid, return to the registration page
                return View(rmodel);
            }
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
