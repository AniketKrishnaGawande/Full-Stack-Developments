const bodyParser = require("body-parser");
const express=require("express");
const app = express();
const router = require("./Router");



app.use(bodyParser.urlencoded({extended:false}));
app.use(bodyParser.json());

app.use("/",router);

app.listen(3000);
console.log("server stated at 3000");
module.exports=app;