const {createPool}=require('mysql');

const value=createPool({
    host:"192.168.1.240",
    user:"cad",
    password:"password",
    database:"a",
    connectionLimit:10
})

value.query("select * from cad_details", (err, output, fields)=>{

    if(err){
        return console.log(err);
    }
    return console.log(output);

})