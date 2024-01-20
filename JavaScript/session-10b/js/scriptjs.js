
function GetResultFun(){
var namelist
=["karthick", "kavin", "kayal", "ragu", "mani", "harsh", "anand", "basheer"];   

console.log(namelist);
 console.table(namelist);
// console.table(namelist[0]);
// console.table(namelist[1]);
// console.table(namelist[2]);
// console.table(namelist[3]);
// console.table(namelist[4]);

for (var a=0; a<namelist.length;a++)
{
    console.log(namelist[a]);
}

console.clear();
var result=namelist.forEach(function(name1){
    console.log(name1);
})
console.log("arrow output");

var result=namelist.forEach(name1=>console.log(name1));

var namelist
=["karthick", "kavin", "kayal", "ragu", "mani", "harsh", "anand", "basheerk"]; 
var define1="m";
console.clear();
var result=namelist.filter(name1=>name1.startsWith("k") || name1.endsWith("k") || name1.startsWith(define1));
console.log(result);

var listofnumbers=[1,2,3,4];
var result=listofnumbers.map(number=>number*2);
console.log(result);


var result=listofnumbers.reduce((sum,number)=>sum+=1);
console.log(result);

console.log(Math.PI);
console.log(Math.E);
console.log(2*Math.PI*2);
var a=4.4;
console.log(Math.round(4.4));
console.log(Math.floor(4.5));
console.log(Math.ceil(4.4));
console.log(Math.sqrt(4));
console.log(Math.pow(4,2));
console.log(Math.floor(Math.random()*10+1000));
console.log(Math.abs(-4.75));
console.log(Math.floor(-4.75));
console.log(Math.min(20,25,35,25));
console.log(Math.max(20,25,35,25));

}


GetResultFun();


