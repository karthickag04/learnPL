
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


}


GetResultFun();