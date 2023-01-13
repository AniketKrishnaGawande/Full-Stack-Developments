import axios from "axios";

class ServerConnector{

constructor(){
    this.basicURL="http://localhost:4000/";
}

getALLData(){
return axios.get(this.basicURL+"employee");
}

getSpecificData(id){
    return axios.get(this.basicURL+"employee/"+id);
    }
}
export default new ServerConnector();