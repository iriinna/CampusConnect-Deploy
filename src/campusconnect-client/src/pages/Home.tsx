import { Link } from 'react-router-dom';
import { motion } from 'framer-motion';
import { useState, useEffect } from 'react';
import {
  Megaphone,
  Calendar,
  Users,
  CheckSquare,
  TrendingUp,
  Bell,
  Sparkles,
  ArrowRight,
  Star,
  Clock,
  BookOpen,
  Award,
} from 'lucide-react';
import { Layout } from '../components/Layout';
import { Card, CardHeader, CardTitle, CardDescription, CardContent } from '../components/ui/Card';
import { Button } from '../components/ui/Button';
import { Badge } from '../components/ui/Badge';
import { Avatar, AvatarFallback } from '../components/ui/Avatar';
import { dashboardService } from '../services/dashboardService';
import type { DashboardStats } from '../services/dashboardService';

function Home() {
  const user = JSON.parse(localStorage.getItem('user') || '{}');
  const [dashboardStats, setDashboardStats] = useState<DashboardStats | null>(null);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchStats = async () => {
      setLoading(true);
      const data = await dashboardService.getDashboardStats();
      setDashboardStats(data);
      setLoading(false);
    };
    fetchStats();
  }, []);

  const completionRate = dashboardStats && dashboardStats.totalTasks > 0
    ? Math.round((dashboardStats.tasksCompleted / dashboardStats.totalTasks) * 100)
    : 0;

  const stats = dashboardStats ? [
    {
      label: 'Active Groups',
      value: dashboardStats.activeGroups.toString(),
      change: `${dashboardStats.activeGroups} joined`,
      icon: Users,
      color: 'text-blue-500'
    },
    {
      label: 'Tasks Completed',
      value: dashboardStats.tasksCompleted.toString(),
      change: `${completionRate}% completion`,
      icon: CheckSquare,
      color: 'text-green-500'
    },
    {
      label: 'Events Joined',
      value: dashboardStats.eventsJoined.toString(),
      change: `${dashboardStats.eventsJoined} participating`,
      icon: Calendar,
      color: 'text-purple-500'
    },
    {
      label: 'Announcements',
      value: dashboardStats.totalAnnouncements.toString(),
      change: `${dashboardStats.newAnnouncementsToday} new today`,
      icon: Megaphone,
      color: 'text-orange-500'
    },
  ] : [];

  const pendingTasks = dashboardStats ? dashboardStats.totalTasks - dashboardStats.tasksCompleted : 0;

  const quickActions = [
    {
      title: 'Announcements',
      description: 'Stay updated with campus news',
      icon: Megaphone,
      link: '/announcements',
      gradient: 'from-blue-500 via-blue-600 to-cyan-500',
      badge: dashboardStats ? `${dashboardStats.newAnnouncementsToday} new` : '0 new',
    },
    {
      title: 'Events',
      description: 'Discover and join upcoming events',
      icon: Calendar,
      link: '/events',
      gradient: 'from-purple-500 via-pink-500 to-rose-500',
      badge: dashboardStats ? `${dashboardStats.eventsJoined} joined` : '0 joined',
    },
    {
      title: 'Study Groups',
      description: 'Collaborate with your peers',
      icon: Users,
      link: '/groups',
      gradient: 'from-emerald-500 via-green-500 to-teal-500',
      badge: dashboardStats ? `${dashboardStats.activeGroups} active` : '0 active',
    },
    {
      title: 'My Tasks',
      description: 'Track assignments and deadlines',
      icon: CheckSquare,
      link: '/my-tasks',
      gradient: 'from-orange-500 via-red-500 to-pink-500',
      badge: dashboardStats ? `${pendingTasks} pending` : '0 pending',
    },
  ];

  const recentActivity = [
    { title: 'New assignment posted', time: '2 hours ago', type: 'task' },
    { title: 'Upcoming event tomorrow', time: '5 hours ago', type: 'event' },
    { title: 'Group discussion updated', time: '1 day ago', type: 'group' },
  ];

  const achievements = [
    { title: 'Early Bird', description: 'Completed 5 tasks before deadline', icon: Award },
    { title: 'Team Player', description: 'Active in 3+ study groups', icon: Users },
    { title: 'Scholar', description: 'Attended 10+ academic events', icon: BookOpen },
  ];

  return (
    <Layout>
      <div className="space-y-8">
        {/* Hero Section */}
        <motion.div
          initial={{ opacity: 0, y: 20 }}
          animate={{ opacity: 1, y: 0 }}
          transition={{ duration: 0.5 }}
          className="relative overflow-hidden rounded-2xl bg-gradient-to-br from-primary via-purple-600 to-pink-600 p-8 text-white shadow-2xl"
        >
          <div className="absolute inset-0 bg-[url('data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iNjAiIGhlaWdodD0iNjAiIHZpZXdCb3g9IjAgMCA2MCA2MCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj48ZyBmaWxsPSJub25lIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiPjxwYXRoIGQ9Ik0zNiAxOGMzLjMxIDAgNiAyLjY5IDYgNnMtMi42OSA2LTYgNi02LTIuNjktNi02IDIuNjktNiA2LTZ6TTI0IDBoNnY2aC02VjB6TTAgMjRoNnY2SDB2LTZ6bTAgMGg2djZIMHYtNnoiIGZpbGw9IiNmZmYiIGZpbGwtb3BhY2l0eT0iLjA1Ii8+PC9nPjwvc3ZnPg==')] opacity-30"></div>

          <div className="relative z-10 flex items-center justify-between">
            <div>
              <motion.div
                initial={{ opacity: 0, x: -20 }}
                animate={{ opacity: 1, x: 0 }}
                transition={{ delay: 0.2 }}
                className="flex items-center space-x-3 mb-4"
              >
                <Avatar className="h-16 w-16 border-4 border-white/20">
                  <AvatarFallback className="text-2xl font-bold bg-white/10 text-white">
                    {user.firstName?.[0]}{user.lastName?.[0]}
                  </AvatarFallback>
                </Avatar>
                <div>
                  <h1 className="text-4xl font-bold flex items-center gap-2">
                    Welcome back, {user.firstName}!
                    <Sparkles className="h-8 w-8 text-yellow-300" />
                  </h1>
                  <p className="text-white/80 text-lg mt-1">{user.email}</p>
                </div>
              </motion.div>
              <motion.p
                initial={{ opacity: 0 }}
                animate={{ opacity: 1 }}
                transition={{ delay: 0.4 }}
                className="text-white/90 text-lg max-w-2xl"
              >
                You're making great progress! Keep up the momentum and achieve your academic goals.
              </motion.p>
            </div>

            <motion.div
              initial={{ scale: 0 }}
              animate={{ scale: 1 }}
              transition={{ delay: 0.3, type: 'spring' }}
              className="hidden lg:block"
            >
              <div className="relative">
                <div className="absolute inset-0 bg-white/20 blur-3xl rounded-full"></div>
                <TrendingUp className="relative h-32 w-32 text-white/80" />
              </div>
            </motion.div>
          </div>
        </motion.div>

        {/* Stats Grid */}
        <motion.div
          initial={{ opacity: 0, y: 20 }}
          animate={{ opacity: 1, y: 0 }}
          transition={{ delay: 0.2 }}
          className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-6"
        >
          {stats.map((stat, index) => {
            const Icon = stat.icon;
            return (
              <motion.div
                key={stat.label}
                initial={{ opacity: 0, y: 20 }}
                animate={{ opacity: 1, y: 0 }}
                transition={{ delay: 0.1 * index }}
                whileHover={{ y: -5 }}
              >
                <Card className="relative overflow-hidden border-2 hover:border-primary/50 transition-all">
                  <div className="absolute top-0 right-0 w-32 h-32 bg-gradient-to-br from-primary/10 to-transparent rounded-full -mr-16 -mt-16"></div>
                  <CardContent className="pt-6">
                    <div className="flex items-start justify-between mb-4">
                      <div className={`p-3 rounded-xl bg-gradient-to-br ${stat.color} bg-opacity-10`}>
                        <Icon className={`h-6 w-6 ${stat.color}`} />
                      </div>
                      <Badge variant="secondary" className="text-xs">
                        {stat.change}
                      </Badge>
                    </div>
                    <div>
                      <p className="text-3xl font-bold">{stat.value}</p>
                      <p className="text-sm text-muted-foreground mt-1">{stat.label}</p>
                    </div>
                  </CardContent>
                </Card>
              </motion.div>
            );
          })}
        </motion.div>

        {/* Quick Actions - Bento Grid */}
        <div>
          <div className="flex items-center justify-between mb-6">
            <h2 className="text-3xl font-bold">Quick Actions</h2>
            <Button variant="ghost" className="group">
              View All
              <ArrowRight className="ml-2 h-4 w-4 group-hover:translate-x-1 transition-transform" />
            </Button>
          </div>

          <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-6">
            {quickActions.map((action, index) => {
              const Icon = action.icon;
              return (
                <motion.div
                  key={action.title}
                  initial={{ opacity: 0, scale: 0.9 }}
                  animate={{ opacity: 1, scale: 1 }}
                  transition={{ delay: 0.1 * index }}
                  whileHover={{ scale: 1.05 }}
                  whileTap={{ scale: 0.95 }}
                >
                  <Link to={action.link}>
                    <Card className="group relative overflow-hidden border-2 hover:border-primary/50 transition-all h-full cursor-pointer">
                      <div className={`absolute inset-0 bg-gradient-to-br ${action.gradient} opacity-0 group-hover:opacity-10 transition-opacity`}></div>

                      <CardHeader className="relative">
                        <div className="flex items-start justify-between mb-3">
                          <div className={`p-4 rounded-2xl bg-gradient-to-br ${action.gradient} shadow-lg group-hover:shadow-xl transition-shadow`}>
                            <Icon className="h-7 w-7 text-white" />
                          </div>
                          {action.badge && (
                            <Badge className="bg-primary/10 text-primary border border-primary/20">
                              {action.badge}
                            </Badge>
                          )}
                        </div>
                        <CardTitle className="text-xl group-hover:text-primary transition-colors">
                          {action.title}
                        </CardTitle>
                        <CardDescription className="text-sm">
                          {action.description}
                        </CardDescription>
                      </CardHeader>
                    </Card>
                  </Link>
                </motion.div>
              );
            })}
          </div>
        </div>

        {/* Bottom Grid - Activity & Achievements */}
        <div className="grid grid-cols-1 lg:grid-cols-3 gap-6">
          {/* Recent Activity */}
          <motion.div
            initial={{ opacity: 0, x: -20 }}
            animate={{ opacity: 1, x: 0 }}
            transition={{ delay: 0.4 }}
            className="lg:col-span-2"
          >
            <Card className="h-full">
              <CardHeader>
                <div className="flex items-center justify-between">
                  <CardTitle className="flex items-center gap-2">
                    <Clock className="h-5 w-5" />
                    Recent Activity
                  </CardTitle>
                  <Button variant="ghost" size="sm">
                    <Bell className="h-4 w-4" />
                  </Button>
                </div>
              </CardHeader>
              <CardContent>
                <div className="space-y-4">
                  {recentActivity.map((activity, index) => (
                    <motion.div
                      key={index}
                      initial={{ opacity: 0, x: -10 }}
                      animate={{ opacity: 1, x: 0 }}
                      transition={{ delay: 0.5 + index * 0.1 }}
                      className="flex items-start space-x-4 p-4 rounded-lg hover:bg-secondary/50 transition-colors cursor-pointer"
                    >
                      <div className="p-2 rounded-lg bg-primary/10">
                        {activity.type === 'task' && <CheckSquare className="h-5 w-5 text-primary" />}
                        {activity.type === 'event' && <Calendar className="h-5 w-5 text-primary" />}
                        {activity.type === 'group' && <Users className="h-5 w-5 text-primary" />}
                      </div>
                      <div className="flex-1">
                        <p className="font-medium">{activity.title}</p>
                        <p className="text-sm text-muted-foreground">{activity.time}</p>
                      </div>
                      <ArrowRight className="h-4 w-4 text-muted-foreground" />
                    </motion.div>
                  ))}
                </div>
              </CardContent>
            </Card>
          </motion.div>

          {/* Achievements */}
          <motion.div
            initial={{ opacity: 0, x: 20 }}
            animate={{ opacity: 1, x: 0 }}
            transition={{ delay: 0.5 }}
          >
            <Card className="h-full bg-gradient-to-br from-yellow-50 to-orange-50 dark:from-yellow-950/20 dark:to-orange-950/20 border-yellow-200 dark:border-yellow-800">
              <CardHeader>
                <CardTitle className="flex items-center gap-2 text-yellow-700 dark:text-yellow-400">
                  <Star className="h-5 w-5 fill-current" />
                  Achievements
                </CardTitle>
              </CardHeader>
              <CardContent>
                <div className="space-y-4">
                  {achievements.map((achievement, index) => {
                    const Icon = achievement.icon;
                    return (
                      <motion.div
                        key={index}
                        initial={{ opacity: 0, scale: 0.8 }}
                        animate={{ opacity: 1, scale: 1 }}
                        transition={{ delay: 0.6 + index * 0.1 }}
                        className="p-3 rounded-lg bg-white/50 dark:bg-black/20 border border-yellow-200 dark:border-yellow-800"
                      >
                        <div className="flex items-start gap-3">
                          <div className="p-2 rounded-lg bg-yellow-100 dark:bg-yellow-900/50">
                            <Icon className="h-4 w-4 text-yellow-600 dark:text-yellow-400" />
                          </div>
                          <div className="flex-1">
                            <p className="font-semibold text-sm">{achievement.title}</p>
                            <p className="text-xs text-muted-foreground">{achievement.description}</p>
                          </div>
                        </div>
                      </motion.div>
                    );
                  })}
                </div>
              </CardContent>
            </Card>
          </motion.div>
        </div>
      </div>
    </Layout>
  );
}

export default Home;
