// string a="Welcome to C# through variable";
// Console.WriteLine(a);

class Program{

  static void Main(string [] args){
    Console.WriteLine("Welcome To Classes");
    test tt=new test();
    tt.PrintMSG();
    tt.PrintMSG2();

  }
}


public class test{
  string name="CAD BATCH 01";

  public void PrintMSG(){
    Console.WriteLine(name);
  }

  public void PrintMSG2(){
    Console.WriteLine("hi ..! " + name);
  }

}







































// class Programming{
//         static void Main(string [] args){
//             Console.WriteLine("welcome to namespace demo12");
//             test tt=new test();
//             tt.print1();
//         }


//     }

// public class test{
//   string x="karthick";
//   public void print1(){
//     Console.WriteLine(x);
//   }

// }