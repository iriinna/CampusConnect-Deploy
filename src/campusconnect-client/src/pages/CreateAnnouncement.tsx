import React, { useState } from 'react';
const API_BASE_URL = 'http://localhost:5099/api';

const CreateAnnouncement: React.FC = () => {
  const [title, setTitle] = useState('');
  const [content, setContent] = useState('');
  const [adding, setAdding] = useState(false);

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    if (!title || !content) return;

    setAdding(true);
    try {
      const response = await fetch(`${API_BASE_URL}/announcements`, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ title, content }),
      });

      if (response.ok) {
        window.location.href = '/announcements'; // redirect la listă
      } else {
        console.error('Eroare la adăugarea anunțului');
      }
    } catch (error) {
      console.error('Eroare de conexiune:', error);
    } finally {
      setAdding(false);
    }
  };

  return (
    <div className="container" style={{ paddingTop: '80px', position: 'relative' }}>
  {/* Butonul „Înapoi” fixat în colț */}
  <button
  onClick={() => window.location.href = '/announcements'}
  style={{
    position: 'fixed',
    top: '15px',
    left: '15px',
    padding: '2px 4px',
    fontSize: '12px',
    border: '1px solid #ccc',
    backgroundColor: '#007BFF', 
    color: '#333',
    cursor: 'pointer',
    borderRadius: '0',
    lineHeight: '1',
    width: '30px',   // lățime fixă
    height: '25px',  // înălțime fixă
    textAlign: 'center',
    fontWeight: 'bold',
    zIndex: 1000,
  }}
  onMouseOver={(e) => {
    e.currentTarget.style.backgroundColor = '#f5f5f5';
    e.currentTarget.style.borderColor = '#999';
  }}
  onMouseOut={(e) => {
    e.currentTarget.style.backgroundColor = '#fff';
    e.currentTarget.style.borderColor = '#ccc';
  }}
>
  ←
</button>


      <h1>Create announcement</h1>

      <form onSubmit={handleSubmit}>
        <input
          type="text"
          placeholder="Title"
          value={title}
          onChange={e => setTitle(e.target.value)}
          required
          style={{ width: '100%', padding: '10px', marginBottom: '10px' }}
        />
        <textarea
          placeholder="Content"
          value={content}
          onChange={e => setContent(e.target.value)}
          required
          style={{ width: '100%', padding: '10px', marginBottom: '10px', minHeight: '100px' }}
        />
        <button type="submit" disabled={adding} style={{ padding: '10px 20px' }}>
          {adding ? 'Add...' : 'Add Announcement'}
        </button>
      </form>
    </div>
  );
};

export default CreateAnnouncement;
