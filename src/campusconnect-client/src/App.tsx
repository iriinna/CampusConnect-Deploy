import { BrowserRouter, Routes, Route, Navigate } from 'react-router-dom';
import Login from './pages/Login';
import Register from './pages/Register';
import ConfirmEmail from './pages/ConfirmEmail';
import Home from './pages/Home';
import ProfileView from './pages/User/ViewProfile';
import EditProfile from './pages/User/EditProfile';
import Announcements from './pages/Announcements';
import CreateAnnouncement from './pages/CreateAnnouncement';
import CreateEvent from './pages/Event/CreateEvent';
import EditEvent from './pages/Event/UpdateEvent';
import ViewEvent from './pages/Event/ViewEvent';
import Navbar from './pages/Navbar';
import Users from './pages/User/Users';
import './App.css';
import UpcomingEvents from './pages/Event/UpcomingEvent';
import { Outlet } from 'react-router-dom';

const ProtectedLayout = () => {
  return (
    <>
      <Navbar />
      <div className="page-content">
        <Outlet /> 
      </div>
    </>
  );
};
function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Navigate to="/login" replace />} />
        <Route path="/login" element={<Login />} />
        <Route path="/register" element={<Register />} />
        <Route path="/confirm-email" element={<ConfirmEmail />} />

        <Route element={<ProtectedLayout />}>
          <Route path="/dashboard" element={<Home />} />
            <Route path="/profile" element={<ProfileView />} />
            <Route path="/profile/:id" element={<ProfileView />} />
          <Route path="/edit-profile" element={<EditProfile />} />
          <Route path="/announcements" element={<Announcements />} />
          <Route path="/create-announcement" element={<CreateAnnouncement />} />
          <Route path="/events" element={<UpcomingEvents />} />
          <Route path="/create-event" element={<CreateEvent />} />
          <Route path="/edit-event/:id" element={<EditEvent />} />
          <Route path="/event/:id" element={<ViewEvent />} />
          <Route path="/users" element={<Users />} />
        </Route>
      </Routes>

    </BrowserRouter>
  );
}
export default App;