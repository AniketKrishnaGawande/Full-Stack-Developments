import { useState } from "react";
import { useEffect } from "react";
import ServerConnector from "./ServerConnector";
function EmployeeList() {

    var [empArr, setEmpArr] = useState([]);

    useEffect(() => {
        ServerConnector.getALLData().then((response)=>{
            setEmpArr(response);
            console.log(response);
            console.log("use effect called");
        })
    }, []);

    const InsertData = () => {
    
        return empArr.map((emp) =>(<tr><td>{emp.Eid}</td><td>{emp.Ename}</td><td>{emp.Dept}</td><td>{emp.Salary}</td></tr>));
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