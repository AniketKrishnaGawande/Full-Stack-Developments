import { useState } from "react";
import { useEffect } from "react";
import { Link } from "react-router-dom";
import ServerData from "./AxiosData";
const EmployeeList = () => {
    var [EmpArr, SetArr] = useState([]);
    var [flag, setflag] = useState(false);
    useEffect(() => {
        ServerData.GetAllData().then((resp) => {
            SetArr(resp.data);
            console.log(resp.data);
        }).catch((err) => {
            console.log(err);
        });
    }, []);
    const deleteData = (id) => {
        ServerData.deleteEmployee(id);
        setflag(true);
    }

    const renderData = (array=EmpArr) => {
        return array.map((emp) => {
            return <tr>
                <td>{emp.eid}</td>
                <td>{emp.eName}</td>
                <td>{emp.eDept}</td>
                <td>{emp.eSalary}</td>
                <Link to={{ pathname: `/Employee/Edit/${emp.eid}`, state:{ employee: emp }}}>
                    <button>Edit</button>
                </Link>
                <button onClick={() => { deleteData(emp.eid) }}>Delete</button>


            </tr>
        });
    }
    return (
        <div>
            <table>
                <tr>
                    <th>Employee Id</th>
                    <th>Employee Name</th>
                    <th>Employee Department</th>
                    <th>Employee Salary</th>
                </tr>
                {renderData()}
            </table>
            <Link to="/">
                <button>Home</button>
            </Link>
        </div>


    );



}
export default EmployeeList;