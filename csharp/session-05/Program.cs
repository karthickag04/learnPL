class Kalaingar{

    public string location;
    
    public Kalaingar()
    {
        Console.WriteLine("Welcome to Kalaingar family");
    }
    public string partyname(string ppartyname){
        
        return "I have Political Party " + ppartyname ;

    }


}

class mkstalin : Kalaingar
{
     public mkstalin(string name){
        location = "gopalapuram";
        Console.WriteLine(partyname(name) + " " + location);
     }
}


class mkazhagiri : Kalaingar
{
     public mkazhagiri(string name){
         location = "Madurai";
         Console.WriteLine(partyname(name) + " " + location);
     }
}

class family{

    static void Main(string [] args){
       // Kalaingar kr=new Kalaingar();
       mkstalin stalin=new mkstalin("dmk");
       mkazhagiri azhagiri=new mkazhagiri("dmk");
        

    }
}