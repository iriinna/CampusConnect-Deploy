import { useState } from 'react';
import './Auth.css';

const API_BASE_URL = 'http://localhost:5099/api';

interface RegisterData {
  email: string;
  password: string;
  confirmPassword: string;
  firstName: string;
  lastName: string;
}

export default function Register() {
  const [formData, setFormData] = useState<RegisterData>({
    email: '',
    password: '',
    confirmPassword: '',
    firstName: '',
    lastName: ''
  });
  const [loading, setLoading] = useState(false);
  const [message, setMessage] = useState<{ type: 'success' | 'error'; text: string } | null>(null);

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setLoading(true);
    setMessage(null);

    try {
      const response = await fetch(`${API_BASE_URL}/auth/register`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(formData),
      });

      const data = await response.json();

      if (response.ok && data.success) {
        setMessage({
          type: 'success',
          text: data.message || 'Cont creat! Verifică-ți emailul pentru confirmare.'
        });
        setFormData({
          email: '',
          password: '',
          confirmPassword: '',
          firstName: '',
          lastName: ''
        });
      } else {
        setMessage({
          type: 'error',
          text: data.message || data.errors?.join(', ') || 'Eroare la înregistrare'
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
        <h2>Înregistrare CampusConnect</h2>
        <p className="auth-subtitle">Doar pentru studenți @unibuc.ro</p>

        {message && (
          <div className={`message ${message.type}`}>
            {message.text}
          </div>
        )}

        <form onSubmit={handleSubmit}>
          <div className="form-group">
            <label>Prenume</label>
            <input
              type="text"
              name="firstName"
              value={formData.firstName}
              onChange={handleChange}
              required
              placeholder="Ion"
            />
          </div>

          <div className="form-group">
            <label>Nume</label>
            <input
              type="text"
              name="lastName"
              value={formData.lastName}
              onChange={handleChange}
              required
              placeholder="Popescu"
            />
          </div>

          <div className="form-group">
            <label>Email UniBuc</label>
            <input
              type="email"
              name="email"
              value={formData.email}
              onChange={handleChange}
              required
              placeholder="ion.popescu@s.unibuc.ro"
            />
            <small>Folosește adresa @unibuc.ro sau @s.unibuc.ro</small>
          </div>

          <div className="form-group">
            <label>Parolă</label>
            <input
              type="password"
              name="password"
              value={formData.password}
              onChange={handleChange}
              required
              minLength={8}
              placeholder="Min. 8 caractere"
            />
          </div>

          <div className="form-group">
            <label>Confirmă Parola</label>
            <input
              type="password"
              name="confirmPassword"
              value={formData.confirmPassword}
              onChange={handleChange}
              required
              placeholder="Repetă parola"
            />
          </div>

          <button type="submit" className="btn-primary" disabled={loading}>
            {loading ? 'Se procesează...' : 'Creează Cont'}
          </button>
        </form>

        <div className="auth-footer">
          Ai deja cont? <a href="/login">Loghează-te</a>
        </div>
      </div>
    </div>
  );
}
