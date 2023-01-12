const express=require("express");
const routes=express.Router();
const mysql = require("mysql");

const connection=mysql.createConnection({
host:"LocalHost",
user:"root",
password:"Aniket19%",
database:"EmployeeInfo"
});

routes.get("/Employee",(req,resp)=>{
connection.connect();
connection.query("select * from Employees",(err,data)=>{
if(err)
{
    resp.status(200).send("error ocurred");
}
else{
    resp.send(data);
}
connection.end();
});
});

router.get("/Employee/:empid",(req,resp)=>{

connection.connect();
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

module.exports=routes;