import { useEffect, useState } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import '../Auth.css'; 

const API_BASE_URL = 'http://localhost:5099/api';

interface EventFormData {
  title: string;
  description: string;
  category: string;
  date: string;
  location: string;
}

function EditEvent() {
  const { id } = useParams<{ id: string }>(); 
  const navigate = useNavigate();

  const [formData, setFormData] = useState<EventFormData>({
    title: '',
    description: '',
    category: '',
    date: '',
    location: ''
  });

  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');

  useEffect(() => {
    const fetchEvent = async () => {
      try {
        const response = await fetch(`${API_BASE_URL}/event/${id}`);
        if (!response.ok) throw new Error('Nu s-a putut gasi evenimentul');
        
        const data = await response.json();
        const formattedDate = data.date ? new Date(data.date).toISOString().slice(0, 16) : '';

        setFormData({
          title: data.title,
          description: data.description,
          category: data.category || '', // Fallback dacă e null
          date: formattedDate,
          location: data.location
        });
      } catch (err) {
        setError('Eroare la incarcarea datelor.');
      } finally {
        setLoading(false);
      }
    };

    fetchEvent();
  }, [id]);

  const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value
    });
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    
    const token = localStorage.getItem('token');
    if (!token) {
      alert("Nu esti autentificat!");
      return;
    }

    try {
      // 2. Trimitem cererea de PUT (Update)
      const response = await fetch(`${API_BASE_URL}/event/${id}`, {
        method: 'PUT',
        headers: {
          'Content-Type': 'application/json',
          'Authorization': `Bearer ${token}`
        },
        // Trimitem ID-ul și restul datelor. Backend-ul se așteaptă la un obiect complet.
        body: JSON.stringify({ id: Number(id), ...formData }),
      });

      if (response.ok) {
        alert("Eveniment actualizat cu succes!");
        navigate(`/event/${id}`); 
      } else {
        const errData = await response.json().catch(() => null);
        alert(errData?.title || "Eroare la actualizare. Verifica daca esti organizatorul.");
      }
    } catch (error) {
      console.error(error);
      alert("Eroare de conexiune.");
    }
  };

  if (loading) return <div>Se încarcă datele...</div>;
  if (error) return <div className="error">{error}</div>;

  return (
    <div className="auth-container">
      <div className="auth-card">
        <h2>Editeaza Evenimentul</h2>
        
        <form onSubmit={handleSubmit}>
          <div className="form-group">
            <label>Nume </label>
            <input
              type="text"
              name="title"
              value={formData.title}
              onChange={handleChange}
              required
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
            />
          </div>

          <div className="form-group">
            <label>Descriere</label>
            <textarea
              name="description"
              value={formData.description}
              onChange={handleChange}
              required
              rows={4}
              style={{ width: '100%', padding: '8px' }}
            />
          </div>

          <div className="form-group">
            <label>Data si Ora</label>
            <input
              type="datetime-local"
              name="date"
              value={formData.date}
              onChange={handleChange}
              required
            />
          </div>

          <div style={{ display: 'flex', gap: '10px', marginTop: '20px' }}>
            <button type="submit" className="btn-primary">Salveaza</button>
            <button 
              type="button" 
              className="btn-secondary" 
              onClick={() => navigate(`/event/${id}`)}
              style={{ backgroundColor: '#6c757d' }}
            >
              Anuleaza
            </button>
          </div>
        </form>
      </div>
    </div>
  );
}

export default EditEvent;