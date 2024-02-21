
namespace dmkfamilydisp{

class Program{
    static void Main(string[] args){
      
        // Kalaingar kr=new Kalaingar();
        // Console.WriteLine("Hi I am Dr. Muthuvel Karunanithi (Kalaingar)");
        // Console.WriteLine("I have "+kr.getHouse());
        // Console.WriteLine("I have "+kr.getNewspaper());
        // Console.WriteLine("I have "+kr.getpoliticalpartyname());
        // Console.WriteLine("I have "+kr.getProductioncompany());
        // Console.WriteLine("*******************************************");
        // Console.WriteLine("*******************************************");
        // Console.WriteLine("*******************************************");
        // Console.WriteLine("*******************************************");

        Mkstalin mks=new Mkstalin();
        Console.WriteLine("I can access to my father "+mks.getHouse());
        Console.WriteLine("I can access to my father "+mks.getNewspaper() +" Newspaper company");
        Console.WriteLine("I can access to my father  "+mks.getpoliticalpartyname()+" Political party");
        Console.WriteLine("I can access to my father  "+mks.getProductioncompany() +  " Production Company");
        
        Console.WriteLine("*******************************************");
        Console.WriteLine("*******************************************");
        Console.WriteLine("*******************************************");
        Console.WriteLine("*******************************************");

        Mkazhagiri mka=new Mkazhagiri();
        Console.WriteLine("I too can access to my father "+mks.getHouse());
        Console.WriteLine("I too can access to my father "+mks.getNewspaper() +" Newspaper company");
        Console.WriteLine("I too can access to my father  "+mks.getpoliticalpartyname()+" Political party");
        Console.WriteLine("I too can access to my father  "+mks.getProductioncompany() +  " Production Company");
        
    }
}

}

