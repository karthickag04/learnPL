function GetResultFun(){

    var inputValue=document.getElementById("tb_value").value;
    console.log(inputValue);

    

    inputValue=Number(inputValue);

    // while loop

    while(inputValue<20) // 11<20
    
    {
        console.log("input value "+ inputValue + " is smaller than 20 "); //printed
        inputValue++; // increased
        //console.log("input value "+ x + " is smaller than 20 "); // print
        
    }

// do while loop
    do{
        console.log("input value in do while for  "+ inputValue + " is smaller than 20 "); 
        inputValue++;
    }
    while(inputValue<0)

// for loop



//for (stat1; state2;state3l)
//   for(var a=0; a < 20; a++)  {
//     console.log("input value in for loop  "+ a + " is smaller than 20 "); 
//   }
for(inputValue;inputValue <30; inputValue++){
    console.log("input value in for loop  "+ inputValue + " is smaller than 20 "); 
}


}