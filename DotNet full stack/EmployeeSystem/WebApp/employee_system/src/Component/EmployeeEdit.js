import { useState, useEffect } from "react";
import { useLocation } from "react-router-dom";

const EmployeeEdit=()=>{
    var [empOb,setEmpOb]=useState({eId:"",eName:"",eDept:"",eSalary:""});
var state = useLocation().state;
useEffect(()=>{
    setEmpOb={...state.employee};
},[]);
return(
    <div>
<input value={empOb.eId}></input>

    </div>
);


}
export default EmployeeEdit;