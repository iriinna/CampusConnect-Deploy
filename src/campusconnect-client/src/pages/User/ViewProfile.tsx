import React, { useState } from 'react';
import '../../index.css';

// URL-ul de bază al API-ului
const API_BASE_URL = 'http://localhost:5099/api';
const DELETE_PROFILE_URL = `${API_BASE_URL}/user/delete`; 

function ProfileView() {
    const [message, setMessage] = useState<{ type: 'success' | 'error'; text: string } | null>(null);
    const [isDeleting, setIsDeleting] = useState(false);
    
    // Extragem datele și token-ul din localStorage
    const user = JSON.parse(localStorage.getItem('user') || '{}');
    const token = localStorage.getItem('token'); 

    // Verificăm dacă utilizatorul este valid
    if (!user.firstName || !token) {
        return <div style={{ padding: '40px', textAlign: 'center' }}>
            <p style={{ color: 'red' }}>Nu ești autentificat. Te rugăm să te loghezi.</p>
            <button onClick={() => window.location.href = '/login'}>Mergi la Login</button>
        </div>
    }

    const handleDeleteAccount = async () => {
        const confirmed = window.confirm(
            "Esti sigur ca vrei sa stergi acest cont? Aceasta actiune este ireversibila!"
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
                    'Authorization': `Bearer ${token}` 
                },
            });

            if (response.status === 204) {
                setMessage({
                    type: 'success',
                    text: 'Contul a fost sters cu succes! Redirectionare in scurt timp...'
                });
                
                localStorage.removeItem('user');
                localStorage.removeItem('token'); 
                
                if (typeof window !== 'undefined') {
                    setTimeout(() => {
                        window.location.href = '/login';
                    }, 2000); 
                }

            } else {
                const errorText = response.status === 404 
                    ? "Contul nu a putut fi gasit (posibil deja sters)."
                    : response.status === 401 
                    ? "Sesiune expirata. Va rugam sa va autentificati din nou."
                    : `Eroare HTTP ${response.status}.`;
                
                let errorData = null;
                try {
                    errorData = await response.json();
                } catch (e) {}
                
                setMessage({
                    type: 'error',
                    text: errorData?.message || errorText
                });
            }
        } catch (error) {
            const errMsg = error instanceof Error ? error.message : String(error);
            setMessage({
                type: 'error',
                text: `Eroare de conexiune la server: ${errMsg}.`
            });
        } finally {
            setIsDeleting(false);
        }
    };
    
    return (
        <div className='container'>
            
            <h2>{user.firstName} {user.lastName}</h2>
            <p>Email: {user.email}</p>
            <p>Date of birth: {user.dateOfBirth || ''}</p>
            <p>Student ID: {user.studentId || ''}</p>

            <button 
                onClick={() => window.location.href = '/edit-profile'}
                disabled={isDeleting}
            >
                Editeaza profilul
            </button>

            <button 
                onClick={handleDeleteAccount}
                style={{
                    background: '#dc3545',
                    opacity: isDeleting ? 0.6 : 1,
                    cursor: isDeleting ? 'not-allowed' : 'pointer'
                }}
                disabled={isDeleting}
            >
                {isDeleting ? 'Se Sterge...' : 'Sterge contul'}
            </button>
        </div>
    );
}

export default ProfileView;