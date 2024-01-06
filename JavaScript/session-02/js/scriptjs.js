/*
//to use console check the below line
console.log("Welcome to javascript");
console.log('Welcome to javascript1');
console.log(10);
console.log(10.10);
//to print objects in console
console.log({fname:"karthick", gender:"Male"});
console.table({fname:"karthick", gender:"Male"});
//to print Array in console
console.log([5,10,20,15]);
console.table([5,10,20,15]);
console.log(true);


// print in console with variable declartion

//var a;
//let b;
var a=5;
let b=7;
const c=10;

console.log(a);
console.log(b);
console.log(c);

a=6;
console.log(a);
b=8;
console.log(b);
console.log(c);

a=6.5;
console.log(a);
b=8.5;
console.log(b);


a="karthick";
console.log(a);
b="RAM";
console.log(b);

// you can redeclare variable used in "Var" method
//var a=25;
//console.log(a);
// you cannot redeclare variable used in "let" method 
//let b=25;
//console.log(b);


a={fname:"karthick", gender:"Male"};
console.log(a);
console.table(a);

b={fname:"karthick", gender:"Male"};
console.log(b);
console.table(b);


a=[12,11,25,60];
console.log(a);
console.table(a);


b=[12,11,25,60];
console.log(b);
console.table(b);

console.clear();

// to know what type of values given

a=1;
console.log(typeof a);

a=1.5;
console.log(typeof a);


a="Raguvaran";
console.log(a+" : "+typeof a);

a=true;
console.log(a+" : "+typeof a);

a=[12,15,10];
console.log(typeof a);


a={fname:"ragu", gender:"Male"};
console.log(typeof a);

// type conversion

a=20;
console.log(typeof a);
a=a.toString();
console.log(typeof a);

a=true;
console.log(typeof a);

a=parseInt(a);
console.log(typeof a);
console.log(a);

a=parseFloat(a);
console.log(typeof a);


a="60"
d=55;
a=a+d;
console.log(a);



*/




console.clear();

a="60"

d=55;
d=String(d);
a=Number(a);
a=a+d;
console.log(a);

var x =true;
console.log(x, typeof x);
x=Number(x);
console.log(x, typeof x);

// const a=10;

const f={name:"karthick ", age:30}
console.log(f, typeof f);
f.name="RAM";
console.log(f, typeof f);

f.name=25;
console.log(f, typeof f);


console.clear();

//OPERATORS in JAVASCRIPT

//arithmatic operator

let v1=10;
let v2=20;
//addition
console.log(v1+v2);
//subtraction
console.log(v1-v2);
//multiply
console.log(v1*v2);
//division
console.log(v1/v2);
//modulus
console.log(v1%v2);
//Expo
console.log(v1**v2);
//increment #pre
v1=++v1;
console.log(v1);
//decrement #pre
v1=--v1;
console.log(v1);

//assignment operators

v1=25;
console.log(v1);

v1+=20; // v1=v1+20;
console.log(v1);
v1-=20; // v1=v1-20;
console.log(v1);
v1*=20; // v1=25*20;
console.log(v1);
v1/=20; // v1=v1/20;
console.log(v1);
v1%=20; // v1=v1%20;
console.log(v1);



//comparision operator

console.log(v1==5);
console.log(v1==="5", typeof v1);
console.log(v1!=1);
console.log(v1!=="5", typeof v1);

//relational operator
console.log(v1>1);
console.log(v1<1);
console.log(v1>=5);
console.log(v1<=10);
console.clear();
//logical operator
v1="s";
console.log(7==5 || 7<2 || 7>5);
console.log(v1=="s");
console.log(!(v1=="s"));








