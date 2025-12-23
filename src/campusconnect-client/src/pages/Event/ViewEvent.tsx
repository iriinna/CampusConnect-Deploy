import { useEffect, useState } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import '../../index.css'; 

const API_BASE_URL = 'http://localhost:5099/api';

interface CurrentUser {
  id?: number; 
  userId?: number;
  firstName: string;
}

interface EventData {
  id: number;
  title: string;
  description: string;
  category: string;
  date: string;
  location: string;
  organizerId: number;
  participants: any[]; 
}

function ViewEvent() {
  const { id } = useParams<{ id: string }>();
  const navigate = useNavigate();

  const [event, setEvent] = useState<EventData | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);
  const [currentUser, setCurrentUser] = useState<CurrentUser | null>(null);
  const [isJoined, setIsJoined] = useState(false);

  useEffect(() => {
    const userString = localStorage.getItem('user');
    if (userString) {
      const userObj = JSON.parse(userString);
      setCurrentUser(userObj);
    }
    fetchEvent();
  }, [id]);

  const fetchEvent = async () => {
    try {
      const response = await fetch(`${API_BASE_URL}/event/${id}`);
      if (!response.ok) throw new Error('Evenimentul nu a fost gasit');
      
      const data = await response.json();
      setEvent(data);

      if (localStorage.getItem('user')) {
         const userObj = JSON.parse(localStorage.getItem('user') || '{}');
         const myId = userObj.userId || userObj.id;
         const joined = data.participants?.some((p: any) => p.userId === myId);
         setIsJoined(!!joined);
      }
    } catch (err) {
      setError('Nu s-a putut incarca evenimentul.');
    } finally {
      setLoading(false);
    }
  };

  const handleJoinToggle = async () => {
    const token = localStorage.getItem('token');
    if (!token) {
      alert("Trebuie sa fii autentificat.");
      return;
    }
    const endpoint = isJoined ? `${id}/leave` : `${id}/join`;
    const method = isJoined ? 'DELETE' : 'POST';

    try {
      const response = await fetch(`${API_BASE_URL}/event/${endpoint}`, {
        method: method,
        headers: { 'Authorization': `Bearer ${token}` }
      });

      if (response.ok) {
        setIsJoined(!isJoined);
        navigate('/events'); 
      } else {
        alert("Eroare la procesarea cererii.");
      }
    } catch (error) {
      console.error(error);
    }
  };

  const handleDelete = async () => {
    if (!window.confirm("Sigur vrei să stergi acest eveniment?")) return;
    const token = localStorage.getItem('token');
    try {
      const response = await fetch(`${API_BASE_URL}/event/${id}`, {
        method: 'DELETE',
        headers: { 'Authorization': `Bearer ${token}` }
      });
      if (response.ok) {
        navigate('/events'); 
      }
    } catch (error) {
      alert("Eroare la stergere");
    }
  };

  if (loading) return <div>Se incarca...</div>;
  if (error || !event) return <div className="error">{error || "Eveniment inexistent"}</div>;

  const currentUserId = currentUser?.userId || currentUser?.id;
  const isOrganizer = currentUserId && String(currentUserId) === String(event.organizerId);

  return (
    <div className="container" style={{ padding: '20px', maxWidth: '800px', margin: '0 auto' }}>
      <button
        onClick={() => navigate("/dashboard")}
        style={{ position: "fixed", top: "70px", left: "15px", padding: "3px 6px", fontSize: "12px", border: "1px solid #ccc", backgroundColor: "#007BFF", color: "#fff", cursor: "pointer", width: "30px", height: "25px", textAlign: "center", fontWeight: "bold", zIndex: 1000 }}
      >
        ←
      </button>
      
      <div className="event-header">
        <h1>{event.title}</h1>
        <span className="badge">{event.category}</span>
      </div>

      <div className="event-details" style={{ marginTop: '20px' }}>
        <p><strong>Data:</strong> {new Date(event.date).toLocaleString('ro-RO')}</p>
        <p><strong>Descriere:</strong></p>
        <p>{event.description}</p>
        <p><strong>Participanti:</strong> {event.participants?.length || 0}</p>
      </div>

      <div className="event-join" style={{ marginTop: '20px' }}>
        <button 
          onClick={handleJoinToggle} 
          className={isJoined ? 'btn-secondary' : 'btn-primary'}
        >
          {isJoined ? 'Paraseste Evenimentul' : 'Participa la Eveniment'}
        </button>
      </div>

      <div className="event-actions" style={{ marginTop: '30px', display: 'flex', gap: '10px' }}>
        
        {isOrganizer && (
          <>
            <button 
              onClick={() => navigate(`/edit-event/${event.id}`)}
              className="btn-secondary"
            >
              Editeaza
            </button>
            <button 
              onClick={handleDelete}
              className="btn-danger"
              style={{ backgroundColor: 'red', color: 'white' }}
            >
              Sterge
            </button>
          </>
        )}
      </div>
    </div>
  );
}

export default ViewEvent;