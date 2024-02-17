using System;
class Program{

static void printMSG(){
    Console.WriteLine("Welcome To C# Method");
    printMSGfromM2();
}

static void printMSGfromM2(){
    Console.WriteLine("Welcome To C# printed via Method 2");
}


static void printMSGfromM2withArgs(int x){
    Console.WriteLine("Welcome To C# printed via Method 2    " + x);
}

static string returnMsgMethod(){
    string name="cadbatch01R";
    return name;
//    Console.WriteLine(name);
}



static int returnIntMsgMethod(){
    int batchnumber=01;
    return batchnumber;
//    Console.WriteLine(name);
}

static void voidMsgMethod(){
    string name="cadbatch01";
    Console.WriteLine(name);

     if(name=="cadbatch01"){
        Console.WriteLine("value printed inside  VoidMsgMethod is Correct");
    }
    else{
        Console.WriteLine("value printed inside VoidMsgMethod is Wrong");
    }

    //return name;
}


static void Main(string [] args){
    // Console.WriteLine("Welcome to C# Main Method");
    // printMSG();
    // //printMSGfromM2()

    Console.WriteLine( returnMsgMethod());

  
    voidMsgMethod();


    if(returnMsgMethod()=="cadbatch01R"){
        Console.WriteLine("Passed value by returnMsgMethod is Correct");
    }
    else{
        Console.WriteLine("Passed value by returnMsgMethod is Wrong");
    }

    Console.WriteLine(  returnIntMsgMethod());
 

    
    printMSGfromM2withArgs(2);


}

}