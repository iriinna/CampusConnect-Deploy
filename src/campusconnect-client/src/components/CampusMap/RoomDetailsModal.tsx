import { useState, useEffect } from 'react';
import { motion } from 'framer-motion';
import { X, Clock, User, CalendarPlus } from 'lucide-react';
import { Card, CardHeader, CardTitle, CardContent } from '../ui/Card';
import { Button } from '../ui/Button';
import { Badge } from '../ui/Badge';
import { campusMapApi } from '../../services/campusMapApi';
import type { RoomDetails, Schedule } from '../../services/campusMapApi';
import { RequestBookingDialog } from './RequestBookingDialog';

interface Props {
  roomId: number;
  onClose: () => void;
}

export const RoomDetailsModal = ({ roomId, onClose }: Props) => {
  const [room, setRoom] = useState<RoomDetails | null>(null);
  const [loading, setLoading] = useState(true);
  const [selectedDate, setSelectedDate] = useState<Date>(new Date());
  const [showRequestDialog, setShowRequestDialog] = useState(false);

  const getUserRole = () => {
    const userStr = localStorage.getItem('user');
    if (!userStr) return null;
    try {
      const user = JSON.parse(userStr);
      return user.role;
    } catch {
      return null;
    }
  };
  const userRole = getUserRole();

  useEffect(() => {
    loadRoomDetails();
  }, [roomId]);

  const loadRoomDetails = async () => {
    try {
      const data = await campusMapApi.getRoomDetails(roomId);
      setRoom(data);
    } catch (error) {
      console.error('Error loading room details:', error);
    } finally {
      setLoading(false);
    }
  };

  const loadSchedulesForDate = async (date: Date | string) => {
    if (!room) return;
    try {
      console.log('Loading schedules for date:', typeof date === 'string' ? date : date.toISOString());
      const schedules = await campusMapApi.getRoomSchedules(roomId, date);
      console.log('Loaded schedules:', schedules);
      console.log('Number of schedules:', schedules.length);
      schedules.forEach(s => {
        console.log(`- ${s.title} (ID: ${s.id}, ${new Date(s.startTime).toLocaleString()} - ${new Date(s.endTime).toLocaleString()})`);
      });
      setRoom({ ...room, todaySchedules: schedules });
    } catch (error) {
      console.error('Error loading schedules:', error);
    }
  };

  const getStatusColor = (status: string) => {
    switch (status) {
      case 'Free': return 'bg-green-500 text-white';
      case 'Occupied': return 'bg-red-500 text-white';
      case 'OccupiedSoon': return 'bg-yellow-500 text-white';
      default: return 'bg-gray-500 text-white';
    }
  };

  const getStatusText = (status: string) => {
    switch (status) {
      case 'Free': return 'Liber';
      case 'Occupied': return 'Ocupat';
      case 'OccupiedSoon': return 'Ocupat în <30min';
      default: return 'Necunoscut';
    }
  };

  return (
    <div className="fixed inset-0 z-50 flex items-center justify-center bg-black/50 p-4">
      <motion.div
        initial={{ opacity: 0, scale: 0.95 }}
        animate={{ opacity: 1, scale: 1 }}
        exit={{ opacity: 0, scale: 0.95 }}
        className="w-full max-w-2xl max-h-[90vh] overflow-y-auto"
      >
        <Card>
          <CardHeader>
            <div className="flex items-start justify-between">
              <div>
                <CardTitle className="text-2xl">{room?.name}</CardTitle>
                <p className="text-sm text-muted-foreground mt-1">{room?.buildingName}</p>
              </div>
              <Button variant="ghost" size="icon" onClick={onClose}>
                <X className="h-5 w-5" />
              </Button>
            </div>
          </CardHeader>

          <CardContent>
            {loading ? (
              <div className="text-center py-8">Loading...</div>
            ) : room ? (
              <div className="space-y-6">
                {/* Room Info */}
                <div className="grid grid-cols-2 gap-4">
                  {room.capacity && (
                    <div>
                      <span className="text-sm text-muted-foreground">Capacity</span>
                      <p className="font-semibold">{room.capacity} seats</p>
                    </div>
                  )}
                  {room.floor && (
                    <div>
                      <span className="text-sm text-muted-foreground">Floor</span>
                      <p className="font-semibold">{room.floor}</p>
                    </div>
                  )}
                </div>

                {room.equipment && (
                  <div>
                    <span className="text-sm text-muted-foreground">Equipment</span>
                    <p className="text-sm mt-1">{room.equipment}</p>
                  </div>
                )}

                {/* Status Badge */}
                <div className="flex items-center justify-between">
                  <div className="flex items-center gap-2">
                    <span className="text-sm text-muted-foreground">Current Status:</span>
                    <Badge className={getStatusColor(room.currentStatus)}>
                      {getStatusText(room.currentStatus)}
                    </Badge>
                  </div>

                  {/* Request Booking Button - Only for Users */}
                  {userRole === 'User' && (
                    <Button
                      onClick={() => setShowRequestDialog(true)}
                      className="gap-2"
                      size="sm"
                    >
                      <CalendarPlus className="h-4 w-4" />
                      Request Reservation
                    </Button>
                  )}
                </div>

                {/* Today's Schedule */}
                <div>
                  <h3 className="font-semibold mb-3">
                    {selectedDate.toDateString() !== new Date().toDateString()
                      ? `Program pentru ${selectedDate.getDate()} ${new Intl.DateTimeFormat('ro-RO', { month: 'long' }).format(selectedDate)} ${selectedDate.getFullYear()}`
                      : 'Programul de Astăzi'}
                  </h3>
                  {room.todaySchedules.length === 0 ? (
                    <p className="text-sm text-muted-foreground text-center py-4">
                        No schedule ativities for this date.
                    </p>
                  ) : (
                    <div className="space-y-2">
                      {room.todaySchedules.map((schedule) => (
                        <ScheduleItem key={schedule.id} schedule={schedule} />
                      ))}
                    </div>
                  )}
                </div>

                {/* Date Selector - Available for everyone */}
                <div>
                  <h3 className="font-semibold mb-3">View Schedule for Another Date</h3>
                  <input
                    type="date"
                    value={`${selectedDate.getFullYear()}-${String(selectedDate.getMonth() + 1).padStart(2, '0')}-${String(selectedDate.getDate()).padStart(2, '0')}`}
                    onChange={(e) => {
                      const dateString = e.target.value; // YYYY-MM-DD format
                      const date = new Date(dateString + 'T00:00:00');
                      setSelectedDate(date);
                      loadSchedulesForDate(dateString); // Pass string directly to avoid timezone conversion
                    }}
                    className="w-full px-3 py-2 border border-input rounded-md bg-background"
                  />
                </div>
              </div>
            ) : (
              <p className="text-center text-muted-foreground">Room not found</p>
            )}
          </CardContent>
        </Card>
      </motion.div>

      {/* Request Booking Dialog */}
      {showRequestDialog && room && (
        <RequestBookingDialog
          roomId={roomId}
          roomName={room.name}
          buildingName={room.buildingName}
          onClose={() => setShowRequestDialog(false)}
          onSuccess={() => {
            setShowRequestDialog(false);
            loadRoomDetails();
          }}
        />
      )}
    </div>
  );
};

const ScheduleItem = ({ schedule }: { schedule: Schedule }) => (
  <div className={`p-3 rounded-lg border-2 ${
    schedule.isCurrentlyActive ? 'border-primary bg-primary/10' : 'border-border'
  }`}>
    <div className="flex items-start justify-between">
      <div className="flex-1">
        <h4 className="font-semibold text-sm">{schedule.title}</h4>
        {schedule.description && (
          <p className="text-xs text-muted-foreground mt-1">{schedule.description}</p>
        )}
        <div className="flex items-center gap-4 mt-2 text-xs text-muted-foreground">
          <span className="flex items-center gap-1">
            <Clock className="h-3 w-3" />
            {new Date(schedule.startTime).toLocaleTimeString('ro-RO', { hour: '2-digit', minute: '2-digit' })}
            {' - '}
            {new Date(schedule.endTime).toLocaleTimeString('ro-RO', { hour: '2-digit', minute: '2-digit' })}
          </span>
          <span className="flex items-center gap-1">
            <User className="h-3 w-3" />
            {schedule.professorName}
          </span>
        </div>
      </div>
      {schedule.isCurrentlyActive && (
        <Badge className="bg-green-500 text-white text-xs">In Progress</Badge>
      )}
    </div>
  </div>
);
