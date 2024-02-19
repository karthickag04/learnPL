class Program{

static void Main(string [] args){

Console.WriteLine("added value is : " + add(5,6));
Console.WriteLine("added value is : " + add(5,6,7));
Console.WriteLine("added value is : " + add(5.4,6.1));
Console.WriteLine("Concatenated value is : " + add("Bright","Services"));
demo1();
 constructordemo cd=new constructordemo();
 constructordemo cd1=new constructordemo(10,20);
 cd.demo();


}

static int add(int a, int b){
    return a+b;
}



static int add(int a, int b,int c){
    
    return a+b+c;
}


static double add(double a, double b){
    return a+b;
}


static string add(string a, string b){
    return a+b;
}

 static void demo1(){
        Console.WriteLine("normal Method in main class");

    }




}



class constructordemo{

    public void demo(){
        Console.WriteLine("normal Method in another class");

    }
    public constructordemo(){
        Console.WriteLine("Welcome to Constructor Demo in C#");
    }
    public constructordemo(int a, int b){
        Console.WriteLine("Welcome to Constructor Demo in C# with addition of two values through arguments" + (a+b));
    }
}






// class Program{

// static void Main(string [] args){
//     Console.WriteLine("Welcome to C# class");
//     PrintMsg();
//     Console.WriteLine(PrintMsg1());

// }

// static void PrintMsg(){
//     Console.WriteLine("Welcome to C# method");
// }

// static string PrintMsg1(){
//     return "Welcome to C# string return method ";
// }


// }

