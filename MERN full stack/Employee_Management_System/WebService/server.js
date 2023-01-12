const bodyParser = require("body-parser");
const express=require("express");
const app = express();
const router = require("./Router");
const cors = require("cors");


app.use(bodyParser.urlencoded({extended:false}));
app.use(bodyParser.json());

app.use(function(req, res, next) {
    res.setHeader('Access-Control-Allow-Origin', '*');
    res.setHeader('Access-Control-Allow-Methods', 'GET, POST, PUT, DELETE');
    res.setHeader('Access-Control-Allow-Headers', 'Content-Type');
    res.setHeader('Access-Control-Allow-Credentials', true);
    next();
    });


app.use("/",router);

app.listen(4000);
console.log("server stated at 4000");
module.exports=app;