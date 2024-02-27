const { createPool } =require('mysql')

const con= createPool({
host:"192.168.1.240",
user:"cad",
password:"password",
database:"a",
connectionLimit:10
})

var x=con.query("select * from sys_info", (err,result, fields)=>{
    if(err){
        return console.log(err);
    }
    var string=JSON.stringify(result);
    console.log(string);
    var json =  JSON.parse(string);
   // to get one value here is the option
    console.log(json[0].name);
})


    


