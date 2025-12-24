import { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import { motion } from 'framer-motion';
import {
  User,
  Mail,
  Calendar,
  IdCard,
  Edit,
  Trash2,
  Sparkles,
  BookmarkCheck,
  CalendarCheck,
  Megaphone,
  Shield,
  LogOut,
} from 'lucide-react';
import { Layout } from '../../components/Layout';
import { Card, CardHeader, CardTitle, CardContent } from '../../components/ui/Card';
import { Button } from '../../components/ui/Button';
import { Badge } from '../../components/ui/Badge';
import { Avatar, AvatarFallback } from '../../components/ui/Avatar';

const API_BASE_URL = 'http://localhost:5099/api';
const ROLE_CLAIM_TYPE = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";

interface DecodedToken {
  nameid?: string;
  sub?: string;
  id?: string;
  role?: string;
  [key: string]: any; 
}

interface Announcement {
  id: number;
  title: string;
  content: string;
  category: string;
  createdAt: string;
}

interface Event {
  id: number;
  title: string;
  description: string;
  date: string;
  category: string;
  dateCreated: string;
}

function ProfileView() {
  const navigate = useNavigate();
  const [message, setMessage] = useState<{ type: 'success' | 'error'; text: string } | null>(null);
  const [isDeleting, setIsDeleting] = useState(false);
  const [loadingSaved, setLoading] = useState(false);
  const [savedAnnouncements, setSavedAnnouncements] = useState<Announcement[]>([]);
  const [savedEvents, setSavedEvents] = useState<Event[]>([]);
  const [participatingEvents, setParticipatingEvents] = useState<Event[]>([]);

  const user = JSON.parse(localStorage.getItem('user') || '{}');
  const token = localStorage.getItem('token');

  useEffect(() => {
    const fetchProfile = async () => {
      if (!token) {
        setLoading(false);
        return;
      }

      setLoading(true);
      try {
        const [resAnnouncements, resEvents, resParticipating] = await Promise.all([
          fetch(`${API_BASE_URL}/announcements/saved`, {
            headers: { Authorization: `Bearer ${token}` },
          }),
          fetch(`${API_BASE_URL}/event/saved`, {
            headers: { Authorization: `Bearer ${token}` },
          }),
          fetch(`${API_BASE_URL}/event/my-events`, {
            headers: { Authorization: `Bearer ${token}` },
          }),
        ]);

        if (resAnnouncements.ok) {
          const data: Announcement[] = await resAnnouncements.json();
          setSavedAnnouncements(data);
        }

        if (resEvents.ok) {
          const data: Event[] = await resEvents.json();
          setSavedEvents(data);
        }

        if (resParticipating.ok) {
          const data: Event[] = await resParticipating.json();
          setParticipatingEvents(data);
        }
      } catch (err) {
        console.error('Network error fetching saved items', err);
      } finally {
        setLoading(false);
      }
    };

    if (token) {
        fetchProfile();
    }
  }, [token]); 

  if (!user.firstName || !token) {
    return (
      <Layout>
        <div className="text-center py-12">
          <Shield className="h-16 w-16 mx-auto text-red-500 mb-4" />
          <h3 className="text-xl font-semibold mb-2 text-red-500">Not authenticated</h3>
          <p className="text-muted-foreground mb-4">Please log in to view your profile</p>
          <Button onClick={() => navigate('/login')}>Go to Login</Button>
        </div>
      </Layout>
    );
  }
  const handleDeleteAccount = async () => {
    if (
      !window.confirm(
        'Are you sure you want to delete your account? This action is irreversible!'
      )
    ) {
      return;
    }

    setIsDeleting(true);
    try {
      const res = await fetch(`${API_BASE_URL}/user/delete/${user.id}`, {
        method: 'DELETE',
        headers: { Authorization: `Bearer ${token}` },
      });

      if (res.status === 204) {
        setMessage({
          type: 'success',
          text: 'Account deleted successfully! Redirecting...',
        });

        localStorage.removeItem('user');
        localStorage.removeItem('token');

        setTimeout(() => {
          navigate('/login');
        }, 2000);
      } else {
        const errorText =
          res.status === 404
            ? 'Account not found (possibly already deleted).'
            : res.status === 401
            ? 'Session expired. Please log in again.'
            : `HTTP error ${res.status}.`;

        setMessage({
          type: 'error',
          text: errorText,
        });
      }
    } catch (error) {
      setMessage({
        type: 'error',
        text: 'Connection error. Please try again.',
      });
    } finally {
      setIsDeleting(false);
    }
  };

  const handleLogout = () => {
    localStorage.removeItem('user');
    localStorage.removeItem('token');
    navigate('/login');
  };

  return (
    <Layout>
      <div className="space-y-6">
        {/* Header with Profile Info */}
        <motion.div
          initial={{ opacity: 0, y: 20 }}
          animate={{ opacity: 1, y: 0 }}
          className="relative overflow-hidden rounded-2xl bg-gradient-to-br from-indigo-500 via-purple-500 to-pink-500 p-8 text-white shadow-2xl"
        >
          <div className="absolute inset-0 bg-[url('data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iNjAiIGhlaWdodD0iNjAiIHZpZXdCb3g9IjAgMCA2MCA2MCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj48ZyBmaWxsPSJub25lIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiPjxwYXRoIGQ9Ik0zNiAxOGMzLjMxIDAgNiAyLjY5IDYgNnMtMi42OSA2LTYgNi02LTIuNjktNi02IDIuNjktNiA2LTZ6TTI0IDBoNnY2aC02VjB6TTAgMjRoNnY2SDB2LTZ6bTAgMGg2djZIMHYtNnoiIGZpbGw9IiNmZmYiIGZpbGwtb3BhY2l0eT0iLjA1Ii8+PC9nPjwvc3ZnPg==')] opacity-30"></div>

          <div className="relative z-10 flex flex-col md:flex-row items-center gap-6">
            <Avatar className="h-32 w-32 border-4 border-white/20">
              <AvatarFallback className="text-4xl font-bold bg-white/10 text-white">
                {user.firstName?.[0]}
                {user.lastName?.[0]}
              </AvatarFallback>
            </Avatar>

            <div className="flex-1 text-center md:text-left">
              <h1 className="text-4xl font-bold flex items-center gap-2 justify-center md:justify-start">
                {user.firstName} {user.lastName}
                <Sparkles className="h-8 w-8 text-yellow-300" />
              </h1>
              <div className="mt-4 space-y-2">
                <div className="flex items-center gap-2 text-white/90 justify-center md:justify-start">
                  <Mail className="h-5 w-5" />
                  <span>{user.email}</span>
                </div>
                {user.studentId && (
                  <div className="flex items-center gap-2 text-white/90 justify-center md:justify-start">
                    <IdCard className="h-5 w-5" />
                    <span>Student ID: {user.studentId}</span>
                  </div>
                )}
                {user.dateOfBirth && (
                  <div className="flex items-center gap-2 text-white/90 justify-center md:justify-start">
                    <Calendar className="h-5 w-5" />
                    <span>{new Date(user.dateOfBirth).toLocaleDateString()}</span>
                  </div>
                )}
              </div>
            </div>

            <div className="flex flex-col gap-2">
              <Button
                onClick={() => navigate('/edit-profile')}
                className="bg-white text-purple-600 hover:bg-white/90"
              >
                <Edit className="h-4 w-4 mr-2" />
                Edit Profile
              </Button>
              <Button
                variant="outline"
                onClick={handleLogout}
                className="border-white text-white hover:bg-white/20"
              >
                <LogOut className="h-4 w-4 mr-2" />
                Logout
              </Button>
            </div>
          </div>
        </motion.div>

        {/* Message Alert */}
        {message && (
          <motion.div
            initial={{ opacity: 0, y: -10 }}
            animate={{ opacity: 1, y: 0 }}
            className={`p-4 rounded-lg ${
              message.type === 'success'
                ? 'bg-green-50 text-green-800 border border-green-200'
                : 'bg-red-50 text-red-800 border border-red-200'
            }`}
          >
            {message.text}
          </motion.div>
        )}

        {/* Stats */}
        <div className="grid grid-cols-1 md:grid-cols-3 gap-6">
          <motion.div
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ delay: 0.1 }}
          >
            <Card>
              <CardContent className="pt-6">
                <div className="flex items-center gap-4">
                  <div className="p-3 rounded-xl bg-blue-100 dark:bg-blue-900/20">
                    <Megaphone className="h-6 w-6 text-blue-600" />
                  </div>
                  <div>
                    <p className="text-sm text-muted-foreground">Saved Announcements</p>
                    <p className="text-2xl font-bold">{savedAnnouncements.length}</p>
                  </div>
                </div>
              </CardContent>
            </Card>
          </motion.div>

          <motion.div
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ delay: 0.2 }}
          >
            <Card>
              <CardContent className="pt-6">
                <div className="flex items-center gap-4">
                  <div className="p-3 rounded-xl bg-purple-100 dark:bg-purple-900/20">
                    <BookmarkCheck className="h-6 w-6 text-purple-600" />
                  </div>
                  <div>
                    <p className="text-sm text-muted-foreground">Saved Events</p>
                    <p className="text-2xl font-bold">{savedEvents.length}</p>
                  </div>
                </div>
              </CardContent>
            </Card>
          </motion.div>

          <motion.div
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ delay: 0.3 }}
          >
            <Card>
              <CardContent className="pt-6">
                <div className="flex items-center gap-4">
                  <div className="p-3 rounded-xl bg-green-100 dark:bg-green-900/20">
                    <CalendarCheck className="h-6 w-6 text-green-600" />
                  </div>
                  <div>
                    <p className="text-sm text-muted-foreground">Participating Events</p>
                    <p className="text-2xl font-bold">{participatingEvents.length}</p>
                  </div>
                </div>
              </CardContent>
            </Card>
          </motion.div>
        </div>

        {/* Saved Announcements */}
        <motion.div initial={{ opacity: 0, y: 20 }} animate={{ opacity: 1, y: 0 }} transition={{ delay: 0.4 }}>
          <Card>
            <CardHeader>
              <CardTitle className="flex items-center gap-2">
                <BookmarkCheck className="h-5 w-5" />
                Saved Announcements
              </CardTitle>
            </CardHeader>
            <CardContent>
              {loadingSaved ? (
                <div className="text-center py-8 text-muted-foreground">Loading...</div>
              ) : savedAnnouncements.length === 0 ? (
                <div className="text-center py-8 text-muted-foreground">
                  No saved announcements yet
                </div>
              ) : (
                <div className="space-y-3">
                  {savedAnnouncements.map((announcement) => (
                    <div
                      key={announcement.id}
                      className="p-4 rounded-lg border hover:bg-secondary/50 transition-colors"
                    >
                      <div className="flex items-start justify-between gap-4">
                        <div className="flex-1 min-w-0">
                          <div className="flex items-center gap-2 mb-2">
                            <Badge className="bg-blue-500 text-white">{announcement.category}</Badge>
                          </div>
                          <h4 className="font-semibold mb-1">{announcement.title}</h4>
                          <p className="text-sm text-muted-foreground line-clamp-2">
                            {announcement.content}
                          </p>
                          <p className="text-xs text-muted-foreground mt-2">
                            {new Date(announcement.createdAt).toLocaleDateString('en-US', {
                              month: 'short',
                              day: 'numeric',
                              year: 'numeric',
                            })}
                          </p>
                        </div>
                      </div>
                    </div>
                  ))}
                </div>
              )}
            </CardContent>
          </Card>
        </motion.div>

        {/* Participating Events */}
        <motion.div initial={{ opacity: 0, y: 20 }} animate={{ opacity: 1, y: 0 }} transition={{ delay: 0.5 }}>
          <Card>
            <CardHeader>
              <CardTitle className="flex items-center gap-2">
                <CalendarCheck className="h-5 w-5" />
                My Events (Participating)
              </CardTitle>
            </CardHeader>
            <CardContent>
              {loadingSaved ? (
                <div className="text-center py-8 text-muted-foreground">Loading...</div>
              ) : participatingEvents.length === 0 ? (
                <div className="text-center py-8 text-muted-foreground">
                  Not participating in any events
                </div>
              ) : (
                <div className="space-y-3">
                  {participatingEvents.map((event) => (
                    <div
                      key={event.id}
                      className="p-4 rounded-lg border bg-green-50/50 dark:bg-green-950/10 hover:bg-green-100/50 transition-colors"
                    >
                      <div className="flex items-start justify-between gap-4">
                        <div className="flex-1 min-w-0">
                          <div className="flex items-center gap-2 mb-2">
                            <Badge className="bg-purple-500 text-white">{event.category}</Badge>
                          </div>
                          <h4 className="font-semibold mb-1">{event.title}</h4>
                          <p className="text-sm text-muted-foreground line-clamp-2">
                            {event.description}
                          </p>
                          <p className="text-xs text-muted-foreground mt-2 flex items-center gap-1">
                            <Calendar className="h-3 w-3" />
                            {new Date(event.date).toLocaleDateString('en-US', {
                              month: 'short',
                              day: 'numeric',
                              year: 'numeric',
                              hour: '2-digit',
                              minute: '2-digit',
                            })}
                          </p>
                        </div>
                      </div>
                    </div>
                  ))}
                </div>
              )}
            </CardContent>
          </Card>
        </motion.div>

        {/* Danger Zone */}
        <motion.div initial={{ opacity: 0, y: 20 }} animate={{ opacity: 1, y: 0 }} transition={{ delay: 0.6 }}>
          <Card className="border-red-200 dark:border-red-900">
            <CardHeader>
              <CardTitle className="text-red-600 flex items-center gap-2">
                <Shield className="h-5 w-5" />
                Danger Zone
              </CardTitle>
            </CardHeader>
            <CardContent>
              <p className="text-sm text-muted-foreground mb-4">
                Once you delete your account, there is no going back. Please be certain.
              </p>
              <Button
                onClick={handleDeleteAccount}
                disabled={isDeleting}
                className="bg-red-600 hover:bg-red-700 text-white"
              >
                <Trash2 className="h-4 w-4 mr-2" />
                {isDeleting ? 'Deleting...' : 'Delete Account'}
              </Button>
            </CardContent>
          </Card>
        </motion.div>
      </div>
    </Layout>
  );
}

export default ProfileView;