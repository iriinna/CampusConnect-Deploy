import React, { useEffect, useState } from 'react';
import '../index.css';

const API_BASE_URL = 'http://localhost:5099/api';

interface Announcement {
  id: number;
  title: string;
  content: string;
  createdAt: string;
}

const Announcements: React.FC = () => {
  const [announcements, setAnnouncements] = useState<Announcement[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    fetchAnnouncements();
  }, []);

  const fetchAnnouncements = async () => {
    try {
      const response = await fetch(`${API_BASE_URL}/announcements`);
      const data: Announcement[] = await response.json();
      const sorted = data.sort((a, b) => new Date(b.createdAt).getTime() - new Date(a.createdAt).getTime());
      setAnnouncements(sorted);
    } catch (error) {
      console.error('Eroare la preluarea anunțurilor:', error);
    } finally {
      setLoading(false);
    }
  };

  const handleDelete = async (id: number) => {
    if (!window.confirm('Ești sigur că vrei să ștergi acest anunț?')) return;

    try {
      const response = await fetch(`${API_BASE_URL}/announcements/${id}`, {
        method: 'DELETE',
      });

      if (response.ok) {
        setAnnouncements((prev) => prev.filter((a) => a.id !== id));
      } else {
        console.error('Eroare la ștergerea anunțului');
      }
    } catch (error) {
      console.error('Eroare de conexiune:', error);
    }
  };

  if (loading) return <p>Se încarcă anunțurile...</p>;

  return (
    <div className="container" style={{ paddingTop: '80px', position: 'relative' }}>
      {/* Butonul „Înapoi” fixat în colț */}
      <button
        onClick={() => window.location.href = '/dashboard'}
        style={{
          position: 'fixed',
          top: '15px',
          left: '15px',
          padding: '3px 6px',
          fontSize: '12px',
          border: '1px solid #ccc',
          backgroundColor: '#007BFF',
          color: '#fff',
          cursor: 'pointer',
          borderRadius: '0',
          lineHeight: '1',
          width: '30px',
          height: '25px',
          textAlign: 'center',
          fontWeight: 'bold',
          zIndex: 1000,
        }}
        onMouseOver={(e) => (e.currentTarget.style.backgroundColor = '#0056b3')}
        onMouseOut={(e) => (e.currentTarget.style.backgroundColor = '#007BFF')}
      >
        ←
      </button>

      <h1>Announcements</h1>

      <button
        onClick={() => window.location.href = '/create-announcement'}
        style={{ marginBottom: '20px', padding: '6px 12px', cursor: 'pointer' }}
      >
        Create announcement
      </button>

      {announcements.length === 0 ? (
        <p>Nu există anunțuri disponibile.</p>
      ) : (
        <ul style={{ listStyle: 'none', padding: 0 }}>
          {announcements.map((a) => (
            <li
              key={a.id}
              style={{
                position: 'relative', // permite poziționarea absolută a „×”
                marginBottom: '20px',
                border: '1px solid #ccc',
                padding: '10px',
                paddingRight: '35px', // spațiu pentru buton
              }}
            >
              {/* Buton de ștergere „×” */}
              <button
                onClick={() => handleDelete(a.id)}
                style={{
                  position: 'absolute',
                  top: '5px',
                  right: '5px',
                  border: 'none',
                  background: 'transparent',
                  color: '#ff4d4f',
                  fontWeight: 'bold',
                  cursor: 'pointer',
                  fontSize: '16px',
                  lineHeight: '1',
                  padding: 0,
                }}
                title="Șterge anunțul"
              >
                ×
              </button>

              <h3>{a.title}</h3>
              <p>{a.content}</p>
              <small>{new Date(a.createdAt).toLocaleString()}</small>
            </li>
          ))}
        </ul>
      )}
    </div>
  );
};

export default Announcements;
