import React, { useEffect, useState } from 'react';
import { useLocation, useNavigate } from 'react-router-dom';
import '../../index.css';

const API_BASE_URL = 'http://localhost:5099/api';

interface UserSummary {
  id: number;
  firstName: string;
  lastName: string;
  profilePictureUrl: string | null;
  studentId: string;
}

const Users: React.FC = () => {
  const [users, setUsers] = useState<UserSummary[]>([]);
  const [loading, setLoading] = useState(true);
  const location = useLocation();
  const navigate = useNavigate();
  const defaultProfilePic = "https://t4.ftcdn.net/jpg/00/64/67/63/360_F_64676383_LdbmhiNM6Ypzb3FM4PPuFP9rHe7ri8Ju.jpg";
  const searchTerm = new URLSearchParams(location.search).get('search') || '';

  useEffect(() => {
    const fetchUsers = async () => {
      setLoading(true);
      try {
        const token = localStorage.getItem("token");
        const res = await fetch(`${API_BASE_URL}/user/search?search=${encodeURIComponent(searchTerm)}`, {
          headers: {
            "Authorization": `Bearer ${token}`
          }
        });
        if (res.ok) {
          const data = await res.json();
          setUsers(data);
        }
      } catch (err) {
        console.error("Eroare la căutarea utilizatorilor:", err);
      } finally {
        setLoading(false);
      }
    };

    fetchUsers();
  }, [location.search]); 

  if (loading) return <p>Se caută utilizatori...</p>;

  return (
    <div className="container" style={{ paddingTop: "80px" }}>

      <h1>{searchTerm ? `Results for: "${searchTerm}"` : "All Users"}</h1>

      {users.length === 0 ? (
        <div style={{ textAlign: 'center', marginTop: '50px' }}>
          <p>Nu am găsit niciun utilizator care să corespundă căutării.</p>
          {searchTerm && (
            <button onClick={() => navigate("/users")} style={{ color: '#007BFF', background: 'none', border: 'none', textDecoration: 'underline', cursor: 'pointer' }}>
              Vezi toți utilizatorii
            </button>
          )}
        </div>
      ) : (
        <div className="users-grid" style={{ 
            display: 'grid', 
            gridTemplateColumns: 'repeat(4, 1fr)', 
            gap: '20px',                         
            padding: '20px',
            width: '100%',                   
            maxWidth: '1200px',                   
            margin: '0 auto',                     
            boxSizing: 'border-box'
        }}>
        {users.map((user, index) => (
            <div key={user.id || index} className="user-card" style={{ 
                textAlign: 'center', 
                padding: '20px', 
                borderRadius: '15px', 
                boxShadow: '0 4px 12px rgba(0,0,0,0.08)',
                backgroundColor: '#fff',
                display: 'flex',
                flexDirection: 'column',
                alignItems: 'center',
                justifyContent: 'space-between',
                border: '1px solid #eee'
            }}>
                <img 
                    src={user.profilePictureUrl || defaultProfilePic} 
                    alt="Profile" 
                    style={{ width: '100px', height: '100px', borderRadius: '50%', objectFit: 'cover', marginBottom: '15px', border: '3px solid #f0f2f5' }} 
                />
                <h3 style={{ margin: '10px 0', fontSize: '1.1rem', color: '#2c3e50' }}>
                    {(user as any).firstName || (user as any).FirstName} {(user as any).lastName || (user as any).LastName}
                </h3>
                
                <button 
                    onClick={() => {
                        const userId = user.id || (user as any).Id;
                        if (userId) {
                            navigate(`/profile/${userId}`);
                        } else {
                            console.error("ID-ul lipsește pentru utilizatorul:", user);
                        }
                    }} 
                    className="view-btn" 
                    style={{ width: '100%', padding: '8px 0', cursor: 'pointer', backgroundColor: '#007BFF', color: 'white', border: 'none', borderRadius: '5px' }}
                >
                    View Profile
                </button>
            </div>
            ))}
        </div>
            )}
            </div>
  );
};

export default Users;