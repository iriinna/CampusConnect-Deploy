import { useEffect, useState } from 'react';
import { useSearchParams } from 'react-router-dom';
import './Auth.css';

const API_BASE_URL = 'http://localhost:5099/api';

export default function ConfirmEmail() {
  const [searchParams] = useSearchParams();
  const [status, setStatus] = useState<'loading' | 'success' | 'error'>('loading');
  const [message, setMessage] = useState('');

  useEffect(() => {
    const confirmEmail = async () => {
      const userId = searchParams.get('userId');
      const token = searchParams.get('token');

      if (!userId || !token) {
        setStatus('error');
        setMessage('Link invalid - lipsesc parametri');
        return;
      }

      try {
        const response = await fetch(
          `${API_BASE_URL}/auth/confirm-email?userId=${userId}&token=${encodeURIComponent(token)}`
        );

        const data = await response.json();

        if (response.ok && data.success) {
          setStatus('success');
          setMessage(data.message || 'Email confirmat cu succes!');
        } else {
          setStatus('error');
          setMessage(data.message || 'Eroare la confirmare');
        }
      } catch (error) {
        setStatus('error');
        setMessage('Eroare de conexiune la server');
      }
    };

    confirmEmail();
  }, [searchParams]);

  return (
    <div className="auth-container">
      <div className="auth-card">
        <h2>Confirmare Email</h2>

        {status === 'loading' && (
          <div className="message">
            Se verifică token-ul...
          </div>
        )}

        {status === 'success' && (
          <>
            <div className="message success">
              ✓ {message}
            </div>
            <p style={{ textAlign: 'center', marginTop: '20px' }}>
              <a href="/login" className="btn-primary" style={{ display: 'inline-block', textDecoration: 'none', padding: '12px 24px' }}>
                Mergi la Login
              </a>
            </p>
          </>
        )}

        {status === 'error' && (
          <>
            <div className="message error">
              ✗ {message}
            </div>
            <p style={{ textAlign: 'center', marginTop: '20px' }}>
              <a href="/register" style={{ color: '#667eea', textDecoration: 'none' }}>
                Încearcă din nou
              </a>
            </p>
          </>
        )}
      </div>
    </div>
  );
}
