import { useEffect, useState } from 'react';
import { MapContainer, TileLayer, Marker, Popup } from 'react-leaflet';
import { motion } from 'framer-motion';
import { MapPin, Building as BuildingIcon, Search, Plus } from 'lucide-react';
import L from 'leaflet';
import { Layout } from '../../components/Layout';
import { Card, CardContent } from '../../components/ui/Card';
import { Input } from '../../components/ui/Input';
import { Button } from '../../components/ui/Button';
import { BuildingSidePanel } from '../../components/CampusMap/BuildingSidePanel';
import { CreateScheduleDialog } from '../../components/CampusMap/CreateScheduleDialog';
import { campusMapApi } from '../../services/campusMapApi';
import type { Building } from '../../services/campusMapApi';

// 🔧 Fix Leaflet default marker icon issue with Vite
delete (L.Icon.Default.prototype as any)._getIconUrl;
L.Icon.Default.mergeOptions({
  iconRetinaUrl: 'https://unpkg.com/leaflet@1.9.4/dist/images/marker-icon-2x.png',
  iconUrl: 'https://unpkg.com/leaflet@1.9.4/dist/images/marker-icon.png',
  shadowUrl: 'https://unpkg.com/leaflet@1.9.4/dist/images/marker-shadow.png',
});

// 🔵 Icon normal
const normalIcon = new L.Icon({
  iconUrl: 'https://unpkg.com/leaflet@1.9.4/dist/images/marker-icon.png',
  iconRetinaUrl: 'https://unpkg.com/leaflet@1.9.4/dist/images/marker-icon-2x.png',
  shadowUrl: 'https://unpkg.com/leaflet@1.9.4/dist/images/marker-shadow.png',
  iconSize: [25, 41],
  iconAnchor: [12, 41],
});

// 🟣 Icon selectat
const selectedIcon = new L.Icon({
  iconUrl:
    'https://raw.githubusercontent.com/pointhi/leaflet-color-markers/master/img/marker-icon-violet.png',
  shadowUrl: 'https://unpkg.com/leaflet@1.9.4/dist/images/marker-shadow.png',
  iconSize: [30, 45],
  iconAnchor: [15, 45],
});

const CampusMap = () => {
  const [buildings, setBuildings] = useState<Building[]>([]);
  const [selectedBuilding, setSelectedBuilding] = useState<Building | null>(null);
  const [searchTerm, setSearchTerm] = useState('');
  const [createDialogOpen, setCreateDialogOpen] = useState(false);

  const user = JSON.parse(localStorage.getItem('user') || '{}');
  const isAdminOrProfessor = user.role === 'Admin' || user.role === 'Professor';

  // 📍 Centru FIX (nu se mai schimbă automat)
  const center: [number, number] = [44.4361, 26.0986]; // Piața Universității

  useEffect(() => {
    loadBuildings();
  }, []);

  const loadBuildings = async () => {
    try {
      const data = await campusMapApi.getAllBuildings();
      setBuildings(data);
    } catch (error) {
      console.error('Error loading buildings:', error);
    }
  };

  const filteredBuildings = buildings.filter((b) =>
    b.name.toLowerCase().includes(searchTerm.toLowerCase())
  );

  return (
    <Layout>
      <div className="space-y-6">
        {/* Header */}
        <motion.div
          initial={{ opacity: 0, y: 20 }}
          animate={{ opacity: 1, y: 0 }}
          className="relative overflow-hidden rounded-2xl bg-gradient-to-br from-blue-500 via-cyan-500 to-teal-500 p-8 text-white shadow-2xl"
        >
          <div className="relative z-10 flex items-center justify-between">
            <div className="flex items-center gap-3">
              <div className="p-3 bg-white/20 rounded-xl">
                <MapPin className="h-8 w-8" />
              </div>
              <div>
                <h1 className="text-4xl font-bold">Harta Campus UniBuc</h1>
                <p className="text-white/80 mt-1">Navigare interactivă în campus</p>
              </div>
            </div>

            {isAdminOrProfessor && (
              <Button
                onClick={() => setCreateDialogOpen(true)}
                className="bg-white text-blue-600 hover:bg-white/90"
              >
                <Plus className="h-4 w-4 mr-2" />
                Adaugă program
              </Button>
            )}
          </div>
        </motion.div>

        <div className="grid grid-cols-1 lg:grid-cols-3 gap-6">
          {/* Lista clădiri */}
          <div className="lg:col-span-1">
            <Card>
              <CardContent className="p-4">
                <div className="mb-4 relative">
                  <Search className="absolute left-3 top-1/2 -translate-y-1/2 h-4 w-4 text-muted-foreground" />
                  <Input
                    placeholder="Caută clădiri..."
                    value={searchTerm}
                    onChange={(e) => setSearchTerm(e.target.value)}
                    className="pl-10"
                  />
                </div>

                <div className="space-y-2 max-h-[600px] overflow-y-auto">
                  {filteredBuildings.map((building) => (
                    <div
                      key={building.id}
                      onClick={() => setSelectedBuilding(building)}
                      className={`p-4 rounded-lg border-2 cursor-pointer ${
                        selectedBuilding?.id === building.id
                          ? 'border-primary bg-primary/10'
                          : 'border-border hover:border-primary/50'
                      }`}
                    >
                      <div className="flex gap-3">
                        <BuildingIcon className="h-5 w-5 text-primary mt-1" />
                        <div>
                          <h3 className="font-semibold text-sm">{building.name}</h3>
                          <p className="text-xs text-muted-foreground">
                            {building.address}
                          </p>
                          <p className="text-xs text-muted-foreground mt-1">
                            {building.roomsCount} săli
                          </p>
                        </div>
                      </div>
                    </div>
                  ))}
                </div>
              </CardContent>
            </Card>
          </div>

          {/* Harta */}
          <div className="lg:col-span-2">
            <Card className="overflow-hidden">
              <div className="h-[600px]">
                <MapContainer
                  center={center}
                  zoom={16}
                  className="h-full w-full"
                >
                  <TileLayer
                    attribution="&copy; OpenStreetMap"
                    url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
                  />

                  {filteredBuildings.map((building) => (
                    <Marker
                      key={building.id}
                      position={[building.latitude, building.longitude]}
                      icon={
                        selectedBuilding?.id === building.id
                          ? selectedIcon
                          : normalIcon
                      }
                      eventHandlers={{
                        click: () => setSelectedBuilding(building),
                      }}
                    >
                      <Popup>
                        <strong>{building.name}</strong>
                        <br />
                        <span className="text-xs">{building.address}</span>
                      </Popup>
                    </Marker>
                  ))}
                </MapContainer>
              </div>
            </Card>
          </div>
        </div>

        {/* Side panel */}
        {selectedBuilding && (
          <BuildingSidePanel
            building={selectedBuilding}
            onClose={() => setSelectedBuilding(null)}
          />
        )}

        {/* Dialog creare program */}
        <CreateScheduleDialog
          open={createDialogOpen}
          onOpenChange={setCreateDialogOpen}
          onScheduleCreated={loadBuildings}
        />
      </div>
    </Layout>
  );
};

export default CampusMap;
