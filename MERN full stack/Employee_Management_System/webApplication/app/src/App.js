
import './App.css';
import {BrowserRouter, Routes, Route} from "react-router-dom";
import Home from "./components/Home";
import EmployeeList from './components/EmployeeList';
import EmployeeForm from './components/EmployeeForm';
import EmployeeSearch from "./components/EmployeeSearch"

function App() {
  return (
    <div> 
      <Home></Home>
      <BrowserRouter>
      <Routes>
             <Route path='/employee' element={<EmployeeList></EmployeeList>}></Route>
             <Route path='/search' element={<EmployeeSearch></EmployeeSearch>}></Route>
      </Routes>
      </BrowserRouter>
      
          </div>
  );
}

export default App;
