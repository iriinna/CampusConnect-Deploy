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
import Users from './pages/User/Users';
import './App.css';
import UpcomingEvents from './pages/Event/UpcomingEvent';
import Groups from './pages/Groups/Groups';
import GroupDetails from './pages/Groups/GroupDetails';
import MyTasks from './pages/Groups/MyTasks';
import CampusMap from './pages/CampusMap/CampusMap';
import AllAchievements from './pages/Achievements/AllAchievements';
import ManageAchievements from './pages/Achievements/ManageAchievements';
import ActivityHistory from './pages/ActivityHistory';
import Library from './pages/Library/Library';
import MySubjects from './pages/Subjects/MySubjects';
import SubjectDetails from './pages/Subjects/SubjectDetails';
import MyGrades from './pages/Grades/MyGrades';

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
          <Route path="/profile/:id" element={<ViewProfile />} />
          <Route path="/edit-profile" element={<EditProfile />} />
          <Route path="/announcements" element={<Announcements />} />
          <Route path="/create-announcement" element={<CreateAnnouncement />} />
          <Route path="/events" element={<UpcomingEvents />} />
          <Route path="/create-event" element={<CreateEvent />} />
          <Route path="/edit-event/:id" element={<EditEvent />} />
          <Route path="/event/:id" element={<ViewEvent />} />
          <Route path="/groups" element={<Groups />} />
          <Route path='/users' element={<Users />} />
          <Route path="/groups/:id" element={<GroupDetails />} />
          <Route path="/my-tasks" element={<MyTasks />} />
          <Route path="/campus-map" element={<CampusMap />} />
          <Route path="/achievements" element={<AllAchievements />} />
          <Route path="/manage-achievements" element={<ManageAchievements />} />
          <Route path="/activity-history" element={<ActivityHistory />} />
          <Route path="/library" element={<Library />} />
          <Route path="/subjects" element={<MySubjects />} />
          <Route path="/subjects/:id" element={<SubjectDetails />} />
          <Route path="/my-grades" element={<MyGrades />} />
        </Routes>
      </BrowserRouter>
    </ThemeProvider>

  );
}
export default App;