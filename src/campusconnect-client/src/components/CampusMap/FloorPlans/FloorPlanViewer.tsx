// src/components/CampusMap/FloorPlans/FloorPlanViewer.tsx
import { useMemo } from "react";
import type { FloorPlanConfig, Status } from "../../../data/floorplans/fmi/parter";

type SimpleRoom = {
  name: string;
  currentStatus: Status;
};

type Props = {
  config: FloorPlanConfig;
  rooms: SimpleRoom[];
  selectedRoomName?: string;
  onSelectRoomName?: (name: string) => void;
};

const statusDotClass = (status: Status) => {
  switch (status) {
    case "Free":
      return "bg-green-500";
    case "Occupied":
      return "bg-red-500";
    case "OccupiedSoon":
      return "bg-yellow-500";
    default:
      return "bg-gray-500";
  }
};

export const FloorPlanViewer = ({ config, rooms, selectedRoomName, onSelectRoomName }: Props) => {
  const roomByName = useMemo(() => {
    const map = new Map<string, SimpleRoom>();
    rooms.forEach((r) => map.set(r.name, r));
    return map;
  }, [rooms]);

  return (
    <div className="space-y-2">
      <div className="flex items-center justify-between">
        <h3 className="font-semibold">Schiță: {config.floorLabel}</h3>
        <span className="text-xs text-muted-foreground">
          Verde=liber, Galben=în curând, Roșu=ocupat
        </span>
      </div>

      {/* Important: păstrăm raportul din canvas */}
      <div className="w-full rounded-lg border bg-background overflow-hidden">
        {/* imaginea se scalează, dar overlay-ul e “fixat” pe canvas */}
        <div className="relative w-full">
          <img src={config.image} alt={config.floorLabel} className="w-full h-auto block select-none" draggable={false} />

          {/* Overlay scalat exact ca imaginea */}
          <div
            className="absolute inset-0"
            style={{
              // păstrează proporțiile exact ca canvas-ul tău
              // overlay-ul este un “sistem de coordonate” care se întinde pe imagine
            }}
          >
            {/* Container intern cu coordonate în pixeli, scalat la dimensiunea imaginii */}
            <div
              className="absolute left-0 top-0"
              style={{
                width: "100%",
                height: "100%",
              }}
            >
              {config.pins.map((p) => {
                const room = roomByName.get(p.roomName);
                const isSelected = selectedRoomName === p.roomName;

                // Transformăm pixeli (din canvas) în procente, ca să fie responsive
                const leftPct = (p.x / config.canvas.w) * 100;
                const topPct = (p.y / config.canvas.h) * 100;

                const dotClass = isSelected
                  ? "bg-purple-600"
                  : statusDotClass(room?.currentStatus ?? "Unknown");

                return (
                  <button
                    key={p.roomName}
                    type="button"
                    onClick={() => onSelectRoomName?.(p.roomName)}
                    className={[
                      "absolute -translate-x-1/2 -translate-y-1/2",
                      "flex items-center gap-2",
                      onSelectRoomName ? "cursor-pointer" : "cursor-default",
                    ].join(" ")}
                    style={{ left: `${leftPct}%`, top: `${topPct}%` }}
                    title={`${p.label ?? p.roomName}${room ? ` • ${room.currentStatus}` : ""}`}
                  >
                    <span className="relative inline-block">
                      {isSelected && (
                        <span className="absolute inset-0 rounded-full bg-purple-500/35 animate-ping" />
                      )}
                      <span
                        className={[
                          "relative block rounded-full h-4 w-4",
                          dotClass,
                          "shadow-md",
                          isSelected ? "ring-4 ring-purple-500/40" : "ring-2 ring-white/80",
                        ].join(" ")}
                      />
                    </span>

                    {isSelected && (
                      <span className="px-2 py-1 rounded-md text-xs font-semibold bg-white/95 border shadow">
                        {p.label ?? p.roomName}
                      </span>
                    )}
                  </button>
                );
              })}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};
