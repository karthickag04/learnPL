function GetResultFun(){

var text= "      welcome to welcome javascript to program organized by brightskills and brightskills welcomes to you once again    ";

var output=text.toUpperCase();
console.log(output);
var output=text.toLowerCase();
console.log(output);

var output=text.slice(0,4);
console.log(output);

var output=text.slice(-10);
console.log(output);


var output=text.substring(0,4);
console.log(output);
var output=text.substring(-10);
console.log(output);



var output=text.charAt(0);
console.log(output);

var output=text.charCodeAt(0);
console.log(output);

var output=text.startsWith("w");
console.log(output);


var output=text.endsWith("n");
console.log(output);


var output=text.replace('welcome', 'hi');
console.log(output);

var output=text.replaceAll('welcome', 'hi');
console.log(output);

var number="5";
number=number.padStart(5,"B");
console.log(number);

var number="5";
number=number.padEnd(5,"B");
console.log(number);


//split

console.table(text.split(" "));

console.log(text.length);
var text1=text.trim();
console.log(text1.length);

}

GetResultFun();