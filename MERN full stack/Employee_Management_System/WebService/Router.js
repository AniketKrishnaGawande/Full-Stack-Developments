const express = require("express");
const routes = express.Router();
const mysql = require("mysql");


const connection = mysql.createConnection({
    host: "LocalHost",
    user: "root",
    password: "Aniket19%",
    database: "EmployeeInfo"
});
connection.connect();
routes.get("/Employee", (req, resp) => {

    connection.query("select * from Employees", (err, data) => {
        if (err) {
            console.log("data not send");
            resp.status(200).send("error ocurred");
        }
        else {
console.log("data send");
            resp.send(data);
        }

    });
});

routes.get("/Employee/:Eid", (req, resp) => {

    var str = "select * from Employees where Eid=" + req.params.Eid;
    connection.query(str, (err, data) => {
        if (err) {
            resp.status(200).send("error ocurred");
        }
        else {
            resp.send(data)
        }
    });
});

routes.post("/employee", (req, resp) => {

    var str = "insert into Employees(Ename,Dept,Salary) values('" + req.body.Ename + "','" + req.body.Dept + "','" + req.body.Salary + "');";

    connection.query(str, (err, data) => {
        if (err) {
            resp.status(200).send(err);
        }
        else {
            resp.send(data);
        }
    })
});

routes.put("/employee/:Eid", (req, resp) => {
    var str = "update Employees SET Ename='" + req.body.Ename + "', Dept='" + req.body.Dept + "', Salary=" + req.body.Salary + " Where Eid=" + req.params.Eid;
    connection.query(str, (err, data) => {
        if (err) {
            resp.send(err);
        }
        else {
            resp.send(data);
        }
    })
});

routes.delete("/employee/:Eid", (req, resp) => {
    var str = "delete from Employees where Eid=" + req.params.Eid;
    connection.query(str, (err, data) => {
        if (err) {
            resp.send("error occured");
        }
        else {
            resp.send(data);
        }
    })
})
// router.post("/employee",(req,resp)=>{
// connection.connect();
// var str = 


// });

module.exports = routes;