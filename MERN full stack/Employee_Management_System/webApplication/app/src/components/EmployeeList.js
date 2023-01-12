import { useState } from "react";
import { useEffect } from "react";
import AxiosConnector from "./AxiosConnector";
function EmployeeList() {

    var [empArr, setEmpArr] = useState([]);

    useEffect(() => {
        AxiosConnector.getALLData().then((response)=>{
            setEmpArr(response);
            console.log("use effect called");
        })
    }, []);

    var InsertData = () => {
        return empArr.map((emp) => {return <tr><td>{empArr.Eid}</td><td>{empArr.Ename}</td><td>{empArr.Dept}</td>
                        <td>{empArr.salary}</td>
                    </tr>
            });
    }

    return (

        <div>
            <table>
                <tr>
                    <th>Employee id</th>
                    <th>Employee Name</th>
                    <th>Employee department</th>
                    <th>Salary</th>
                </tr>
                {InsertData}
            </table>

        </div>
    );

}
export default EmployeeList;