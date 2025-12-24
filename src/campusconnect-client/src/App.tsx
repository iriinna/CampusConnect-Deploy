import { BrowserRouter, Routes, Route, Navigate } from 'react-router-dom';
import { ThemeProvider } from './contexts/ThemeContext';
import Login from './pages/Login';
import Register from './pages/Register';
import ConfirmEmail from './pages/ConfirmEmail';
import Home from './pages/Home';
import ViewProfile from './pages/User/ViewProfile';
import EditProfile from './pages/User/EditProfile';
import Announcements from './pages/Announcements';
import CreateAnnouncement from './pages/CreateAnnouncement';
import CreateEvent from './pages/Event/CreateEvent';
import EditEvent from './pages/Event/UpdateEvent';
import ViewEvent from './pages/Event/ViewEvent';
import UpcomingEvents from './pages/Event/UpcomingEvent';
import Groups from './pages/Groups/Groups';
import GroupDetails from './pages/Groups/GroupDetails';
import MyTasks from './pages/Groups/MyTasks';

function App() {
  return (
    <ThemeProvider>
      <BrowserRouter>
        <Routes>
          <Route path="/" element={<Navigate to="/login" replace />} />
          <Route path="/login" element={<Login />} />
          <Route path="/register" element={<Register />} />
          <Route path="/confirm-email" element={<ConfirmEmail />} />
          <Route path="/dashboard" element={<Home />} />
          <Route path="/profile" element={<ViewProfile />} />
          <Route path="/edit-profile" element={<EditProfile />} />
          <Route path="/announcements" element={<Announcements />} />
          <Route path="/create-announcement" element={<CreateAnnouncement />} />
          <Route path="/events" element={<UpcomingEvents />} />
          <Route path="/create-event" element={<CreateEvent />} />
          <Route path="/edit-event/:id" element={<EditEvent />} />
          <Route path="/event/:id" element={<ViewEvent />} />
          <Route path="/groups" element={<Groups />} />
          <Route path="/groups/:id" element={<GroupDetails />} />
          <Route path="/my-tasks" element={<MyTasks />} />
        </Routes>
      </BrowserRouter>
    </ThemeProvider>
  );
}
export default App;