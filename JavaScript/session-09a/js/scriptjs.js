function GetResultFun(){



var text= "welcome to welcome javascript program organized by brightskills and brightskills welcomes you once again";

console.log(text.length);
console.log(text.indexOf("welcome"));
console.log(text.indexOf("welcome", 10));
console.log(text.lastIndexOf("welcome"));
console.log(text.search("welcome"));
let arr=text.search(/welcome/);
console.log(arr);
let arr1=text.match(/welcome/);
console.log(arr1);
let arr11=text.match(/welcome/gi);
console.log(arr11);

console.log(text.slice(19,29));


console.clear();


// date usage

let today= new Date();

console.log(today);

console.log(today.toDateString());
console.log(today.toLocaleDateString());
console.log(today.toISOString());
console.log(today.toLocaleString());
console.log(today.toString());
console.log(today.toTimeString());
console.log(today.toUTCString());
console.log(today.getFullYear());
console.log(today.getDate());
console.log(today.getHours());
console.log(today.getMilliseconds());
console.log(today.getSeconds());

console.log(today.getMonth());

var month=["jan", "feb", "mar", "apr" ];
console.log(month[today.getMonth()]);

let dob=new Date("2004-12-05");
console.log(dob);


let age =today.getFullYear()-dob.getFullYear();
console.log(age);






}

GetResultFun();