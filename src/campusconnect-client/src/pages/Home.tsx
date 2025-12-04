
function Home() {
  const user = JSON.parse(localStorage.getItem('user') || '{}');
  
  return (
    <div style={{ padding: '40px', textAlign: 'center' }}>
      <h1>Dashboard - CampusConnect</h1>
      <p>Bun venit, {user.firstName} {user.lastName}!</p>
      <p>Email: {user.email}</p>
      <button
        onClick={() => {
          window.location.href = '/profile';
        }}
      >
        View Profile
      </button>
      <button 
        onClick={() => {
          localStorage.clear();
          window.location.href = '/login';
        }}
        style={{
          padding: '10px 20px',
          background: '#dc3545',
          color: 'white',
          border: 'none',
          borderRadius: '5px',
          cursor: 'pointer',
          marginTop: '20px'
        }}
      >
        Logout
      </button>
    </div>
  );
}

export default Home;
