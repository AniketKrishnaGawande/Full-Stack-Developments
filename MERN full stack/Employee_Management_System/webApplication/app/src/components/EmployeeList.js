import { useState } from "react";
import { useEffect } from "react";
import ServerConnector from "./ServerConnector";
function EmployeeList() {

    var [empArr, setEmpArr] = useState([]);

    useEffect(() => {
        ServerConnector.getALLData().then((response)=>{
            setEmpArr(response.data);
        })
    }, []);

    const InsertData = () => {
        
        return empArr.map((emp) =>{return<tr><td>{emp.Eid}</td><td>{emp.Ename}</td><td>{emp.Dept}</td><td>{emp.Salary}</td></tr> });
    }

    return ( <div>
            <table>
                <tr>
                    <th>Employee id</th>
                    <th>Employee Name</th>
                    <th>Employee department</th>
                    <th>Salary</th>
                </tr>
                {InsertData()}
            </table>

        </div>
    );

}
export default EmployeeList;