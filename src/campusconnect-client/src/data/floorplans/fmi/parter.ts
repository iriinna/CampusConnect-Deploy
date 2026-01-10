// src/data/floorplans/fmi/parter.ts
import parterImg from "../../../assets/floorplans/fmi/parter.png";

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

export const FMI_PARTER: FloorPlanConfig = {
  facultyKey: "fmi",
  floorLabel: "FMI – Parter",
  image: parterImg,

  // 🔧 Alege o dimensiune “standard”
  // Recomand: 900x600 sau 1000x700
  canvas: { w: 500, h: 500 },

  pins: [
    { roomName: "Amf. Spiru Haret", label: "Amf. Haret", x: 78, y: 435 },
    { roomName: "S1", label: "S1", x: 170, y: 60 },
    { roomName: "S3", label: "S3", x: 260, y: 60 },
  ],
};
