import ServerConnector from "./ServerConnector";
import { useState } from "react";
function EmployeeSearch(){
var [Ob,setObj] =useState({Eid:"",Ename:"",Dept:"",Salary:""});

    function checkData(event){
        setObj(ServerConnector.getSpecificData( document.getElementById("Eid").value));
        document.getElementById("Eid").value="";
return Ob.Ename;
    }

return(
    <div>
        <label>Enter employee id ::: </label>
        <input type="number" name="Eid" id="Eid" required></input><br/>
         <button name="btn" id="btn" onClick={(event)=>checkData}>Search</button>
<br/>
         {checkData()}
    </div>
);


}
export default EmployeeSearch;