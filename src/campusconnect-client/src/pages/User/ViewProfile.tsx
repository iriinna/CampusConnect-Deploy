import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { jwtDecode } from "jwt-decode"; 
import '../../index.css';

const API_BASE_URL = 'http://localhost:5099/api';
const ROLE_CLAIM_TYPE = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";

interface DecodedToken {
  nameid?: string;
  sub?: string;
  id?: string;
  role?: string;
  [key: string]: any; 
}

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
  const [currentUser, setCurrentUser] = useState<{ id: number, role: string } | null>(null);
  const [loading, setLoading] = useState(true);
  const [message, setMessage] = useState<{ type: 'success' | 'error'; text: string } | null>(null);
  const [isDeleting, setIsDeleting] = useState(false);
  
  const token = localStorage.getItem('token');
  const defaultProfilePic = "https://t4.ftcdn.net/jpg/00/64/67/63/360_F_64676383_LdbmhiNM6Ypzb3FM4PPuFP9rHe7ri8Ju.jpg";

  useEffect(() => {
    if (token) {
      try {
        const decoded = jwtDecode<DecodedToken>(token);
        const rawId = decoded.nameid || decoded.sub || decoded.id;
        const rawRole = decoded.role || decoded[ROLE_CLAIM_TYPE] || "User";

        if (rawId) {
            setCurrentUser({
                id: parseInt(rawId),
                role: rawRole
            });
        }
      } catch (e) {
        console.error("Token invalid");
      }
    }
  }, [token]);

  const isOwnProfile = !id || (currentUser && String(id) === String(currentUser.id));
  const iAmAdmin = currentUser?.role === "Admin";
  const isNotMyProfile = targetUser && currentUser && targetUser.id !== currentUser.id;

  const [savedAnnouncements, setSavedAnnouncements] = useState<Announcement[]>([]);
  const [savedEvents, setSavedEvents] = useState<Event[]>([]);
  const [participatingEvents, setParticipatingEvents] = useState<Event[]>([]);

  useEffect(() => {
    const fetchProfile = async () => {
      if (!token) {
        setLoading(false);
        return;
      }

      setLoading(true);
      try {
        const endpoint = isOwnProfile && !id
          ? `${API_BASE_URL}/user/details` 
          : `${API_BASE_URL}/user/public-details/${id || currentUser?.id}`;

        const res = await fetch(endpoint, {
          headers: { 'Authorization': `Bearer ${token}` }
        });

        if (res.ok) {
          const data = await res.json();
          setTargetUser(data);

          if (isOwnProfile) {
              fetchPrivateData();
          }
        } else {
          setMessage({ type: 'error', text: 'Profilul nu a putut fi găsit.' });
        }
      } catch (err) {
        setMessage({ type: 'error', text: 'Eroare de conexiune la server.' });
      } finally {
        setLoading(false);
      }
    };

    if (token && (currentUser || !id)) {
        fetchProfile();
    }
  }, [id, isOwnProfile, token, currentUser]); 

  const fetchPrivateData = async () => {
      try {
        const resAnn = await fetch(`${API_BASE_URL}/announcements/saved`, { headers: { 'Authorization': `Bearer ${token}` } });
        if(resAnn.ok) setSavedAnnouncements(await resAnn.json());
      } catch(e) { console.error(e); }
  };

  const handleDeleteAccount = async () => {
    const confirmationMessage = isOwnProfile 
        ? 'Ești sigur că vrei să ștergi contul tău? Această acțiune este ireversibilă.' 
        : 'Ești sigur că vrei să ștergi ACEST utilizator? Ca Admin, această acțiune este ireversibilă.';

    if (!window.confirm(confirmationMessage)) return;

    setIsDeleting(true);
    try {
      const targetId = targetUser?.id || currentUser?.id;
      const res = await fetch(`${API_BASE_URL}/user/delete/${targetId}`, {
        method: 'DELETE',
        headers: { 'Authorization': `Bearer ${token}` }
      });

      if (res.status === 204) {
        if (isOwnProfile) {
            localStorage.clear();
            navigate('/login');
        } else {
            alert("Utilizatorul a fost șters cu succes.");
            navigate('/search-users');
        }
      } else {
          setMessage({ type: 'error', text: 'Eroare la ștergere. Verifică permisiunile.' });
      }
    } catch (err) {
      setMessage({ type: 'error', text: 'Eroare la ștergere.' });
    } finally {
      setIsDeleting(false);
    }
  };

  const handleToggleAdminRole = async () => {
      if (!targetUser) return;

      const isTargetAdmin = targetUser.role === 'Admin';
      const actionText = isTargetAdmin ? 'elimini drepturile de Admin' : 'oferi drepturi de Admin';
      
      if (!window.confirm(`Ești sigur că vrei să ${actionText} pentru acest utilizator?`)) return;

      try {
        const res = await fetch(`${API_BASE_URL}/user/${targetUser.id}/toggle-admin`, {
          method: 'PATCH', 
          headers: { 
              'Authorization': `Bearer ${token}`,
              'Content-Type': 'application/json'
          }
        });

        if (res.ok) {
          const data = await res.json();
          alert(data.message);
          
          setTargetUser((prev: any) => ({
              ...prev,
              role: data.newRole 
          }));
        } else {
          alert("Eroare la schimbarea rolului.");
        }
      } catch (err) {
        console.error(err);
        alert("Eroare de conexiune.");
      }
  };

  if (loading) return <div className="container" style={{textAlign:'center', marginTop:'50px'}}>Se încarcă profilul...</div>;
  if (!targetUser) return <div className="container" style={{textAlign:'center', marginTop:'50px'}}><p>{message?.text || "Utilizator negăsit"}</p></div>;

  const canDelete = isOwnProfile || iAmAdmin;

  return (
    <div>
      <div className="container" style={{ textAlign: 'center', paddingTop: '80px' }}>
        <div className="profile-card" style={{ background: '#fff', padding: '30px', borderRadius: '15px', boxShadow: '0 4px 20px rgba(0,0,0,0.1)' }}>
          
          <img 
            src={targetUser?.profilePictureUrl || defaultProfilePic} 
            alt="Profile"
            style={{ width: '150px', height: '150px', borderRadius: '50%', objectFit: 'cover', border: '5px solid #c7cacdff', marginBottom: '20px' }} 
          />

          <h2>
            {targetUser.firstName || targetUser.FirstName} {targetUser.lastName || targetUser.LastName}
          </h2>

          {(iAmAdmin || isOwnProfile) && (
             <span style={{background: '#eee', padding: '4px 8px', borderRadius: '4px', fontSize: '12px'}}>
                Rol: <strong>{targetUser.role || "User"}</strong>
             </span>
          )}

          <p><strong>Student ID:</strong> {targetUser.studentId || targetUser.StudentId || 'N/A'}</p>
          <p><strong>Date of birth:</strong> {
            (targetUser.dateOfBirth || targetUser.dateofBirth || targetUser.DateOfBirth) 
              ? new Date(targetUser.dateOfBirth || targetUser.dateofBirth || targetUser.DateOfBirth).toLocaleDateString('ro-RO') 
              : 'N/A'
          }</p>

          <div style={{ marginTop: '20px', borderTop: '1px solid #eee', paddingTop: '15px' }}>
            
            {(isOwnProfile || iAmAdmin) && (
                  <p><strong>Email:</strong> {targetUser.email || targetUser.Email}</p>
            )}

            <div style={{ display: 'flex', gap: '10px', justifyContent: 'center', marginTop: '15px', flexWrap: 'wrap' }}>
                
                {isOwnProfile && (
                    <button onClick={() => navigate('/edit-profile')} style={{ padding: '8px 16px', cursor: 'pointer' }}>
                    Editează profilul
                    </button>
                )}

                {canDelete && (
                    <button 
                        onClick={handleDeleteAccount} 
                        style={{ background: '#dc3545', color: 'white', padding: '8px 16px', cursor: 'pointer' }}
                        disabled={isDeleting}
                    >
                        {isDeleting ? 'Se șterge...' : (isOwnProfile ? 'Șterge contul' : 'Șterge utilizator')}
                    </button>
                )}
                
                {iAmAdmin && isNotMyProfile && (
                    <button 
                        onClick={handleToggleAdminRole}
                    >
                        {targetUser.role === 'Admin' ? 'Revocă Admin' : 'Acordă Admin'}
                    </button>
                )}
            </div>
          </div>
           
           {isOwnProfile && (
            <button
                  onClick={() => {
                    localStorage.clear();
                    window.location.href = '/login';
                  }}
                  style={{ background: '#333', color: 'white', marginTop: '10px' }}
                >
                  Logout
                </button>
           )}
        </div>

        {isOwnProfile && (
             <div style={{ marginTop: '40px', textAlign: 'left' }}>
                {savedAnnouncements.length > 0 && (
                    <>
                    <h3>Anunțurile tale salvate</h3>
                    {savedAnnouncements.map((a: any) => (
                    <div key={a.id} style={{ padding: '15px', borderBottom: '1px solid #eee', background: '#fff', marginBottom: '10px', borderRadius: '8px' }}>
                        <strong>{a.title}</strong>
                        <p style={{ fontSize: '14px', color: '#555' }}>{a.content}</p>
                    </div>
                    ))}
                    </>
                )}
             </div>
        )}
      </div>
    </div>
  );
}

export default ProfileView;