

function EmployeeForm(){
//********** Swanand Kale CopyRights Reserved *****************
return(
    <div>
<form method="POST" action="/employee">
<label htmlFor="Ename">Name :: </label>
    <input type="text" name="Ename" id="Ename"></input><br></br>

    <label htmlFor="Dept">Dept:: </label>
    <input type="text" name="Dept" id="Dept"></input><br></br>

    <label htmlFor="Salary">Salary :: </label>
    <input type="number" name="Salary" id="Salary"></input><br></br>

    <button type="submit" name="btn" id="btn">Add Data</button>
</form>



    </div>
);


}

export default EmployeeForm;