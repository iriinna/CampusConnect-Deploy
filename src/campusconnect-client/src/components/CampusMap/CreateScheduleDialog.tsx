import { useState, useEffect } from 'react';
import { Calendar, Clock, AlertCircle, Info } from 'lucide-react';
import {
  Dialog,
  DialogContent,
  DialogDescription,
  DialogFooter,
  DialogHeader,
  DialogTitle,
} from '../ui/Dialog';
import { Label } from '../ui/Label';
import { Input } from '../ui/Input';
import { Textarea } from '../ui/Textarea';
import { Select } from '../ui/Select';
import { Button } from '../ui/Button';
import { campusMapApi } from '../../services/campusMapApi';
import type { Building, Room, CreateScheduleRequest, CreateReservationRequest } from '../../services/campusMapApi';

interface CreateScheduleDialogProps {
  open: boolean;
  onOpenChange: (open: boolean) => void;
  onScheduleCreated?: () => void;
  preselectedBuildingId?: number;
  preselectedRoomId?: number;
}

export function CreateScheduleDialog({
  open,
  onOpenChange,
  onScheduleCreated,
  preselectedBuildingId,
  preselectedRoomId,
}: CreateScheduleDialogProps) {
  const [buildings, setBuildings] = useState<Building[]>([]);
  const [rooms, setRooms] = useState<Room[]>([]);
  const [selectedBuildingId, setSelectedBuildingId] = useState<number | undefined>(preselectedBuildingId);
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [success, setSuccess] = useState<string | null>(null);

  // Get user role
  const user = JSON.parse(localStorage.getItem('user') || '{}');
  const isAdminOrProfessor = user.role === 'Admin' || user.role === 'Professor';

  const [formData, setFormData] = useState<Omit<CreateScheduleRequest, 'roomId'> & { roomId: number | '' }>({
    title: '',
    description: '',
    roomId: preselectedRoomId || '',
    startTime: '',
    endTime: '',
    recurrencePattern: '',
    recurrenceEndDate: '',
  });

  const [scheduleDate, setScheduleDate] = useState('');
  const [startTimeOnly, setStartTimeOnly] = useState('');
  const [endTimeOnly, setEndTimeOnly] = useState('');

  useEffect(() => {
    if (open) {
      loadBuildings();
      if (preselectedBuildingId) {
        loadRooms(preselectedBuildingId);
      }
    }
  }, [open, preselectedBuildingId]);

  useEffect(() => {
    if (selectedBuildingId) {
      loadRooms(selectedBuildingId);
    } else {
      setRooms([]);
    }
  }, [selectedBuildingId]);

  const loadBuildings = async () => {
    try {
      const data = await campusMapApi.getAllBuildings();
      setBuildings(data);
    } catch (error) {
      console.error('Error loading buildings:', error);
      setError('Nu s-au putut încărca clădirile');
    }
  };

  const loadRooms = async (buildingId: number) => {
    try {
      const data = await campusMapApi.getRoomsByBuilding(buildingId);
      setRooms(data);
    } catch (error) {
      console.error('Error loading rooms:', error);
      setError('Nu s-au putut încărca sălile');
    }
  };

  // Validate time is between 8 AM and 8 PM
  const validateTime = (startTime: string, endTime: string): string | null => {
    if (!startTime || !endTime) return null;

    const [startHour] = startTime.split(':').map(Number);
    const [endHour, endMin] = endTime.split(':').map(Number);

    if (startHour < 8) {
      return 'Ora de început trebuie să fie după 08:00';
    }
    if (endHour > 20 || (endHour === 20 && endMin > 0)) {
      return 'Ora de sfârșit trebuie să fie înainte de 20:00';
    }
    if (startTime >= endTime) {
      return 'Ora de sfârșit trebuie să fie după ora de început';
    }
    return null;
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setError(null);
    setSuccess(null);

    if (!formData.roomId) {
      setError('Selectați o sală');
      return;
    }

    if (!formData.title || !scheduleDate || !startTimeOnly || !endTimeOnly) {
      setError('Completați toate câmpurile obligatorii');
      return;
    }

    // Validate time constraints
    const timeError = validateTime(startTimeOnly, endTimeOnly);
    if (timeError) {
      setError(timeError);
      return;
    }

    setIsLoading(true);

    try {
      // Combine date with time to create DateTime
      const startDateTime = new Date(`${scheduleDate}T${startTimeOnly}`);
      const endDateTime = new Date(`${scheduleDate}T${endTimeOnly}`);

      if (isAdminOrProfessor) {
        // Admin/Professor: Create schedule directly
        const request: CreateScheduleRequest = {
          title: formData.title,
          description: formData.description || undefined,
          roomId: formData.roomId as number,
          startTime: startDateTime.toISOString(),
          endTime: endDateTime.toISOString(),
          recurrencePattern: formData.recurrencePattern || undefined,
          recurrenceEndDate: formData.recurrenceEndDate ? new Date(formData.recurrenceEndDate).toISOString() : undefined,
        };

        await campusMapApi.createSchedule(request);
        setSuccess('Program creat cu succes!');
      } else {
        // Regular user: Create reservation request
        const request: CreateReservationRequest = {
          title: formData.title,
          description: formData.description || undefined,
          roomId: formData.roomId as number,
          startTime: startDateTime.toISOString(),
          endTime: endDateTime.toISOString(),
        };

        await campusMapApi.createReservation(request);
        setSuccess('Cererea de rezervare a fost trimisă! Veți primi o notificare când va fi procesată.');
      }

      // Reset form after short delay to show success message
      setTimeout(() => {
        setFormData({
          title: '',
          description: '',
          roomId: preselectedRoomId || '',
          startTime: '',
          endTime: '',
          recurrencePattern: '',
          recurrenceEndDate: '',
        });
        setScheduleDate('');
        setStartTimeOnly('');
        setEndTimeOnly('');
        setSuccess(null);

        onScheduleCreated?.();
        onOpenChange(false);
      }, 1500);
    } catch (error: any) {
      console.error('Error creating schedule/reservation:', error);
      setError(error.message || 'Eroare la creare');
    } finally {
      setIsLoading(false);
    }
  };

  const handleClose = () => {
    setError(null);
    setSuccess(null);
    setFormData({
      title: '',
      description: '',
      roomId: preselectedRoomId || '',
      startTime: '',
      endTime: '',
      recurrencePattern: '',
      recurrenceEndDate: '',
    });
    setScheduleDate('');
    setStartTimeOnly('');
    setEndTimeOnly('');
    onOpenChange(false);
  };

  return (
    <Dialog open={open} onOpenChange={onOpenChange}>
      <DialogContent onClose={handleClose} className="max-h-[90vh] overflow-y-auto">
        <form onSubmit={handleSubmit}>
          <DialogHeader>
            <DialogTitle className="flex items-center gap-2">
              <Calendar className="h-5 w-5" />
              {isAdminOrProfessor ? 'Adaugă program nou' : 'Solicită rezervare sală'}
            </DialogTitle>
            <DialogDescription>
              {isAdminOrProfessor
                ? 'Creați un program pentru o sală din campus'
                : 'Trimiteți o cerere de rezervare care va fi procesată de un administrator'
              }
            </DialogDescription>
          </DialogHeader>

          <div className="space-y-4 p-6">
            {/* Info box for time restrictions */}
            <div className="rounded-md bg-blue-50 dark:bg-blue-950/20 p-3 text-sm text-blue-700 dark:text-blue-300 flex items-start gap-2">
              <Info className="h-4 w-4 mt-0.5 flex-shrink-0" />
              <span>Rezervările pot fi făcute doar între orele 08:00 și 20:00.</span>
            </div>

            {/* Info box for regular users */}
            {!isAdminOrProfessor && (
              <div className="rounded-md bg-amber-50 dark:bg-amber-950/20 p-3 text-sm text-amber-700 dark:text-amber-300 flex items-start gap-2">
                <AlertCircle className="h-4 w-4 mt-0.5 flex-shrink-0" />
                <span>Cererea dvs. va fi trimisă unui administrator pentru aprobare. Veți fi notificat când cererea este procesată.</span>
              </div>
            )}

            {error && (
              <div className="rounded-md bg-destructive/10 p-3 text-sm text-destructive">
                {error}
              </div>
            )}

            {success && (
              <div className="rounded-md bg-green-100 dark:bg-green-900/20 p-3 text-sm text-green-700 dark:text-green-300">
                {success}
              </div>
            )}

            <div className="space-y-2">
              <Label htmlFor="title">Titlu *</Label>
              <Input
                id="title"
                placeholder="ex: Întâlnire proiect, Sesiune studiu..."
                value={formData.title}
                onChange={(e) => setFormData({ ...formData, title: e.target.value })}
                required
              />
            </div>

            <div className="space-y-2">
              <Label htmlFor="description">Descriere</Label>
              <Textarea
                id="description"
                placeholder="Detalii suplimentare despre eveniment..."
                value={formData.description}
                onChange={(e) => setFormData({ ...formData, description: e.target.value })}
                rows={3}
              />
            </div>

            <div className="grid grid-cols-2 gap-4">
              <div className="space-y-2">
                <Label htmlFor="building">Clădire *</Label>
                <Select
                  id="building"
                  value={selectedBuildingId || ''}
                  onChange={(e) => {
                    const buildingId = e.target.value ? Number(e.target.value) : undefined;
                    setSelectedBuildingId(buildingId);
                    setFormData({ ...formData, roomId: '' });
                  }}
                  disabled={!!preselectedBuildingId}
                  required
                >
                  <option value="">Selectează clădirea</option>
                  {buildings.map((building) => (
                    <option key={building.id} value={building.id}>
                      {building.name}
                    </option>
                  ))}
                </Select>
              </div>

              <div className="space-y-2">
                <Label htmlFor="room">Sală *</Label>
                <Select
                  id="room"
                  value={formData.roomId}
                  onChange={(e) => setFormData({ ...formData, roomId: e.target.value ? Number(e.target.value) : '' })}
                  disabled={!selectedBuildingId || !!preselectedRoomId}
                  required
                >
                  <option value="">Selectează sala</option>
                  {rooms.map((room) => (
                    <option key={room.id} value={room.id}>
                      {room.name} {room.capacity ? `(${room.capacity} locuri)` : ''}
                    </option>
                  ))}
                </Select>
              </div>
            </div>

            <div className="space-y-2">
              <Label htmlFor="scheduleDate" className="flex items-center gap-1">
                <Calendar className="h-3 w-3" />
                Data *
              </Label>
              <Input
                id="scheduleDate"
                type="date"
                value={scheduleDate}
                onChange={(e) => setScheduleDate(e.target.value)}
                min={new Date().toISOString().split('T')[0]}
                required
              />
            </div>

            <div className="grid grid-cols-2 gap-4">
              <div className="space-y-2">
                <Label htmlFor="startTime" className="flex items-center gap-1">
                  <Clock className="h-3 w-3" />
                  Ora început * (08:00 - 20:00)
                </Label>
                <Input
                  id="startTime"
                  type="time"
                  value={startTimeOnly}
                  onChange={(e) => setStartTimeOnly(e.target.value)}
                  min="08:00"
                  max="19:59"
                  required
                />
              </div>

              <div className="space-y-2">
                <Label htmlFor="endTime" className="flex items-center gap-1">
                  <Clock className="h-3 w-3" />
                  Ora sfârșit * (08:00 - 20:00)
                </Label>
                <Input
                  id="endTime"
                  type="time"
                  value={endTimeOnly}
                  onChange={(e) => setEndTimeOnly(e.target.value)}
                  min="08:01"
                  max="20:00"
                  required
                />
              </div>
            </div>

            {/* Only show recurrence options for Admin/Professor */}
            {isAdminOrProfessor && (
              <>
                <div className="space-y-2">
                  <Label htmlFor="recurrencePattern">Recurență</Label>
                  <Select
                    id="recurrencePattern"
                    value={formData.recurrencePattern}
                    onChange={(e) => setFormData({ ...formData, recurrencePattern: e.target.value })}
                  >
                    <option value="">Fără recurență</option>
                    <option value="Daily">Zilnic</option>
                    <option value="Weekly">Săptămânal</option>
                    <option value="BiWeekly">La 2 săptămâni</option>
                    <option value="Monthly">Lunar</option>
                  </Select>
                </div>

                {formData.recurrencePattern && (
                  <div className="space-y-2">
                    <Label htmlFor="recurrenceEndDate">Data sfârșit recurență</Label>
                    <Input
                      id="recurrenceEndDate"
                      type="date"
                      value={formData.recurrenceEndDate}
                      onChange={(e) => setFormData({ ...formData, recurrenceEndDate: e.target.value })}
                      min={scheduleDate}
                    />
                  </div>
                )}
              </>
            )}
          </div>

          <DialogFooter>
            <Button
              type="button"
              variant="outline"
              onClick={handleClose}
              disabled={isLoading}
            >
              Anulează
            </Button>
            <Button type="submit" disabled={isLoading || !!success}>
              {isLoading
                ? 'Se procesează...'
                : isAdminOrProfessor
                  ? 'Creează program'
                  : 'Trimite cererea'
              }
            </Button>
          </DialogFooter>
        </form>
      </DialogContent>
    </Dialog>
  );
}
