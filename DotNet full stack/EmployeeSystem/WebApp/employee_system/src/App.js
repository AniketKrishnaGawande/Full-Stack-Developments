import logo from './logo.svg';
import './App.css';
import Header from "./Component/Header";
import Home  from './Component/Home';
import EmployeeList from './Component/EmployeeList';
import { BrowserRouter, Route, Routes } from "react-router-dom";
import EmployeeEdit from './Component/EmployeeEdit';
function App() {
  return (
    <div>
    <div className="App">
      <Header></Header>
      </div>
      <BrowserRouter>
        <Routes>
          <Route path='/' exact element={<Home></Home>}></Route>
          <Route path='/Employee' exact element={<EmployeeList></EmployeeList>}></Route>
          <Route path='/Employee/Edit/:eId' exact element={<EmployeeEdit></EmployeeEdit>}></Route>
        </Routes>

      </BrowserRouter>


    </div>
  );
}

export default App;
