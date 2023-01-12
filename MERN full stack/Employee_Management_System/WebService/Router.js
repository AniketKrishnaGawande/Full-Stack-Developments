const express=require("express");
const routes=express.Router();
const mysql = require("mysql");


const connection=mysql.createConnection({
host:"LocalHost",
user:"root",
password:"Aniket19%",
database:"EmployeeInfo"
});
connection.connect();
routes.get("/Employee",(req,resp)=>{

connection.query("select * from Employees",(err,data)=>{
if(err)
{
    resp.status(200).send("error ocurred");
}
else{
    resp.send(data);
}

});
});

routes.get("/Employee/:Eid",(req,resp)=>{

var str = "select * from Employees where Eid="+req.params.Eid;
connection.query(str,(err,data)=>{
    if(err)
    {
        resp.status(200).send("error ocurred");
    }
    else{
        resp.send(data)
    }
});
});


// router.post("/employee",(req,resp)=>{
// connection.connect();
// var str = 


// });

module.exports=routes;