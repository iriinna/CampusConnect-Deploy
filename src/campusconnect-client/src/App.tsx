import { BrowserRouter, Routes, Route, Navigate } from 'react-router-dom';
import Login from './pages/Login';
import Register from './pages/Register';
import ConfirmEmail from './pages/ConfirmEmail';
<<<<<<< Updated upstream
=======
import Home from './pages/Home';
import ViewProfile from './pages/User/ViewProfile';
import EditProfile from './pages/User/EditProfile';
import Announcements from './pages/Announcements';
import CreateAnnouncement from './pages/CreateAnnouncement';
import CreateEvent from './pages/Event/CreateEvent';
import EditEvent from './pages/Event/UpdateEvent';
import ViewEvent from './pages/Event/ViewEvent';

>>>>>>> Stashed changes
import './App.css';
import UpcomingEvents from './pages/Event/UpcomingEvent';

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Navigate to="/login" replace />} />
        <Route path="/login" element={<Login />} />
        <Route path="/register" element={<Register />} />
        <Route path="/confirm-email" element={<ConfirmEmail />} />
<<<<<<< Updated upstream
        <Route path="/dashboard" element={<Dashboard />} />
=======
        <Route path="/dashboard" element={<Home />} />
        <Route path="/profile" element={<ViewProfile />} />
        <Route path="/edit-profile" element={<EditProfile />} />
        <Route path="/announcements" element={<Announcements />} />
        <Route path="/create-announcement" element={<CreateAnnouncement />} />
        <Route path="/events" element={<UpcomingEvents />} />
        <Route path="/create-event" element={<CreateEvent />} />
        <Route path="/edit-event/:id" element={<EditEvent />} />
        <Route path="/event/:id" element={<ViewEvent />} />

>>>>>>> Stashed changes
      </Routes>
    </BrowserRouter>
  );
}

function Dashboard() {
  const user = JSON.parse(localStorage.getItem('user') || '{}');
  
  return (
    <div style={{ padding: '40px', textAlign: 'center' }}>
      <h1>Dashboard - CampusConnect</h1>
      <p>Bun venit, {user.firstName} {user.lastName}!</p>
      <p>Email: {user.email}</p>
      <button 
        onClick={() => {
          localStorage.clear();
          window.location.href = '/login';
        }}
        style={{
          padding: '10px 20px',
          background: '#dc3545',
          color: 'white',
          border: 'none',
          borderRadius: '5px',
          cursor: 'pointer',
          marginTop: '20px'
        }}
      >
        Logout
      </button>
    </div>
  );
}

export default App;
