import { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import { motion } from 'framer-motion';
import {
  User,
  Mail,
  X,
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
  ArrowRight,
  Check,
  Inbox,
  Trophy,
  CreditCard
} from 'lucide-react';
import { Layout } from '../../components/Layout';
import { Card, CardHeader, CardTitle, CardContent } from '../../components/ui/Card';
import { Button } from '../../components/ui/Button';
import { Badge } from '../../components/ui/Badge';
import { Avatar, AvatarFallback } from '../../components/ui/Avatar';
import { AchievementCard } from '../../components/AchievementCard';
import achievementApi, { type UserAchievement } from '../../services/achievementApi';

const API_BASE_URL = 'http://localhost:5099/api';


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

interface Notification {
  id: number;
  message: string;
  relatedEntityId: number; 
  relatedEntityType: string;
  createdAt: string;
  isRead: boolean;
}

function ProfileView() {
  const navigate = useNavigate();
  
  const [message, setMessage] = useState<{ type: 'success' | 'error'; text: string } | null>(null);
  const [isDeleting, setIsDeleting] = useState(false);
  const [loading, setLoading] = useState(false);

  const [savedAnnouncements, setSavedAnnouncements] = useState<Announcement[]>([]);
  const [savedEvents, setSavedEvents] = useState<Event[]>([]);
  const [participatingEvents, setParticipatingEvents] = useState<Event[]>([]);

  const [notifications, setNotifications] = useState<Notification[]>([]);
  const [mySubscriptions, setMySubscriptions] = useState<string[]>([]);
  const [myAchievements, setMyAchievements] = useState<UserAchievement[]>([]);  
  
  const [availableCategories] = useState(["General", "Exams", "Events", "Administrative", "Fun", "Hackathons"]);

  const user = JSON.parse(localStorage.getItem('user') || '{}');
  const token = localStorage.getItem('token');
  const isAdmin = user.role === 'Admin' || user.isAdmin === true;

  useEffect(() => {
    const fetchProfileData = async () => {
      if (!token) return;

      setLoading(true);
      try {
        const [
            resSavedAnn,
            resSavedEvt,
            resMyEvt,
            resNotif,
            resSubs
        ] = await Promise.all([
          fetch(`${API_BASE_URL}/announcements/saved`, { headers: { Authorization: `Bearer ${token}` } }),
          fetch(`${API_BASE_URL}/event/saved`, { headers: { Authorization: `Bearer ${token}` } }),
          fetch(`${API_BASE_URL}/event/my-events`, { headers: { Authorization: `Bearer ${token}` } }),
          fetch(`${API_BASE_URL}/notification`, { headers: { Authorization: `Bearer ${token}` } }),
          fetch(`${API_BASE_URL}/announcements/subscriptions`, { headers: { Authorization: `Bearer ${token}` } })
        ]);

        if (resSavedAnn.ok) setSavedAnnouncements(await resSavedAnn.json());
        if (resSavedEvt.ok) setSavedEvents(await resSavedEvt.json());
        if (resMyEvt.ok) setParticipatingEvents(await resMyEvt.json());
        if (resNotif.ok) setNotifications(await resNotif.json());
        if (resSubs.ok) setMySubscriptions(await resSubs.json());

        const achievements = await achievementApi.getMyAchievements();
        setMyAchievements(achievements);

      } catch (err) {
        console.error('Error loading profile data', err);
      } finally {
        setLoading(false);
      }
    };

    if (token) fetchProfileData();
  }, [token]); 


  const toggleSubscription = async (category: string) => {
    const isSubscribed = mySubscriptions.includes(category);
    const endpoint = isSubscribed ? 'unsubscribe' : 'subscribe';
    
    if (isSubscribed) {
        setMySubscriptions(prev => prev.filter(c => c !== category));
    } else {
        setMySubscriptions(prev => [...prev, category]);
    }

    try {
        await fetch(`${API_BASE_URL}/announcements/${endpoint}`, {
            method: 'POST',
            headers: { 
                'Content-Type': 'application/json',
                Authorization: `Bearer ${token}` 
            },
            body: JSON.stringify(category) 
        });
    } catch (error) {
        console.error("Eroare la abonare", error);
    }
  };

  const markAsRead = async (id: number) => {
    setNotifications(prev => prev.filter(n => n.id !== id));
    try {
        await fetch(`${API_BASE_URL}/notification/${id}/read`, {
            method: 'PUT',
            headers: { Authorization: `Bearer ${token}` }
        });
    } catch (error) { console.error(error); }
  };

  const markAllRead = async () => {
    setNotifications([]);
    try {
        await fetch(`${API_BASE_URL}/notification/read-all`, {
            method: 'PUT',
            headers: { Authorization: `Bearer ${token}` }
        });
    } catch (error) { console.error(error); }
  };

  const handleLogout = () => {
    localStorage.removeItem('user');
    localStorage.removeItem('token');
    navigate('/login');
  };

  const handleDeleteAccount = async () => {
    if (!window.confirm('Are you sure? This is irreversible!')) return;
    setIsDeleting(true);
    try {
      const res = await fetch(`${API_BASE_URL}/user/delete/${user.id}`, {
        method: 'DELETE',
        headers: { Authorization: `Bearer ${token}` },
      });
      if (res.status === 204) {
        localStorage.clear();
        navigate('/login');
      }
    } catch (error) { setMessage({ type: 'error', text: 'Error deleting account' }); }
    setIsDeleting(false);
  };

  if (!user.firstName || !token) return <Layout><div>Not authenticated</div></Layout>;

  return (
    <Layout>
      <div className="space-y-6">
        
        {/* HEADER PROFIL */}
        <motion.div
          initial={{ opacity: 0, y: 20 }}
          animate={{ opacity: 1, y: 0 }}
          className="relative overflow-hidden rounded-2xl bg-gradient-to-br from-indigo-500 via-purple-500 to-pink-500 p-8 text-white shadow-2xl"
        >
          <div className="relative z-10 flex flex-col md:flex-row items-center gap-6">
            <Avatar className="h-32 w-32 border-4 border-white/20">
              <AvatarFallback className="text-4xl font-bold bg-white/10 text-white">
                {user.firstName?.[0]}{user.lastName?.[0]}
              </AvatarFallback>
            </Avatar>

            <div className="flex-1 text-center md:text-left">
              <h1 className="text-4xl font-bold flex items-center gap-2 justify-center md:justify-start">
                {user.firstName} {user.lastName}
                <Sparkles className="h-8 w-8 text-yellow-300" />
              </h1>
              <div className="mt-4 space-y-2">
                <div className="flex items-center gap-2 text-white/90 justify-center md:justify-start">
                  <Mail className="h-5 w-5" /> <span>{user.email}</span>
                </div>
                {user.studentId && (
                  <div className="flex items-center gap-2 text-white/90 justify-center md:justify-start">
                    <IdCard className="h-5 w-5" /> <span>Student ID: {user.studentId}</span>
                  </div>
                )}
              </div>
            </div>

            <div className="flex flex-col gap-2">
              <Button onClick={() => navigate('/edit-profile')} className="bg-white text-purple-600 hover:bg-white/90">
                <Edit className="h-4 w-4 mr-2" /> Edit Profile
              </Button>
              {user.studentId && (
                <Button onClick={() => navigate('/student-card')} className="bg-amber-500 text-white hover:bg-amber-600">
                  <CreditCard className="h-4 w-4 mr-2" /> Student Card
                </Button>
              )}
              <Button variant="outline" onClick={handleLogout} className="border-white text-white hover:bg-white/20">
                <LogOut className="h-4 w-4 mr-2" /> Logout
              </Button>
            </div>
          </div>
        </motion.div>

        {/* NOTIFICATIONS SECTION (BLUE) - Anunturi Noi */}
        {notifications.length > 0 && (
          <motion.div 
            initial={{ opacity: 0, scale: 0.95 }}
            animate={{ opacity: 1, scale: 1 }}
            className="rounded-xl border border-blue-200 bg-blue-50 p-6 shadow-sm dark:bg-blue-950/20 dark:border-blue-900"
          >
            <div className="flex items-center justify-between mb-4">
              <div className="flex items-center gap-3">
                <div className="p-2 bg-blue-100 text-blue-600 rounded-full dark:bg-blue-900 dark:text-blue-400">
                  <Inbox className="h-6 w-6 animate-bounce" />
                </div>
                <div>
                  <h3 className="text-lg font-bold text-blue-800 dark:text-blue-300">
                    Notifications
                  </h3>
                  <p className="text-sm text-blue-600 dark:text-blue-400">
                    You have {notifications.length} new notifications.
                  </p>
                </div>
              </div>
              
              {/* --- AICI ESTE MODIFICAREA: GRUP DE BUTOANE --- */}
              <div className="flex gap-2">
                <Button 
                  variant="outline" 
                  size="sm" 
                  onClick={() => navigate('/notifications')} 
                  className="bg-white/50 hover:bg-white text-blue-700 border-blue-200"
                >
                  View All History
                </Button>
                <Button 
                  variant="ghost" 
                  size="sm" 
                  onClick={markAllRead} 
                  className="text-blue-700 hover:bg-blue-100 hover:text-blue-900"
                >
                  Mark all read
                </Button>
              </div>
            </div>
          

            <div className="space-y-2">
              {notifications.map(notif => (
                <div key={notif.id} className="flex items-center justify-between bg-white p-3 rounded-lg border border-blue-100 dark:bg-zinc-900 dark:border-zinc-800 shadow-sm">
                    <div className="flex flex-col">
                        <span className="text-sm font-medium">{notif.message}</span>
                        <span className="text-xs text-muted-foreground">
                            {new Date(notif.createdAt).toLocaleDateString()}
                        </span>
                    </div>
                    
                    <div className="flex gap-2">
                        {/* Buton de navigare inteligent */}
                        {notif.relatedEntityId && (
                          <Button 
                            size="sm" 
                            variant="ghost" 
                            className="h-8 w-8 p-0" 
                            onClick={() => {
                                if (notif.relatedEntityType === 'GroupTask') {
                                    navigate(`/groups/${notif.relatedEntityId}`); 
                                } else if (notif.relatedEntityType === 'Announcement') {
                                    navigate(`/announcements`); 
                                }
                                else if (notif.relatedEntityType === 'Event') {
                                    navigate(`/event/${notif.relatedEntityId}`);
                                }
                                else if (notif.relatedEntityType === 'RoomBookingRequest') {
                                    if (isAdmin) {
                                        navigate(`/booking-requests`);
                                    }
                                }

                                
                            }}
                          >
                              <ArrowRight className="h-4 w-4" />
                          </Button>
                        )}

                        {/* Buton Dismiss */}
                        <Button size="sm" variant="ghost" className="h-8 w-8 p-0 text-gray-400 hover:text-red-500" onClick={() => markAsRead(notif.id)}>
                            <span className="sr-only">Dismiss</span>
                            <X className="h-4 w-4" /> 
                        </Button>
                    </div>
                </div>
              ))}
            </div>
          </motion.div>
        )}

        {/* STATS GRID */}
        <div className="grid grid-cols-1 md:grid-cols-4 gap-6">
          <Card>
            <CardContent className="pt-6 flex items-center gap-4">
               <div className="p-3 rounded-xl bg-blue-100 dark:bg-blue-900/20"><Megaphone className="h-6 w-6 text-blue-600" /></div>
               <div><p className="text-sm text-muted-foreground">Saved Announcements</p><p className="text-2xl font-bold">{savedAnnouncements.length}</p></div>
            </CardContent>
          </Card>
          <Card>
            <CardContent className="pt-6 flex items-center gap-4">
               <div className="p-3 rounded-xl bg-purple-100 dark:bg-purple-900/20"><BookmarkCheck className="h-6 w-6 text-purple-600" /></div>
               <div><p className="text-sm text-muted-foreground">Saved Events</p><p className="text-2xl font-bold">{savedEvents.length}</p></div>
            </CardContent>
          </Card>
          <Card>
            <CardContent className="pt-6 flex items-center gap-4">
               <div className="p-3 rounded-xl bg-green-100 dark:bg-green-900/20"><CalendarCheck className="h-6 w-6 text-green-600" /></div>
               <div><p className="text-sm text-muted-foreground">Participating</p><p className="text-2xl font-bold">{participatingEvents.length}</p></div>
            </CardContent>
          </Card>
          <Card>
            <CardContent className="pt-6 flex items-center gap-4">
               <div className="p-3 rounded-xl bg-yellow-100 dark:bg-yellow-900/20"><Trophy className="h-6 w-6 text-yellow-600" /></div>
               <div><p className="text-sm text-muted-foreground">Achievements</p><p className="text-2xl font-bold">{myAchievements.length}</p></div>
            </CardContent>
          </Card>
        </div>

        {/* ACHIEVEMENTS SECTION */}
        {myAchievements.length > 0 && (
          <motion.div initial={{ opacity: 0, y: 10 }} animate={{ opacity: 1, y: 0 }} transition={{ delay: 0.1 }}>
            <Card>
              <CardHeader>
                <div className="flex items-center justify-between">
                  <CardTitle className="flex items-center gap-2">
                    <Trophy className="h-5 w-5 text-yellow-500" />
                    My Achievements
                  </CardTitle>
                  <Button
                    variant="outline"
                    size="sm"
                    onClick={() => navigate('/achievements')}
                  >
                    View All
                  </Button>
                </div>
              </CardHeader>
              <CardContent>
                <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
                  {myAchievements.slice(0, 4).map((achievement) => (
                    <AchievementCard
                      key={achievement.id}
                      achievement={achievement}
                      unlocked={true}
                      unlockedAt={achievement.unlockedAt}
                    />
                  ))}
                </div>
                {myAchievements.length > 4 && (
                  <div className="mt-4 text-center text-sm text-muted-foreground">
                    And {myAchievements.length - 4} more achievements...
                  </div>
                )}
              </CardContent>
            </Card>
          </motion.div>
        )}

        {/* SUBSCRIPTIONS MANAGEMENT (NEW SECTION) */}
        <motion.div initial={{ opacity: 0, y: 10 }} animate={{ opacity: 1, y: 0 }} transition={{ delay: 0.2 }}>
            <Card>
                <CardHeader>
                    <CardTitle className="flex items-center gap-2">
                        <Sparkles className="h-5 w-5 text-yellow-500" />
                        Favorite Categories
                    </CardTitle>
                </CardHeader>
                <CardContent>
                    <div className="mb-4 text-sm text-muted-foreground">
                        Select the categories for which you want to receive notifications when new announcements are posted.
                    </div>
                    <div className="flex flex-wrap gap-2">
                        {availableCategories.map(cat => {
                            const isActive = mySubscriptions.includes(cat);
                            return (
                                <div 
                                    key={cat}
                                    onClick={() => toggleSubscription(cat)}
                                    className={`
                                        cursor-pointer px-4 py-2 rounded-full border text-sm font-medium transition-all flex items-center gap-2 select-none
                                        ${isActive 
                                            ? 'bg-purple-100 border-purple-500 text-purple-700 dark:bg-purple-900/40 dark:text-purple-300' 
                                            : 'bg-white border-gray-200 text-gray-600 hover:border-purple-300 dark:bg-zinc-900 dark:border-zinc-700'
                                        }
                                    `}
                                >
                                    {cat}
                                    {isActive && <Check className="h-3 w-3" />}
                                </div>
                            )
                        })}
                    </div>
                </CardContent>
            </Card>
        </motion.div>

        {/* LIST: SAVED ANNOUNCEMENTS */}
        <motion.div initial={{ opacity: 0, y: 20 }} animate={{ opacity: 1, y: 0 }} transition={{ delay: 0.3 }}>
          <Card>
            <CardHeader><CardTitle className="flex items-center gap-2"><BookmarkCheck className="h-5 w-5" /> Saved Announcements</CardTitle></CardHeader>
            <CardContent>
              {savedAnnouncements.length === 0 ? (
                <div className="text-center py-6 text-muted-foreground">No saved announcements.</div>
              ) : (
                <div className="space-y-3">
                  {savedAnnouncements.map((item) => (
                    <div key={item.id} className="p-4 rounded-lg border hover:bg-secondary/50 transition-colors">
                        <div className="flex items-center gap-2 mb-1">
                            <Badge className="bg-blue-500 text-white text-[10px]">{item.category}</Badge>
                            <span className="text-xs text-muted-foreground">{new Date(item.createdAt).toLocaleDateString()}</span>
                        </div>
                        <h4 className="font-semibold">{item.title}</h4>
                        <p className="text-sm text-muted-foreground line-clamp-1">{item.content}</p>
                    </div>
                  ))}
                </div>
              )}
            </CardContent>
          </Card>
        </motion.div>

        {/* LIST: PARTICIPATING EVENTS */}
        <motion.div initial={{ opacity: 0, y: 20 }} animate={{ opacity: 1, y: 0 }} transition={{ delay: 0.4 }}>
          <Card>
            <CardHeader><CardTitle className="flex items-center gap-2"><CalendarCheck className="h-5 w-5" /> My Events</CardTitle></CardHeader>
            <CardContent>
              {participatingEvents.length === 0 ? (
                <div className="text-center py-6 text-muted-foreground">Not participating in any events.</div>
              ) : (
                <div className="space-y-3">
                  {participatingEvents.map((evt) => (
                    <div key={evt.id} className="p-4 rounded-lg border bg-green-50/50 dark:bg-green-950/10 hover:bg-green-100/50 transition-colors flex justify-between items-center">
                        <div>
                            <div className="flex items-center gap-2 mb-1">
                                <Badge className="bg-purple-500 text-white text-[10px]">{evt.category}</Badge>
                            </div>
                            <h4 className="font-semibold">{evt.title}</h4>
                            <div className="flex items-center gap-1 text-xs text-muted-foreground mt-1">
                                <Calendar className="h-3 w-3" />
                                {new Date(evt.date).toLocaleDateString()} {new Date(evt.date).toLocaleTimeString([], {hour: '2-digit', minute:'2-digit'})}
                            </div>
                        </div>
                        <Button size="sm" variant="outline" onClick={() => navigate(`/event/${evt.id}`)}>View</Button>
                    </div>
                  ))}
                </div>
              )}
            </CardContent>
          </Card>
        </motion.div>

        {/* DANGER ZONE */}
        <motion.div initial={{ opacity: 0, y: 20 }} animate={{ opacity: 1, y: 0 }} transition={{ delay: 0.5 }}>
          <Card className="border-red-200 dark:border-red-900">
            <CardHeader>
              <CardTitle className="text-red-600 flex items-center gap-2"><Shield className="h-5 w-5" /> Danger Zone</CardTitle>
            </CardHeader>
            <CardContent>
              <p className="text-sm text-muted-foreground mb-4">Permanently delete your account and all data.</p>
              <Button onClick={handleDeleteAccount} disabled={isDeleting} className="bg-red-600 hover:bg-red-700 text-white">
                <Trash2 className="h-4 w-4 mr-2" /> {isDeleting ? 'Deleting...' : 'Delete Account'}
              </Button>
            </CardContent>
          </Card>
        </motion.div>

      </div>
    </Layout>
  );
}

export default ProfileView;