import React, { useState, useEffect } from 'react';
import '../../index.css'

interface UserProfile {
  firstName: string;
  lastName: string;
  profilePictureUrl?: string;
  dateOfBirth: string;
  studentId?: string;
}

interface AuthData {
    token: string;
}

const API_BASE_URL = 'http://localhost:5099/api';
const GET_PROFILE_URL = `${API_BASE_URL}/user/details`; 
const PUT_PROFILE_URL = `${API_BASE_URL}/user/update`;


const EditProfile: React.FC = () => {
  const [formData, setFormData] = useState<UserProfile>({
    firstName: '',
    lastName: '',
    profilePictureUrl: '',
    dateOfBirth: '',
    studentId: ''
  });
  const [loading, setLoading] = useState(true);
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [message, setMessage] = useState<{ type: 'success' | 'error'; text: string } | null>(null);
  const [authData, setAuthData] = useState<AuthData | null>(null);

  // Citire token din LocalStorage
  const loadAuthData = (): AuthData | null => {
    if (typeof window === 'undefined') return null;
    try {
        const userJson = localStorage.getItem('user');
        const token = localStorage.getItem('token'); 

        if (userJson && token) {
            return {
                token: token, 
            };
        }
    } catch (e) {
        console.error("Eroare la citirea datelor de autentificare din localStorage:", e);
    }
    return null;
  };
    
  useEffect(() => {
    const data = loadAuthData();
    if (!data) {
        setLoading(false);
        setMessage({ type: 'error', text: 'Nu esti autentificat. Te rugsm ss te loghezi.' });
        if (typeof window !== 'undefined') {
            setTimeout(() => window.location.href = '/login', 2000); 
        }
        return;
    }
    setAuthData(data);

const formatIsoDateToInput = (isoDate: string | undefined | null): string => {
    if (!isoDate) return '';
    
    const datePart = isoDate.substring(0, 10);
    
    if (datePart.match(/^\d{4}-\d{2}-\d{2}$/)) {
        return datePart;
    }

return ''; 
};
    const fetchCurrentProfile = async () => {
      const url = GET_PROFILE_URL; 
      try {
        const response = await fetch(url, { 
          method: 'GET',
          headers: {
            'Content-Type': 'application/json',
            'Authorization': `Bearer ${data.token}`
          },
        });
        
        if (!response.ok) {
            if (response.status === 404) {
                 setMessage({
                    type: 'error',
                    text: `Eroare 404: Endpoint-ul GET nu a fost gasit. Aateptam ${url}` 
                });
            } else {
                 const errorData = await response.json().catch(() => ({ message: `Eroare HTTP ${response.status}` }));
                 setMessage({
                    type: 'error',
                    text: errorData.message || 'Eroare la incarcarea datelor curente.'
                });
            }
          }
        const profileData = await response.json();

        if (profileData) {
          setFormData({
            firstName: profileData.firstName || '',
            lastName: profileData.lastName || '',
            profilePictureUrl: profileData.profilePictureUrl || '',
            dateOfBirth: formatIsoDateToInput(profileData.dateOfBirth),
            studentId: String(profileData.studentId || '')
          });
        }
      } catch (error) {
        const errMsg = error instanceof Error ? error.message : String(error);
        setMessage({
          type: 'error',
          text: `Eroare de conexiune la server la GET.`
        });
      } finally {
        setLoading(false);
      }
    };
    
    fetchCurrentProfile();
  }, []);

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    if (!authData) {
        setMessage({ type: 'error', text: 'Sesiunea a expirat. Autentificați-vă din nou.' });
        return;
    }

    setIsSubmitting(true);
    setMessage(null);

    const payload = {
      ...formData,
      dateOfBirth: formData.dateOfBirth === '' ? null : formData.dateOfBirth,
      studentId: formData.studentId === '' ? null : formData.studentId,
    };

    const url = PUT_PROFILE_URL; 
    try {
      const response = await fetch(url, { 
        method: 'PUT', 
        headers: {
          'Content-Type': 'application/json',
          'Authorization': `Bearer ${authData.token}`
        },
        body: JSON.stringify(payload),
      });

      if (!response.ok) {
          if (response.status === 404) {
             setMessage({
                type: 'error',
                text: `Eroare 404: Endpoint-ul PUT nu a fost gasit.`
            });
          } else {
            let errorData;
            try {
              errorData = await response.json();
            } catch (e) {
              errorData = { message: `Eroare HTTP ${response.status}. Răspuns non-JSON.` };
            }
          const modelStateErrors = errorData?.errors 
                && typeof errorData.errors === 'object' 
                && !Array.isArray(errorData.errors) 
                ? Object.values(errorData.errors).flat().join(', ') 
                : null;
          const arrayErrors = Array.isArray(errorData?.errors) 
            ? errorData.errors.join(', ')
            : null;

          setMessage({
            type: 'error',
            text: modelStateErrors || arrayErrors || errorData.message || 'Eroare necunoscută la editarea profilului.'
          });
        }
          return;
      }
        
      const data = await response.json();

      if (data.message) {
        setMessage({
          type: 'success',
          text: data.message || 'Profilul a fost modificat cu succes. Redirecționare...'
        });
        
        const localUserData = localStorage.getItem('user');
        if(localUserData) {
            const updatedUser = { ...JSON.parse(localUserData), ...formData };
            localStorage.setItem('user', JSON.stringify(updatedUser));
        }

        if (typeof window !== 'undefined') {
            setTimeout(() => {
                window.location.href = '/profile'; 
            }, 1000); 
        }

      } else {
         setMessage({
          type: 'error',
          text: data.message || data.errors?.join(', ') || 'Eroare la editarea profilului.'
        });
      }
    } catch (error) {
      const errMsg = error instanceof Error ? error.message : String(error);
      setMessage({
        type: 'error',
        text: `Eroare de conexiune la server: ${errMsg}. Verificați adresa API (${API_BASE_URL}) și starea backend-ului.`
      });
    } finally {
      setIsSubmitting(false); 
    }
  };

  const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value
    });
  };

  if (loading) {
    return (
      <div>
        <p>Se încarcă datele curente...</p>
      </div>
    );
  }

  return (
    <div >
      <div className='container'>
        <h2>Modificare Profil</h2>

        {message && (
          <div 
            className={`p-3 mb-4 rounded-lg text-sm font-medium ${
              message.type === 'success' ? 'bg-green-100 text-green-700 border border-green-300' : 
              'bg-red-100 text-red-700 border border-red-300'
            }`}
          >
            {message.text}
          </div>
        )}

        <form onSubmit={handleSubmit} className="space-y-4">
          
          {/* Prenume */}
          <div className="flex flex-col space-y-1">
            <label htmlFor="firstName">Prenume</label>
            <input
              id="firstName"
              type="text"
              name="firstName"
              value={formData.firstName}
              onChange={handleChange}
              required
              placeholder="Prenume"
            />
          </div>

          {/* Nume */}
          <div className="flex flex-col space-y-1">
            <label htmlFor="lastName">Nume</label>
            <input
              id="lastName"
              type="text"
              name="lastName"
              value={formData.lastName}
              onChange={handleChange}
              required
              placeholder="Nume de familie"
             />
          </div>

          <div className="flex flex-col space-y-1">
                <label htmlFor="dateOfBirth">Data nasterii</label>
                <input id="dateOfBirth" type="date" name="dateOfBirth"
                    value={formData.dateOfBirth || ''} 
                    onChange={handleChange}/>
            </div>

          {/* Poza de profil (URL) */}
          <div className="flex flex-col space-y-1">
            <label htmlFor="profilePictureUrl" >Poza de profil (URL)</label>
            <input
              id="profilePictureUrl"
              type="text"
              name="profilePictureUrl"
              value={formData.profilePictureUrl || ''}
              onChange={handleChange}
              placeholder="link poza profil"  />
          </div>

            {/* Numar matricol */}
          <div className="flex flex-col space-y-1">
            <label htmlFor="studentId" >Numar Matricol</label>
            <input
              id="studentId"
              type="text"
              name="studentId"
              value={formData.studentId || ''}
              onChange={handleChange}
              placeholder="Numar matricol"  />
          </div>

          <button 
            type="submit" 
            disabled={isSubmitting || loading}
          >
            {isSubmitting ? 'Se procesează...' : 'Salvează modificările'}
          </button>
          
            <button
                onClick={() => (typeof window !== 'undefined' ? (window.location.href = '/profile') : null)}
            >
                Anuleaza
            </button>
        </form>
      </div>
    </div>
  );
}

export default EditProfile;