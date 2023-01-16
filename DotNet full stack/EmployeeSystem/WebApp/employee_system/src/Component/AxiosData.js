import axios from "axios";
class ServerConnection{
constructor(){
    this.basicURL="http://localHost:5008";
}
GetAllData=()=>{
return axios.get(this.basicURL+"/Employees");
}
deleteEmployee=(id)=>{
axios.delete(this.basicURL+"/Employees/"+id);
}
}

export default new ServerConnection();

