import React, { useEffect, useState } from 'react';
import { useLocation, useNavigate } from 'react-router-dom';
import '../index.css';

const API_BASE_URL = 'http://localhost:5099/api';

interface Announcement {
  id: number;
  title: string;
  content: string;
  category: string;
  createdAt: string;
}

const Announcements: React.FC = () => {
  const [announcements, setAnnouncements] = useState<Announcement[]>([]);
  const [loading, setLoading] = useState(true);
  const [savedIds, setSavedIds] = useState<number[]>([]);
  const [category, setCategory] = useState<string>("");

  const location = useLocation();
  const navigate = useNavigate();
  const searchTerm = new URLSearchParams(location.search).get('search') || '';

  useEffect(() => {
    const fetchAnnouncements = async () => {
      setLoading(true);
      try {
        const params = new URLSearchParams();
        if (category) params.append('category', category);
        if (searchTerm) params.append('search', searchTerm);

        const res = await fetch(`${API_BASE_URL}/announcements?${params.toString()}`);
        const data = await res.json();
        setAnnouncements(data);
      } catch (err) {
        console.error(err);
      } finally {
        setLoading(false);
      }
    };
    fetchAnnouncements();
  }, [category, location.search]); 

  useEffect(() => {
    const token = localStorage.getItem("token");
    if (!token) return;
    const fetchSaved = async () => {
      try {
        const res = await fetch(`${API_BASE_URL}/announcements/saved`, {
          headers: { "Authorization": `Bearer ${token}` }
        });
        if (res.ok) {
          const data = await res.json();
          setSavedIds(data.map((a: any) => a.id));
        }
      } catch (err) { console.error(err); }
    };
    fetchSaved();
  }, []);

  const handleToggleBookmark = async (id: number) => {
    const token = localStorage.getItem("token");
    if (!token) { alert("Trebuie să fii logat."); navigate("/login"); return; }
    const isSaved = savedIds.includes(id);
    try {
      const res = await fetch(`${API_BASE_URL}/announcements/${id}/bookmark`, {
        method: isSaved ? "DELETE" : "POST",
        headers: { "Authorization": `Bearer ${token}` }
      });
      if (res.ok) setSavedIds(prev => isSaved ? prev.filter(x => x !== id) : [...prev, id]);
    } catch (err) { console.error(err); }
  };

  const handleDelete = async (id: number) => {
    if (!window.confirm('Ești sigur că vrei să ștergi acest anunț?')) return;
    try {
      const response = await fetch(`${API_BASE_URL}/announcements/${id}`, { method: 'DELETE' });
      if (response.ok) setAnnouncements(prev => prev.filter(a => a.id !== id));
    } catch (err) { console.error(err); }
  };

  if (loading) return <p>Se încarcă anunțurile...</p>;

  return (
    <div className="container" style={{ paddingTop: "80px", position: "relative" }}>
      <button
        onClick={() => navigate("/dashboard")}
        style={{ position: "fixed", top: "70px", left: "15px", padding: "3px 6px", fontSize: "12px", border: "1px solid #ccc", backgroundColor: "#007BFF", color: "#fff", cursor: "pointer", width: "30px", height: "25px", textAlign: "center", fontWeight: "bold", zIndex: 1000 }}
      >
        ←
      </button>
      <h1>{searchTerm ? `Results for: "${searchTerm}"` : "Announcements"}</h1>
      {!searchTerm && !category && announcements.length > 0 && (
        <button
          onClick={() => navigate("/create-announcement")}
          style={{ marginBottom: "20px", padding: "6px 12px", cursor: "pointer" }}
        >
          Create announcement
        </button>
      )}

      {announcements.length === 0 ? (
        <div style={{ textAlign: 'center', marginTop: '50px' }}>
          <p style={{ fontSize: '18px', color: '#666' }}>
            {searchTerm ? `Nu s-a găsit nimic pentru "${searchTerm}"` : "Nu există anunțuri disponibile."}
          </p>
          {searchTerm && (
            <button onClick={() => navigate("/announcements")} 
              style={{ marginBottom: "20px", padding: "6px 12px", cursor: "pointer" }}>
               Vezi toate anunțurile
            </button>
          )}
        </div>
      ) : (
        <>
          <div style={{ marginBottom: "15px" }}>
            <label>
              Category:{" "}
              <select value={category} onChange={(e) => setCategory(e.target.value)}>
                <option value="">All</option>
                <option value="Academic">Academic</option>
                <option value="Sports">Sports</option>
                <option value="Events">Events</option>
                <option value="General">General</option>
              </select>
            </label>
          </div>

          <ul style={{ listStyle: "none", padding: 0 }}>
            {announcements.map(a => {
              const isSaved = savedIds.includes(a.id);
              return (
                <li key={a.id} style={{ marginBottom: "20px", border: "1px solid #ccc", borderRadius: "12px", padding: "14px 16px", boxShadow: "0 2px 6px rgba(0,0,0,0.06)", backgroundColor: "#fff" }}>
                  <div style={{ display: "flex", justifyContent: "space-between", alignItems: "center", marginBottom: "8px" }}>
                    <div style={{ display: "flex", alignItems: "center", gap: "8px" }}>
                      <button type="button" onClick={() => handleToggleBookmark(a.id)} style={{ border: "none", background: "transparent", padding: 0, margin: 0, cursor: "pointer", fontSize: "18px", color: isSaved ? "#f5c518" : "#bbb", outline: "none", boxShadow: "none" }} title={isSaved ? "Remove" : "Save"}>
                        {isSaved ? "★" : "☆"}
                      </button>
                      <strong style={{ fontSize: "12px", textTransform: "uppercase", letterSpacing: "0.06em", color: "#777" }}>
                        {a.category}
                      </strong>
                    </div>
                    <button type="button" onClick={() => handleDelete(a.id)} style={{ border: "none", background: "transparent", padding: 0, margin: 0, cursor: "pointer", fontSize: "16px", color: "#ff4d4f", outline: "none", boxShadow: "none" }} title="Șterge">
                      ×
                    </button>
                  </div>
                  <h3 style={{ margin: "4px 0 8px 0" }}>{a.title}</h3>
                  <p style={{ margin: "0 0 8px 0" }}>{a.content}</p>
                  <small style={{ color: "#888" }}>
                    {new Date(a.createdAt).toLocaleString()}
                  </small>
                </li>
              );
            })}
          </ul>
        </>
      )}
    </div>
  );
};

export default Announcements;