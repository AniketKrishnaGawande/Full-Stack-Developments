
import './App.css';
import {BrowserRouter, Routes, Route} from "react-router-dom";
import Home from "./components/Home";
import EmployeeList from './components/EmployeeList';

function App() {
  return (
    <div> 
      <BrowserRouter>
      <Routes>
             <Route path='/' element={<Home></Home>}></Route>
             <Route path='/employee' element={<EmployeeList></EmployeeList>}></Route>
      </Routes>
      </BrowserRouter>
      
          </div>
  );
}

export default App;
