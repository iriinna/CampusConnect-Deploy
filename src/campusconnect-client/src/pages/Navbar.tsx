import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';

const Navbar = () => {
  const [query, setQuery] = useState('');
  const [category, setCategory] = useState('events'); // Default
  const navigate = useNavigate();

  const handleSearch = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    if (!query.trim()) return;
    
    // Redirecționăm către pagina corespunzătoare cu parametru de query
    // Exemplu: /events?search=party
    navigate(`/${category}?search=${encodeURIComponent(query)}`);
  };

  return (
    <nav className="navbar">
      <div className="nav-logo" onClick={() => navigate('/dashboard')}>
        CampusConnect
      </div>
      <form onSubmit={handleSearch} className="search-container">
        <select 
          value={category} 
          onChange={(e) => setCategory(e.target.value)}
          className="search-dropdown"
        >
          <option value="events">Events</option>
          <option value="announcements">Announcements</option>
          <option value="users">Users</option>
        </select>
        
        <input 
          type="text" 
          placeholder={`Search ${category}...`} 
          value={query}
          onChange={(e) => setQuery(e.target.value)}
          className="search-input"
        />
        <button type="submit" className="search-button">🔍</button>
      </form>

    </nav>
  );
};

export default Navbar;