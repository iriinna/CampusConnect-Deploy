import { BrowserRouter, Routes, Route, Navigate } from 'react-router-dom';
import Login from './pages/Login';
import Register from './pages/Register';
import ConfirmEmail from './pages/ConfirmEmail';
import Home from './pages/Home';
import './App.css';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Navigate to="/login" replace />} />
        <Route path="/login" element={<Login />} />
        <Route path="/register" element={<Register />} />
        <Route path="/confirm-email" element={<ConfirmEmail />} />
        <Route path="/dashboard" element={<Home />} />
        <Route path="/profile" element={<ViewProfile />} />
      </Routes>
    </BrowserRouter>
  );
}
export default App;