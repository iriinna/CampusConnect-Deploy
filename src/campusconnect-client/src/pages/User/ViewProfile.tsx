import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import '../../index.css';

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
  const { id } = useParams();
  const navigate = useNavigate();

  const [targetUser, setTargetUser] = useState<any>(null);
  const [loading, setLoading] = useState(true);
  const [message, setMessage] = useState<{ type: 'success' | 'error'; text: string } | null>(null);
  const [isDeleting, setIsDeleting] = useState(false);
  const userJson = localStorage.getItem('user');
  const loggedInUser = userJson ? JSON.parse(userJson) : null;
  const token = localStorage.getItem('token');

  const loggedInUserId = loggedInUser?.id || 
                        loggedInUser?.Id || 
                        loggedInUser?.ID || 
                        loggedInUser?.userId; 
    const isOwnProfile: boolean = !id || 
                        id === "undefined" || 
                        (loggedInUserId !== null && String(id) === String(loggedInUserId));


  const [savedAnnouncements, setSavedAnnouncements] = useState<Announcement[]>([]);
  const [savedEvents, setSavedEvents] = useState<Event[]>([]);
  const [participatingEvents, setParticipatingEvents] = useState<Event[]>([]);
  const [loadingSaved, setLoadingSaved] = useState(true);

  useEffect(() => {
    const fetchProfile = async () => {
      if (!token) {
        setLoading(false);
        return;
      }

      setLoading(true);
      try {
        const endpoint = isOwnProfile 
          ? `${API_BASE_URL}/user/details` 
          : `${API_BASE_URL}/user/public-details/${id}`;

        const res = await fetch(endpoint, {
          headers: { 'Authorization': `Bearer ${token}` }
        });

        if (res.ok) {
          const data = await res.json();
          setTargetUser(data);
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
            setMessage({ type: 'error', text: 'Profilul nu a putut fi găsit.' });
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
        }
      } catch (err) {
        setMessage({ type: 'error', text: 'Eroare de conexiune la server.' });

      } finally {
        setLoading(false);
      }
    };

    fetchProfile();
  }, [id, isOwnProfile, token]);

  useEffect(() => {
    if (isOwnProfile && token) {
      fetch(`${API_BASE_URL}/announcements/saved`, {
        headers: { 'Authorization': `Bearer ${token}` }
      })
      .then(res => res.ok ? res.json() : [])
      .then(data => setSavedAnnouncements(data))
      .catch(err => console.error(err));
    }
  }, [isOwnProfile, token]);

  const handleDeleteAccount = async () => {
    if (!window.confirm('Ești sigur că vrei să ștergi contul?')) return;
    setIsDeleting(true);
    try {
      const res = await fetch(DELETE_PROFILE_URL, {
        method: 'DELETE',
        headers: { 'Authorization': `Bearer ${token}` }
      });
      if (res.status === 204) {
        localStorage.clear();
        navigate('/login');
      }
    } catch (err) {
      setMessage({ type: 'error', text: 'Eroare la ștergere.' });
    } finally {
      setIsDeleting(false);
    }
  };

  if (loading) return <div className="container" style={{textAlign:'center', marginTop:'50px'}}>Se încarcă profilul...</div>;
  if (!targetUser) return <div className="container" style={{textAlign:'center', marginTop:'50px'}}><p>{message?.text || "Utilizator negăsit"}</p></div>;

  return (
    <div>
      <button className="back" onClick={() => navigate('/dashboard')}>&#x2190;</button>
      
      <div className="container" style={{ textAlign: 'center' }}>
        <div className="profile-card" style={{ background: '#fff', padding: '30px', borderRadius: '15px', boxShadow: '0 4px 20px rgba(0,0,0,0.1)' }}>
          
          <img 
            src={targetUser.profilePictureUrl || targetUser.ProfilePictureUrl || 'https://www.w3schools.com/howto/img_avatar.png'} 
            alt="Profile"
            style={{ width: '150px', height: '150px', borderRadius: '50%', objectFit: 'cover', border: '5px solid #007BFF', marginBottom: '20px' }} 
          />

          <h2>
            {targetUser.firstName || targetUser.FirstName} {targetUser.lastName || targetUser.LastName}
          </h2>

          <p><strong>Student ID:</strong> {targetUser.studentId || targetUser.StudentId || 'N/A'}</p>

          <p><strong>Date of birth:</strong> {
            (targetUser.dateOfBirth || targetUser.dateofBirth || targetUser.DateOfBirth) 
              ? new Date(targetUser.dateOfBirth || targetUser.dateofBirth || targetUser.DateOfBirth).toLocaleDateString('ro-RO') 
              : 'N/A'
          }</p>

          {isOwnProfile && (
            <div style={{ marginTop: '20px', borderTop: '1px solid #eee', paddingTop: '15px' }}>
              <p><strong>Email:</strong> {targetUser.email || targetUser.Email}</p>
              <div style={{ display: 'flex', gap: '10px', justifyContent: 'center', marginTop: '15px' }}>
                <button onClick={() => navigate('/edit-profile')} style={{ padding: '8px 16px', cursor: 'pointer' }}>
                  Editează profilul
                </button>
                <button 
                  onClick={handleDeleteAccount} 
                  style={{ background: '#dc3545', color: 'white', padding: '8px 16px', cursor: 'pointer' }}
                  disabled={isDeleting}
                >
                  {isDeleting ? 'Se șterge...' : 'Șterge contul'}
                </button>
              </div>
            </div>
          )}
        </div>

        {isOwnProfile && savedAnnouncements.length > 0 && (
          <div style={{ marginTop: '40px', textAlign: 'left' }}>
            <h3>Anunțurile tale salvate</h3>
            {savedAnnouncements.map((a: any) => (
              <div key={a.id} style={{ padding: '15px', borderBottom: '1px solid #eee', background: '#fff', marginBottom: '10px', borderRadius: '8px' }}>
                <strong>{a.title}</strong>
                <p style={{ fontSize: '14px', color: '#555' }}>{a.content}</p>
              </div>
            ))}
          </div>
        )}
      </div>
    </div>
  );
}

export default ProfileView;