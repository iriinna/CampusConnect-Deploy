import { useState } from 'react';
import './Auth.css';

const API_BASE_URL = 'http://localhost:5099/api';

interface LoginData {
  email: string;
  password: string;
}

export default function Login() {
  const [formData, setFormData] = useState<LoginData>({
    email: '',
    password: ''
  });
  const [loading, setLoading] = useState(false);
  const [message, setMessage] = useState<{ type: 'success' | 'error'; text: string } | null>(null);

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setLoading(true);
    setMessage(null);

    try {
      const response = await fetch(`${API_BASE_URL}/auth/login`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(formData),
      });

      const data = await response.json();

      if (response.ok && data.success) {
        // Salvează token-ul
        localStorage.setItem('token', data.data.token);
        localStorage.setItem('user', JSON.stringify(data.data));
        
        setMessage({
          type: 'success',
          text: `Bun venit, ${data.data.firstName}!`
        });

        // Redirect după 1 secundă
        setTimeout(() => {
          window.location.href = '/dashboard';
        }, 1000);
      } else {
        setMessage({
          type: 'error',
          text: data.message || 'Email sau parolă incorectă'
        });
      }
    } catch (error) {
      setMessage({
        type: 'error',
        text: 'Eroare de conexiune la server'
      });
    } finally {
      setLoading(false);
    }
  };

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value
    });
  };

  return (
    <div className="auth-container">
      <div className="auth-card">
        <h2>Login CampusConnect</h2>
        <p className="auth-subtitle">Bun venit înapoi!</p>

        {message && (
          <div className={`message ${message.type}`}>
            {message.text}
          </div>
        )}

        <form onSubmit={handleSubmit}>
          <div className="form-group">
            <label>Email</label>
            <input
              type="email"
              name="email"
              value={formData.email}
              onChange={handleChange}
              required
              placeholder="ion.popescu@s.unibuc.ro"
            />
          </div>

          <div className="form-group">
            <label>Parolă</label>
            <input
              type="password"
              name="password"
              value={formData.password}
              onChange={handleChange}
              required
              placeholder="Parola ta"
            />
          </div>

          <button type="submit" className="btn-primary" disabled={loading}>
            {loading ? 'Se verifică...' : 'Login'}
          </button>
        </form>

        <div className="auth-footer">
          Nu ai cont? <a href="/register">Înregistrează-te</a>
        </div>
      </div>
    </div>
  );
}
