// src/data/floorplans/fmi/etaj1.ts
import etaj1Img from "../../../assets/floorplans/fmi/et1.png";

// IMPORTANT: păstrăm aceleași tipuri ca în parter.ts ca să fie compatibil
export type Status = "Free" | "Occupied" | "OccupiedSoon" | string;

export type FloorPin = {
  roomName: string;
  label?: string;
  x: number; // ✅ pixeli pe canvas
  y: number; // ✅ pixeli pe canvas
};

export type FloorPlanConfig = {
  facultyKey: "fmi";
  floorLabel: string;
  image: string;

  canvas: { w: number; h: number }; // ✅ dimensiune fixă
  pins: FloorPin[];
};

export const FMI_ETAJ1: FloorPlanConfig = {
  facultyKey: "fmi",
  floorLabel: "FMI – Etaj 1",
  image: etaj1Img,

  // 🔧 folosește exact aceeași dimensiune ca la parter,
  // altfel coordonatele (pixeli) nu se potrivesc!
  canvas: { w: 500, h: 500 },

  pins: [
    // TODO: aici pui coordonatele tale reale
    // (exemple provizorii)
    { roomName: "Amf. Simion Stoilow", label: "Amf. Stoilow", x: 250, y: 420 },
    { roomName: "Lab FMI 1", label: "Lab 1", x: 120, y: 120 },
    { roomName: "Lab FMI 2", label: "Lab 2", x: 180, y: 120 },
    { roomName: "Lab FMI 3", label: "Lab 3", x: 240, y: 120 },
    { roomName: "S101", label: "S101", x: 320, y: 180 },
    { roomName: "S102", label: "S102", x: 360, y: 180 },
    { roomName: "S103", label: "S103", x: 400, y: 180 },
  ],
};
