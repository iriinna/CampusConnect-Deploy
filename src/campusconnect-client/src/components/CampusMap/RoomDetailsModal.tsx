import { useEffect, useState } from 'react';
import { motion } from 'framer-motion';
import { X, Clock, User, CalendarPlus } from 'lucide-react';
import { Card, CardHeader, CardTitle, CardContent } from '../ui/Card';
import { Button } from '../ui/Button';
import { Badge } from '../ui/Badge';
import { campusMapApi } from '../../services/campusMapApi';
import type { RoomDetails, Schedule } from '../../services/campusMapApi';
import { RequestBookingDialog } from './RequestBookingDialog';

// ✅ path corect (RoomDetailsModal.tsx e în src/components/CampusMap/)
import { FloorPlanViewer } from './FloorPlans/FloorPlanViewer';
import { FMI_PARTER } from '../../data/floorplans/fmi/parter';
import { FMI_ETAJ1 } from "../../data/floorplans/fmi/etaj1";
import { FMI_ETAJ2 } from "../../data/floorplans/fmi/etaj2";
import { FMI_ETAJ3 } from "../../data/floorplans/fmi/etaj3";
import { FAA_ETAJ1 } from "../../data/floorplans/faa/etaj1";
import { FAA_ETAJ2 } from "../../data/floorplans/faa/etaj2";
import { BIO_PARTER } from "../../data/floorplans/biologie/parter";
import { BIO_ETAJ1 } from "../../data/floorplans/biologie/etaj1";
import { BIO_ETAJ2 } from "../../data/floorplans/biologie/etaj2";
import { CHIMIE_PARTER } from "../../data/floorplans/chimie/parter";
import { CHIMIE_ETAJ1 } from "../../data/floorplans/chimie/etaj1";
import { CHIMIE_ETAJ2 } from "../../data/floorplans/chimie/etaj2";
import { DREPT_PARTER } from "../../data/floorplans/drept/parter";
import { DREPT_ETAJ1 } from "../../data/floorplans/drept/etaj1";
import { DREPT_ETAJ2 } from "../../data/floorplans/drept/etaj2";
// Filosofie (BuildingId=5)
import { FILO_PARTER } from "../../data/floorplans/filosofie/parter";
import { FILO_ETAJ1 } from "../../data/floorplans/filosofie/etaj1";
import { FILO_ETAJ2 } from "../../data/floorplans/filosofie/etaj2";
// Fizică (BuildingId=6)
import { FIZ_PARTER } from "../../data/floorplans/fizica/parter";
import { FIZ_ETAJ1 } from "../../data/floorplans/fizica/etaj1";
import { FIZ_ETAJ2 } from "../../data/floorplans/fizica/etaj2";
// Geografie (BuildingId=7)
import { GEO_PARTER } from "../../data/floorplans/geografie/parter";
import { GEO_ETAJ1 } from "../../data/floorplans/geografie/etaj1";
import { GEO_ETAJ2 } from "../../data/floorplans/geografie/etaj2";
// Geologie și Geofizică (BuildingId=8)
import { GG_PARTER } from "../../data/floorplans/geologie/parter";
import { GG_ETAJ1 } from "../../data/floorplans/geologie/etaj1";
import { GG_ETAJ2 } from "../../data/floorplans/geologie/etaj2";
// Istorie (BuildingId=9)
import { IST_PARTER } from "../../data/floorplans/istorie/parter";
import { IST_ETAJ1 } from "../../data/floorplans/istorie/etaj1";
import { IST_ETAJ2 } from "../../data/floorplans/istorie/etaj2";
// Jurnalism (BuildingId=10)
import { JURNALISM_ETAJ6 } from "../../data/floorplans/jurnalism/etaj6";
import { JURNALISM_ETAJ7 } from "../../data/floorplans/jurnalism/etaj7";
// FLLS (BuildingId=11)
import { FLLS_PARTER } from "../../data/floorplans/flls/parter";
import { FLLS_ETAJ1 } from "../../data/floorplans/flls/etaj1";
import { FLLS_ETAJ2 } from "../../data/floorplans/flls/etaj2";
// Litere (BuildingId=12)
import { LIT_PARTER } from "../../data/floorplans/litere/parter";
import { LIT_ETAJ1 } from "../../data/floorplans/litere/etaj1";
import { LIT_ETAJ2 } from "../../data/floorplans/litere/etaj2";
// Psihologie (BuildingId=14)
import { PSI_PARTER } from "../../data/floorplans/psihologie/parter";
import { PSI_ETAJ1 } from "../../data/floorplans/psihologie/etaj1";
import { PSI_ETAJ2 } from "../../data/floorplans/psihologie/etaj2";
// Sociologie (BuildingId=15)
import { SAS_PARTER } from "../../data/floorplans/sociologie/parter";
import { SAS_ETAJ1 } from "../../data/floorplans/sociologie/etaj1";
import { SAS_ETAJ2 } from "../../data/floorplans/sociologie/etaj2";
// Științe Politice (BuildingId=16)
import { FSP_PARTER } from "../../data/floorplans/fsp/parter";
import { FSP_ETAJ1 } from "../../data/floorplans/fsp/etaj1";
import { FSP_ETAJ2 } from "../../data/floorplans/fsp/etaj2";






