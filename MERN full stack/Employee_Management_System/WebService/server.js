const bodyParser = require("body-parser");
const express=require("express");
const app = express();
const router = require("./Router");
const cors = require("cors");


app.use(bodyParser.urlencoded({extended:false}));
app.use(bodyParser.json());

app.use(cors('*'));

app.use("/",router);

app.listen(4000);
console.log("server stated at 4000");
module.exports=app;