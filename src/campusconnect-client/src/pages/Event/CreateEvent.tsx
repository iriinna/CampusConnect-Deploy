import { useState } from 'react';
import { useNavigate } from 'react-router-dom'; 
import '../../index.css'; 

const API_BASE_URL = 'http://localhost:5099/api';

interface EventFormData {
  title: string;
  description: string;
  category: string;
  date: string;
  location: string;
}

function CreateEvent() {
  const navigate = useNavigate();

  const [formData, setFormData] = useState<EventFormData>({
    title: '',
    description: '',
    category: '',
    date: '',
    location: ''
  });

  const [loading, setLoading] = useState(false);
  const [message, setMessage] = useState<{ type: 'success' | 'error'; text: string } | null>(null);

  const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value
    });
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setLoading(true);
    setMessage(null);

    const token = localStorage.getItem('token');

    if (!token) {
      setMessage({ type: 'error', text: 'Nu esti autentificat!' });
      setLoading(false);
      return;
    }

    try {
      const response = await fetch(`${API_BASE_URL}/event`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
          'Authorization': `Bearer ${token}` 
        },
        body: JSON.stringify(formData),
      });

      if (response.ok) {
        setMessage({
          type: 'success',
          text: 'Eveniment creat cu succes!'
        });

        setTimeout(() => {
          navigate('/dashboard'); 
        }, 1500);

      } else {
        const errorData = await response.json().catch(() => null);
        console.log("Eroare Backend:", errorData); 
        const errorMessage = errorData?.message || JSON.stringify(errorData?.errors) || 'Eroare necunoscută';
        
        setMessage({
            type: 'error',
            text: errorMessage
        });

      }
    } catch (error) {
      console.error(error);
      setMessage({
        type: 'error',
        text: 'Eroare de conexiune la server.'
      });
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="auth-container">
      <div className="auth-card">
        <h2>Creează Eveniment</h2>

        {message && (
          <div className={`message ${message.type}`}>
            {message.text}
          </div>
        )}

        <form onSubmit={handleSubmit}>
          <div className="form-group">
            <label>Nume Eveniment</label>
            <input
              type="text"
              name="title" 
              value={formData.title}
              onChange={handleChange}
              required
              placeholder="Titlu eveniment"
            />
          </div>

          <div className="form-group">
            <label>Categorie</label>
            <input
              type="text"
              name="category"
              value={formData.category}
              onChange={handleChange}
              required
              placeholder="Categorie eveniment"
            />
          </div>

          <div className="form-group">
            <label>Descriere</label>
            <textarea
              name="description"
              value={formData.description}
              onChange={handleChange}
              required
              placeholder="Detalii despre eveniment..."
              rows={4}
              style={{ width: '100%', padding: '8px' }}
            />
          </div>

          <div className="form-group">
            <label>Data și Ora</label>
            <input
              type="datetime-local" 
              name="date"
              value={formData.date}
              onChange={handleChange}
              required
            />
          </div>

          <button type="submit" className="btn-primary" disabled={loading}>
            {loading ? 'Se creeaza...' : 'Creeaza Eveniment'}
          </button>
        </form>
      </div>
    </div>
  );
}

export default CreateEvent;