type SimpleRoom = { name: string; currentStatus: string };

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

  // ✅ rooms din clădire, pentru colorare în schiță
  const [buildingRooms, setBuildingRooms] = useState<SimpleRoom[]>([]);
  const [loadingBuildingRooms, setLoadingBuildingRooms] = useState(false);

  useEffect(() => {
    loadRoomDetails();
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, [roomId]);

  // ✅ când avem room, încărcăm rooms din aceeași clădire
  useEffect(() => {
    if (!room) return;

    const loadBuildingRooms = async () => {
      // dacă nu ai buildingId în RoomDetails, vezi fallback-ul de mai jos
      const buildingId = (room as any).buildingId as number | undefined;
      if (!buildingId) return;

      try {
        setLoadingBuildingRooms(true);
        const data = await campusMapApi.getRoomsByBuilding(buildingId);

        // data are probabil tip Room[] cu name + currentStatus
        setBuildingRooms(
          data.map((r: any) => ({ name: r.name, currentStatus: r.currentStatus }))
        );
      } catch (e) {
        console.error('Error loading building rooms:', e);
        setBuildingRooms([]);
      } finally {
        setLoadingBuildingRooms(false);
      }
    };

    loadBuildingRooms();
  }, [room]);

  const loadRoomDetails = async () => {
    try {
      setLoading(true);
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
      const schedules = await campusMapApi.getRoomSchedules(roomId, date);
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

  // ✅ afișează schița doar pentru FMI (BuildingId 13) + Parter
  const buildingId = (room as any)?.buildingId as number | undefined;
  const showFmiParterPlan = !!room && buildingId === 13 && room.floor === 'Parter';

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

                {room.floor === "Etaj 1" && buildingId === 1 && (
                  <FloorPlanViewer
                    config={FAA_ETAJ1}
                    rooms={buildingRooms}
                    selectedRoomName={room.name}
                  />
                )}
                {room.floor === "Etaj 2" && buildingId === 1 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (FAA – Etaj 2)</h3>

                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer
                        config={FAA_ETAJ2}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    </div>

                    <p className="text-xs text-muted-foreground">
                      Sala selectată e evidențiată cu mov.
                    </p>
                  </div>
                )}

                {room.floor === "Parter" && buildingId === 2 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Biologie – Parter)</h3>

                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer
                        config={BIO_PARTER}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    </div>

                    <p className="text-xs text-muted-foreground">
                      Sala selectată este evidențiată cu mov.
                    </p>
                  </div>
                )}

                {room.floor === "Etaj 1" && buildingId === 2 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Biologie – Etaj 1)</h3>

                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer
                        config={BIO_ETAJ1}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    </div>

                  </div>
                )}

                {room.floor === "Etaj 2" && buildingId === 2 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Biologie – Etaj 2)</h3>

                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer
                        config={BIO_ETAJ2}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    </div>

                  </div>
                )}

                {room.floor === "Parter" && buildingId === 3 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Chimie - Parter)</h3>

                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer
                        config={CHIMIE_PARTER}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    </div>

                    <p className="text-xs text-muted-foreground">
                      Sala selectată este evidențiată cu mov.
                    </p>
                  </div>
                )}

                {room.floor === "Etaj 1" && buildingId === 3 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Chimie – Etaj 1)</h3>

                    <FloorPlanViewer
                      config={CHIMIE_ETAJ1}
                      rooms={buildingRooms}
                      selectedRoomName={room.name}
                    />

                    <p className="text-xs text-muted-foreground">
                      Sala selectată este evidențiată pe plan.
                    </p>
                  </div>
                )}

                {room.floor === "Etaj 2" && buildingId === 3 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Chimie – Etaj 2)</h3>

                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer
                        config={CHIMIE_ETAJ2}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    </div>

                    <p className="text-xs text-muted-foreground">
                      Sala selectată e evidențiată cu mov.
                    </p>
                  </div>
                )}

                {room.floor === "Parter" && buildingId === 4 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Drept – Parter)</h3>

                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer
                        config={DREPT_PARTER}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    </div>

                    <p className="text-xs text-muted-foreground">
                      Sala selectată este evidențiată cu mov. Culorile arată statusul sălilor.
                    </p>
                  </div>
                )}

                {room.floor === "Etaj 1" && buildingId === 4 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Drept – Etaj 1)</h3>

                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer
                        config={DREPT_ETAJ1}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    </div>

                    <p className="text-xs text-muted-foreground">
                      Sala selectată este evidențiată pe plan.
                    </p>
                  </div>
                )}

                {room.floor === "Etaj 2" && buildingId === 4 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Drept – Etaj 2)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer
                        config={DREPT_ETAJ2}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    </div>
                    <p className="text-xs text-muted-foreground">
                      Sala selectată este evidențiată cu mov.
                    </p>
                  </div>
                )}

                {/* Filosofie (BuildingId=5) */}
                {room.floor === "Parter" && buildingId === 5 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Filosofie – Parter)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={FILO_PARTER} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}
                {room.floor === "Etaj 1" && buildingId === 5 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Filosofie – Etaj 1)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={FILO_ETAJ1} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată pe plan.</p>
                  </div>
                )}
                {room.floor === "Etaj 2" && buildingId === 5 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Filosofie – Etaj 2)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={FILO_ETAJ2} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}

                {/* Fizică (BuildingId=6) */}
                {room.floor === "Parter" && buildingId === 6 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Fizică – Parter)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={FIZ_PARTER} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}
                {room.floor === "Etaj 1" && buildingId === 6 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Fizică – Etaj 1)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={FIZ_ETAJ1} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată pe plan.</p>
                  </div>
                )}
                {room.floor === "Etaj 2" && buildingId === 6 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Fizică – Etaj 2)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={FIZ_ETAJ2} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}

                {/* Geografie (BuildingId=7) */}
                {room.floor === "Parter" && buildingId === 7 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Geografie – Parter)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={GEO_PARTER} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}
                {room.floor === "Etaj 1" && buildingId === 7 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Geografie – Etaj 1)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={GEO_ETAJ1} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată pe plan.</p>
                  </div>
                )}
                {room.floor === "Etaj 2" && buildingId === 7 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Geografie – Etaj 2)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={GEO_ETAJ2} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}

                {/* Geologie și Geofizică (BuildingId=8) */}
                {room.floor === "Parter" && buildingId === 8 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Geologie – Parter)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={GG_PARTER} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}
                {room.floor === "Etaj 1" && buildingId === 8 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Geologie – Etaj 1)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={GG_ETAJ1} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată pe plan.</p>
                  </div>
                )}
                {room.floor === "Etaj 2" && buildingId === 8 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Geologie – Etaj 2)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={GG_ETAJ2} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}

                {/* Istorie (BuildingId=9) */}
                {room.floor === "Parter" && buildingId === 9 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Istorie – Parter)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={IST_PARTER} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}
                {room.floor === "Etaj 1" && buildingId === 9 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Istorie – Etaj 1)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={IST_ETAJ1} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată pe plan.</p>
                  </div>
                )}
                {room.floor === "Etaj 2" && buildingId === 9 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Istorie – Etaj 2)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={IST_ETAJ2} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}

                {/* Jurnalism (BuildingId=10) */}
                {room.floor === "Etaj 6" && buildingId === 10 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Jurnalism – Etaj 6)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={JURNALISM_ETAJ6} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}
                {room.floor === "Etaj 7" && buildingId === 10 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Jurnalism – Etaj 7)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={JURNALISM_ETAJ7} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}

                {/* FLLS (BuildingId=11) */}
                {room.floor === "Parter" && buildingId === 11 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (FLLS – Parter)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={FLLS_PARTER} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}
                {room.floor === "Etaj 1" && buildingId === 11 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (FLLS – Etaj 1)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={FLLS_ETAJ1} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată pe plan.</p>
                  </div>
                )}
                {room.floor === "Etaj 2" && buildingId === 11 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (FLLS – Etaj 2)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={FLLS_ETAJ2} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}

                {/* Litere (BuildingId=12) */}
                {room.floor === "Parter" && buildingId === 12 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Litere – Parter)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={LIT_PARTER} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}
                {room.floor === "Etaj 1" && buildingId === 12 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Litere – Etaj 1)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={LIT_ETAJ1} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată pe plan.</p>
                  </div>
                )}
                {room.floor === "Etaj 2" && buildingId === 12 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Litere – Etaj 2)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={LIT_ETAJ2} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}

                {/* Psihologie (BuildingId=14) */}
                {room.floor === "Parter" && buildingId === 14 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Psihologie – Parter)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={PSI_PARTER} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}
                {room.floor === "Etaj 1" && buildingId === 14 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Psihologie – Etaj 1)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={PSI_ETAJ1} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată pe plan.</p>
                  </div>
                )}
                {room.floor === "Etaj 2" && buildingId === 14 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Psihologie – Etaj 2)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={PSI_ETAJ2} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}

                {/* Sociologie (BuildingId=15) */}
                {room.floor === "Parter" && buildingId === 15 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Sociologie – Parter)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={SAS_PARTER} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}
                {room.floor === "Etaj 1" && buildingId === 15 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Sociologie – Etaj 1)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={SAS_ETAJ1} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată pe plan.</p>
                  </div>
                )}
                {room.floor === "Etaj 2" && buildingId === 15 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Sociologie – Etaj 2)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={SAS_ETAJ2} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}

                {/* Științe Politice (BuildingId=16) */}
                {room.floor === "Parter" && buildingId === 16 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Științe Politice – Parter)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={FSP_PARTER} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}
                {room.floor === "Etaj 1" && buildingId === 16 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Științe Politice – Etaj 1)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={FSP_ETAJ1} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată pe plan.</p>
                  </div>
                )}
                {room.floor === "Etaj 2" && buildingId === 16 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Științe Politice – Etaj 2)</h3>
                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer config={FSP_ETAJ2} rooms={buildingRooms} selectedRoomName={room.name} />
                    </div>
                    <p className="text-xs text-muted-foreground">Sala selectată este evidențiată cu mov.</p>
                  </div>
                )}






                {/* ✅ Floorplan FMI - Parter */}
                {showFmiParterPlan && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (FMI - Parter)</h3>

                    {loadingBuildingRooms ? (
                      <div className="text-sm text-muted-foreground">Se încarcă harta...</div>
                    ) : (
                      <FloorPlanViewer
                        config={FMI_PARTER}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    )}

                    <p className="text-xs text-muted-foreground">
                      Sala selectată este evidențiată cu mov. Culorile reflectă statusul (liber/ocupat/în curând).
                    </p>
                  </div>
                )}

                {/* Floorplan FMI - Etaj 1 */}
                {room.floor === "Etaj 1" && buildingId === 13 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Etaj 1)</h3>

                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer
                        config={FMI_ETAJ1}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    </div>

                    <p className="text-xs text-muted-foreground">
                      Sala selectată este evidențiată pe plan.
                    </p>
                  </div>
                )}



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

                {room.floor === "Etaj 2" && buildingId === 13 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Etaj 2)</h3>

                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer
                        config={FMI_ETAJ2}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    </div>

                    <p className="text-xs text-muted-foreground">
                      Sala selectată e evidențiată cu mov.
                    </p>
                  </div>
                )}

                {room.floor === "Etaj 3" && buildingId === 13 && (
                  <div className="space-y-2">
                    <h3 className="font-semibold">Hartă (Etaj 3)</h3>

                    <div className="rounded-lg border overflow-hidden">
                      <FloorPlanViewer
                        config={FMI_ETAJ3}
                        rooms={buildingRooms}
                        selectedRoomName={room.name}
                      />
                    </div>


                  </div>
                )}




                {/* Date Selector */}
                <div>
                  <h3 className="font-semibold mb-3">View Schedule for Another Date</h3>
                  <input
                    type="date"
                    value={`${selectedDate.getFullYear()}-${String(selectedDate.getMonth() + 1).padStart(2, '0')}-${String(selectedDate.getDate()).padStart(2, '0')}`}
                    onChange={(e) => {
                      const dateString = e.target.value; // YYYY-MM-DD
                      const date = new Date(dateString + 'T00:00:00');
                      setSelectedDate(date);
                      loadSchedulesForDate(dateString);
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
  <div
    className={`p-3 rounded-lg border-2 ${schedule.isCurrentlyActive ? 'border-primary bg-primary/10' : 'border-border'
      }`}
  >
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
