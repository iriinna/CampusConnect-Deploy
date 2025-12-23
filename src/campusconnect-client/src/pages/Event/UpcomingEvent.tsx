import { useEffect, useState } from 'react';
import { useNavigate, useLocation } from 'react-router-dom';
import '../../index.css';

const API_BASE_URL = 'http://localhost:5099/api';

interface EventSummary {
  id: number;
  title: string;    
  category: string;
  date: string;
  location: string;
  participants: any[]; 
}

function UpcomingEvents() {
  const navigate = useNavigate();
  const location = useLocation();

  // Extragem termenul de căutare din URL (?search=...)
  const queryParams = new URLSearchParams(location.search);
  const searchTerm = queryParams.get('search') || '';

  const [events, setEvents] = useState<EventSummary[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');

  const checkAdmin = () => {
    const userString = localStorage.getItem('user');
    if (!userString) return false;
    try {
      const user = JSON.parse(userString);
      return user.role?.toLowerCase() === 'admin' || user.isAdmin === true;
    } catch (e) {
      return false;
    }
  };

  const isAdmin = checkAdmin();

  // Funcția de fetch primește acum searchTerm ca parametru
  const fetchEvents = async (search: string) => {
    setLoading(true);
    setError(''); // Resetăm eroarea la fiecare căutare nouă
    try {
      // Dacă search există, adăugăm parametrul în URL, altfel chemăm endpoint-ul simplu
      const url = search 
        ? `${API_BASE_URL}/event/upcoming?search=${encodeURIComponent(search)}`
        : `${API_BASE_URL}/event/upcoming`;

      const response = await fetch(url);
      if (!response.ok) throw new Error('Nu s-au putut incarca evenimentele.');
      
      const data = await response.json();
      setEvents(data);
    } catch (err) {
      console.error(err);
      setError('Eroare la conexiunea cu serverul.');
    } finally {
      setLoading(false);
    }
  };

  // Acest useEffect "ascultă" de schimbările din URL
  // Când utilizatorul scrie în bara de search și apasă Enter, searchTerm se schimbă și declanșează fetch-ul
  useEffect(() => {
    fetchEvents(searchTerm);
  }, [searchTerm]);

  if (loading) return <div className="loading-spinner">Se incarca evenimentele...</div>;
  if (error) return <div className="error-message">{error}</div>;

  return (
    <div className="events-page" style={{ position: 'relative', paddingTop: '10px' }}>
      <button
        onClick={() => navigate('/dashboard')}
        style={{
          position: 'fixed',
          top: '15px',
          left: '15px',
          padding: '2px 5px',
          backgroundColor: 'transparent',
          color: '#6c757d',
          border: 'none',
          cursor: 'pointer',
          fontSize: '24px',
          fontWeight: 'normal',
          zIndex: 1000,
          opacity: 0.7,
          transition: 'opacity 0.2s'
        }}
        onMouseEnter={(e) => e.currentTarget.style.opacity = '1'}
        onMouseLeave={(e) => e.currentTarget.style.opacity = '0.7'}
        title="Înapoi la Dashboard"
      >
        ← 
      </button>
      
      <h1>
        {searchTerm ? `Rezultate căutare: "${searchTerm}"` : "Evenimente Viitoare"}
      </h1>
      
      {events.length === 0 ? (
        <div className="container" style={{ textAlign: 'center', marginTop: '50px' }}>
          <p className="no-events">
            {searchTerm 
              ? `Nu am găsit niciun eveniment pentru "${searchTerm}".` 
              : "Nu exista evenimente programate."}
          </p>
          
          {isAdmin && !searchTerm && (
            <button 
                className="create-btn" 
                onClick={() => navigate('/create-event')}
                style={{ marginTop: '20px', padding: '10px 20px', fontSize: '16px', cursor: 'pointer' }}
            >
              Creeaza eveniment
            </button>
          )}
        </div>
      ) : (
        <div className="events-grid">
          {events.map((event) => (
            <div key={event.id} className="container" onClick={() => navigate(`/event/${event.id}`)}>
              <div className="card-header">
                <span className="category-tag">{event.category}</span>
                <span className="participants-badge">
                  👥 {event.participants?.length || 0}
                </span>
              </div>
              
              <h3>{event.title}</h3> 
              
              <div className="card-details">
                <p>Data si ora: {new Date(event.date).toLocaleDateString('ro-RO')} {new Date(event.date).toLocaleTimeString('ro-RO', {hour: '2-digit', minute:'2-digit'})}</p>
              </div>

              <button className="view-btn">Vezi Detalii</button>
            </div>
          ))}
        </div>
      )}
    </div>
  );
}

export default UpcomingEvents;