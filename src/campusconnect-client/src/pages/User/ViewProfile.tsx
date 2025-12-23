import { useState, useEffect } from 'react';
import '../../index.css';

// URL-ul de bază al API-ului
const API_BASE_URL = 'http://localhost:5099/api';
const DELETE_PROFILE_URL = `${API_BASE_URL}/user/delete`;

interface Announcement {
  id: number;
  title: string;
  content: string;
  category: string;
  createdAt: string;
}

interface Event {
  id: number;
  title: string;
  description: string;
  date: string;
  category: string;
  dateCreated: string;
}

function ProfileView() {
  const [message, setMessage] = useState<{ type: 'success' | 'error'; text: string } | null>(null);
  const [isDeleting, setIsDeleting] = useState(false);

  const [savedAnnouncements, setSavedAnnouncements] = useState<Announcement[]>([]);
  const [savedEvents, setSavedEvents] = useState<Event[]>([]);
  const [participatingEvents, setParticipatingEvents] = useState<Event[]>([]);
  const [loadingSaved, setLoadingSaved] = useState(true);

  // Extragem datele și token-ul din localStorage
  const user = JSON.parse(localStorage.getItem('user') || '{}');
  const token = localStorage.getItem('token');

  // Fetch saved announcements and events pentru userul logat
  useEffect(() => {
    const fetchSaved = async () => {
      if (!token) {
        setLoadingSaved(false);
        return;
      }

      try {
        // Fetch saved announcements
        const resAnnouncements = await fetch(`${API_BASE_URL}/announcements/saved`, {
          headers: {
            'Authorization': `Bearer ${token}`,
          },
        });

        if (resAnnouncements.ok) {
          const data: Announcement[] = await resAnnouncements.json();
          setSavedAnnouncements(data);
        } else {
          console.error('Eroare la preluarea saved announcements');
        }

        // Fetch saved events
        const resEvents = await fetch(`${API_BASE_URL}/event/saved`, {
          headers: {
            'Authorization': `Bearer ${token}`,
          },
        });

        if (resEvents.ok) {
          const data: Event[] = await resEvents.json();
          setSavedEvents(data);
        } else {
          console.error('Eroare la preluarea saved events');
        }

        // Fetch participating events
        const resParticipating = await fetch(`${API_BASE_URL}/event/my-events`, {
          headers: {
            'Authorization': `Bearer ${token}`,
          },
        });

        if (resParticipating.ok) {
          const data: Event[] = await resParticipating.json();
          setParticipatingEvents(data);
        } else {
          console.error('Eroare la preluarea participating events');
        }
      } catch (err) {
        console.error('Eroare de rețea la saved items', err);
      } finally {
        setLoadingSaved(false);
      }
    };

    fetchSaved();
  }, [token]);

  // Verificăm dacă utilizatorul este valid
  if (!user.firstName || !token) {
    return (
      <div style={{ padding: '40px', textAlign: 'center' }}>
        <p style={{ color: 'red' }}>Nu ești autentificat. Te rugăm să te loghezi.</p>
        <button onClick={() => (window.location.href = '/login')}>Mergi la Login</button>
      </div>
    );
  }

  const handleDeleteAccount = async () => {
    const confirmed = window.confirm(
      'Esti sigur ca vrei sa stergi acest cont? Aceasta actiune este ireversibila!'
    );

    if (!confirmed) {
      return;
    }

    setIsDeleting(true);
    setMessage(null);

    try {
      const response = await fetch(DELETE_PROFILE_URL, {
        method: 'DELETE',
        headers: {
          'Authorization': `Bearer ${token}`,
        },
      });

      if (response.status === 204) {
        setMessage({
          type: 'success',
          text: 'Contul a fost sters cu succes! Redirectionare in scurt timp...',
        });

        localStorage.removeItem('user');
        localStorage.removeItem('token');

        if (typeof window !== 'undefined') {
          setTimeout(() => {
            window.location.href = '/login';
          }, 2000);
        }
      } else {
        const errorText =
          response.status === 404
            ? 'Contul nu a putut fi gasit (posibil deja sters).'
            : response.status === 401
            ? 'Sesiune expirata. Va rugam sa va autentificati din nou.'
            : `Eroare HTTP ${response.status}.`;

        let errorData = null;
        try {
          errorData = await response.json();
        } catch (e) {}

        setMessage({
          type: 'error',
          text: (errorData as any)?.message || errorText,
        });
      }
    } catch (error) {
      const errMsg = error instanceof Error ? error.message : String(error);
      setMessage({
        type: 'error',
        text: `Eroare de conexiune la server: ${errMsg}.`,
      });
    } finally {
      setIsDeleting(false);
    }
  };

  return (
    <div className="container" style={{ padding: '20px', maxWidth: '1000px', margin: '0 auto' }}>
      <button
        onClick={() => (window.location.href = '/dashboard')}
        style={{
          marginBottom: '20px',
          padding: '10px 20px',
          backgroundColor: '#6c757d',
          color: 'white',
          border: 'none',
          borderRadius: '5px',
          cursor: 'pointer',
          fontSize: '16px'
        }}
      >
        ← Înapoi la Dashboard
      </button>
      
      <div>
        <h2>
          {user.firstName} {user.lastName}
        </h2>
        <p>Email: {user.email}</p>
        <p>Date of birth: {user.dateOfBirth || ''}</p>
        <p>Student ID: {user.studentId || ''}</p>

        {message && (
          <p style={{ color: message.type === 'success' ? 'green' : 'red' }}>
            {message.text}
          </p>
        )}

        <button
          onClick={() => (window.location.href = '/edit-profile')}
          disabled={isDeleting}
        >
          Editeaza profilul
        </button>

        <button
          onClick={handleDeleteAccount}
          style={{
            background: '#dc3545',
            opacity: isDeleting ? 0.6 : 1,
            cursor: isDeleting ? 'not-allowed' : 'pointer',
          }}
          disabled={isDeleting}
        >
          {isDeleting ? 'Se Sterge...' : 'Sterge contul'}
        </button>

        {/* Secțiunea de Saved / Bookmarked Announcements */}
        <section style={{ marginTop: '30px' }}>
          <h3>Saved Announcements</h3>

          {loadingSaved ? (
            <p>Se încarcă anunțurile salvate...</p>
          ) : savedAnnouncements.length === 0 ? (
            <p>Nu ai încă anunțuri salvate.</p>
          ) : (
            <ul style={{ listStyle: 'none', padding: 0 }}>
              {savedAnnouncements.map((a) => (
                <li
                  key={a.id}
                  style={{
                    marginBottom: '15px',
                    border: '1px solid #ccc',
                    padding: '10px',
                  }}
                >
                  <strong style={{ marginRight: '8px' }}>{a.category}</strong>
                  <h4 style={{ display: 'inline-block', margin: 0 }}>{a.title}</h4>
                  <p>{a.content}</p>
                  <small>{new Date(a.createdAt).toLocaleString()}</small>
                </li>
              ))}
            </ul>
          )}
        </section>

        {/* Secțiunea de Saved Events */}
        <section style={{ marginTop: '30px' }}>
          <h3>Saved Events</h3>

          {loadingSaved ? (
            <p>Se încarcă evenimentele salvate...</p>
          ) : savedEvents.length === 0 ? (
            <p>Nu ai încă evenimente salvate.</p>
          ) : (
            <ul style={{ listStyle: 'none', padding: 0 }}>
              {savedEvents.map((e) => (
                <li
                  key={e.id}
                  style={{
                    marginBottom: '15px',
                    border: '1px solid #ccc',
                    padding: '10px',
                  }}
                >
                  <strong style={{ marginRight: '8px' }}>{e.category}</strong>
                  <h4 style={{ display: 'inline-block', margin: 0 }}>{e.title}</h4>
                  <p>{e.description}</p>
                  <small>Data eveniment: {new Date(e.date).toLocaleString('ro-RO')}</small>
                </li>
              ))}
            </ul>
          )}
        </section>

        {/* Secțiunea de Evenimente la care Participi */}
        <section style={{ marginTop: '30px' }}>
          <h3>My Events (Participing)</h3>

          {loadingSaved ? (
            <p>Se încarcă evenimentele...</p>
          ) : participatingEvents.length === 0 ? (
            <p>Nu participi la niciun eveniment.</p>
          ) : (
            <ul style={{ listStyle: 'none', padding: 0 }}>
              {participatingEvents.map((e) => (
                <li
                  key={e.id}
                  style={{
                    marginBottom: '15px',
                    border: '1px solid #ccc',
                    padding: '10px',
                    backgroundColor: '#f0f8ff',
                  }}
                >
                  <strong style={{ marginRight: '8px' }}>{e.category}</strong>
                  <h4 style={{ display: 'inline-block', margin: 0 }}>{e.title}</h4>
                  <p>{e.description}</p>
                  <small>Data eveniment: {new Date(e.date).toLocaleString('ro-RO')}</small>
                </li>
              ))}
            </ul>
          )}
        </section>
      </div>
    </div>
  );
}

export default ProfileView;
