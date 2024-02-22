
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
        mks.MkstalinPersonal();
        Console.WriteLine("I can access to my father "+mks.getHouse());
        Console.WriteLine("I can access to my father "+mks.getNewspaper() +" Newspaper company");
        Console.WriteLine("I can access to my father  "+mks.getpoliticalpartyname()+" Political party");
        Console.WriteLine("I can access to my father  "+mks.getProductioncompany() +  " Production Company");
        Console.WriteLine("I have obtained  "+mks.getImmovableassets() +  " as immovable asset");
        Console.WriteLine("I have obtained  "+mks.getMovableasset() +  " as movable asset");
        
        
        Console.WriteLine("*******************************************");
        Console.WriteLine("*******************************************");
        Console.WriteLine("*******************************************");
        Console.WriteLine("*******************************************");

        Mkazhagiri mka=new Mkazhagiri();
        Console.WriteLine("I too can access to my father "+mks.getHouse());
        Console.WriteLine("I too can access to my father "+mks.getNewspaper() +" Newspaper company");
        Console.WriteLine("I too can access to my father  "+mks.getpoliticalpartyname()+" Political party");
        Console.WriteLine("I too can access to my father  "+mks.getProductioncompany() +  " Production Company");

        Console.WriteLine("*******************************************");
        Console.WriteLine("*******************************************");
        Console.WriteLine("*******************************************");
        Console.WriteLine("*******************************************");

        Muthu mu=new Muthu();
        Console.WriteLine("I too can access to my father "+mu.getHouse());
        Console.WriteLine("I too can access to my father "+mu.getNewspaper() +" Newspaper company");
        Console.WriteLine("I too can access to my father  "+mu.getpoliticalpartyname()+" Political party");
        Console.WriteLine("I too can access to my father  "+mu.getProductioncompany() +  " Production Company");
        

        Console.WriteLine("*******************************************");
        Console.WriteLine("*******************************************");
        Console.WriteLine("*******************************************");
        Console.WriteLine("*******************************************");


        Udhayanithi udhay=new Udhayanithi();

        Console.WriteLine("*********************************************");
        Console.WriteLine("Below details are i inherited from my father");
        Console.WriteLine("I  can access to the Movable asset from my father is around "+udhay.getMovableasset());
        Console.WriteLine("I  can access to the Immovable asset from my father is around "+udhay.getImmovableassets());

        Console.WriteLine("*********************************************");
        
        Console.WriteLine("Below details are i inherited from my Grandfather");
        Console.WriteLine("I  can access to my Grandfather "+udhay.getHouse());
        Console.WriteLine("I  can access to my Grandfather "+udhay.getNewspaper() +" Newspaper company");
        Console.WriteLine("I  can access to my Grandfather  "+udhay.getpoliticalpartyname()+" Political party");
        Console.WriteLine("I  can access to my Grandfather  "+udhay.getProductioncompany() +  " Production Company");
        

    }
}

}

