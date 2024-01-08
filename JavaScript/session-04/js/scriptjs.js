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

console.clear();

//ternary or conditional operator
//condtion ? statemnt1 :statement2;
console.log(v1);
var output=v1=="s"? "v1 has value" : "v1 doesnot have value";
console.log(output);
//condtional chains with Ternary
/*
m=34; //input
//35 32grade c 60 grade b 80 grade a 90 grade Distintion
var mark= (35<=m && m<60) ? "grade c" : (60<=m && m<80) ? "Grade B" : (80<=m && m<90) ? "Grade A" : (90<=m && m<=100) ? "Grade Distinction" : "Fail";
console.log(mark); // output
*/
//function declaration

function findGrade(){

    m=34; //input
//35 32grade c 60 grade b 80 grade a 90 grade Distintion
var mark= (35<=m && m<60) ? "grade c" : (60<=m && m<80) ? "Grade B" : (80<=m && m<90) ? "Grade A" : (90<=m && m<=100) ? "Grade Distinction" : "Fail";
console.log(mark); // output

}

findGrade();



function findGrade1(m,k){

     //input
//35 32grade c 60 grade b 80 grade a 90 grade Distintion
var mark= (35<=m && m<60) ? "grade c" : (60<=m && m<80) ? "Grade B" : (80<=m && m<90) ? "Grade A" : (90<=m && m<=100) ? "Grade Distinction" : "Fail";
console.log(k,mark); // output


}

findGrade1(65,"karthick");



var findgrade2=(m,k)=>{
    var mark= (35<=m && m<60) ? "grade c" : (60<=m && m<80) ? "Grade B" : (80<=m && m<90) ? "Grade A" : (90<=m && m<=100) ? "Grade Distinction" : "Fail";
console.log(k,mark); // output
};
console.log(findgrade2(36,"ram"));
// using functions
 
function checkgrade(){
console.log("welcome");
console.log("just trying");

}


var checkgrade1=(a,b)=>{
   // console.log(a+b);
return a+b;
};

checkgrade();
// to get output in log using function
console.log("added Value", checkgrade1(1,2))

//to store output in variable to print in console
var printmsg =checkgrade1(1,2);
console.log(printmsg);

// trying to short the code
var checkgrade2=(a,b)=> a+b;

console.log(checkgrade2(5,10));


// trying to short the code
var checkgrade2=()=> checkgrade();

console.log(checkgrade2());

// conditional statements
// if condition
function gradeChecking(m){
if(35>m && m!=null)
{
console.log("no grade");
console.log("Fail");
}
}

gradeChecking(45);



// if else condition
function gradeChecking(m){
    if(35>m && m!=null)
    {
    console.log("no grade");
    console.log("Fail");
    }
    else{
        console.log("Pass");
        console.log("Other Grades");
    
    }
    }

    
    gradeChecking(45);
    

console.clear();
    
// nested if else condition
function gradeChecking(m){
    if(35>m && m!=null)
    {
    console.log("no grade");
    console.log("Fail");
    }
    else{
        if(35<m && m!=null && m<=60){

            console.log("Pass");
            console.log("Grade c");
                }

        else if(60<m && m!=null && m<=80){

            console.log("Pass");
            console.log("Grade b");
                }

        else if(80<m && m!=null && m<=100){

            console.log("Pass");
            console.log("Grade A");
                }
                else{

                    gradeChecking(prompt("enter mark"));
                }
                
    }
    }

    
    gradeChecking(99);
    