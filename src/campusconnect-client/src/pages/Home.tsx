import '../index.css'

function Home() {
  const user = JSON.parse(localStorage.getItem('user') || '{}');

  const buttonStyle = {
    padding: '12px 25px',
    fontSize: '16px',
    border: 'none',
    borderRadius: '5px',
    cursor: 'pointer',
    margin: '10px'
  };

  return (
    <div className="container" style={{ textAlign: 'center' }}>
      <h1>Dashboard - CampusConnect</h1>
      <p>Bun venit, {user.firstName} {user.lastName}!</p>
      <p>Email: {user.email}</p>

      <div style={{ display: 'flex', justifyContent: 'center', flexWrap: 'wrap', marginTop: '20px' }}>
        <button
          onClick={() => { window.location.href = '/profile'; }}
          style={{ ...buttonStyle, background: '#007bff', color: 'white' }}
        >
          View Profile
        </button>

        <button
          onClick={() => { window.location.href = '/announcements'; }}
          style={{ ...buttonStyle, background: '#28a745', color: 'white' }}
        >
          View Announcements
        </button>

        <button
          onClick={() => { window.location.href = '/events'; }}
          style={{ ...buttonStyle, background: '#17a2b8', color: 'white' }}
        >
          View Events
        </button>

        <button
          onClick={() => {
            localStorage.clear();
            window.location.href = '/login';
          }}
          style={{ ...buttonStyle, background: '#dc3545', color: 'white' }}
        >
          Logout
        </button>
      </div>
    </div>
  );
}

export default Home;
