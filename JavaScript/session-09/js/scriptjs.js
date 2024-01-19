function GetResultFun(){




// for of loop with array


var listofnames=["karthick", "ravi", "Raju", "Ramu"];


console.log("length of array listofnames .. ", listofnames.length);
console.log(listofnames[0]);
console.log(listofnames[1]);
console.table(listofnames);


for(let a=0;a<listofnames.length;a++)
{
    console.log(listofnames[a]); // a==0 : 
}

console.log("output from for OF");
for (let name of listofnames)
{

    console.log(name);
}



for(let a=0;a<listofnames.length;a++)
{
    console.log(listofnames[a]); // a==0 : 
    if(a==2){
        break;
    }
   
}

// for in loop with objects

var listofcars={name:"bmw", price:"1c", mdate:"2020"}

console.log(listofcars);
console.table(listofcars);
console.clear();

for (let property in listofcars){
    console.log(property + " : " + listofcars[property]);
}



}

GetResultFun();