import { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import { groupApi } from '../../services/groupApi';
import type { Group } from '../../services/groupApi';
import '../../index.css';

interface GroupCardProps {
  group: Group;
  onJoin?: (id: number) => void;
  onLeave?: (id: number) => void;
  onDelete?: (id: number) => void;
  onView: (id: number) => void;
  isProfessor: boolean;
  isAdmin: boolean;
  isOwner: boolean;
}

const GroupCard = ({ group, onJoin, onLeave, onDelete, onView, isProfessor, isAdmin, isOwner }: GroupCardProps) => {
  return (
    <div style={{
      border: '1px solid #ddd',
      borderRadius: '8px',
      padding: '20px',
      marginBottom: '15px',
      backgroundColor: 'white',
      boxShadow: '0 2px 4px rgba(0,0,0,0.1)'
    }}>
      <h3 style={{ margin: '0 0 10px 0', color: '#333' }}>{group.name}</h3>
      <p style={{ color: '#666', margin: '5px 0' }}>
        <strong>Materie:</strong> {group.subject}
      </p>
      <p style={{ color: '#666', margin: '5px 0' }}>
        <strong>Professor:</strong> {group.professorName}
      </p>
      {group.description && (
        <p style={{ color: '#666', margin: '5px 0', fontSize: '14px' }}>
          {group.description}
        </p>
      )}
      <div style={{ display: 'flex', gap: '10px', marginTop: '10px', alignItems: 'center' }}>
        <span style={{ fontSize: '14px', color: '#888' }}>
          👥 {group.membersCount} membri
        </span>
        <span style={{ fontSize: '14px', color: '#888' }}>
          📝 {group.tasksCount} taskuri
        </span>
      </div>
      
      <div style={{ display: 'flex', gap: '10px', marginTop: '15px', flexWrap: 'wrap' }}>
        <button
          onClick={() => onView(group.id)}
          style={{
            padding: '8px 16px',
            backgroundColor: '#007bff',
            color: 'white',
            border: 'none',
            borderRadius: '5px',
            cursor: 'pointer'
          }}
        >
          Vezi Detalii
        </button>

        {group.isUserMember && onLeave && !isOwner && (
          <button
            onClick={() => onLeave(group.id)}
            style={{
              padding: '8px 16px',
              backgroundColor: '#6c757d',
              color: 'white',
              border: 'none',
              borderRadius: '5px',
              cursor: 'pointer'
            }}
          >
            Părăsește Grupul
          </button>
        )}

        {!group.isUserMember && onJoin && (!isProfessor || isAdmin) && (
          <button
            onClick={() => onJoin(group.id)}
            style={{
              padding: '8px 16px',
              backgroundColor: '#28a745',
              color: 'white',
              border: 'none',
              borderRadius: '5px',
              cursor: 'pointer'
            }}
          >
            Intră în Grup
          </button>
        )}

        {isOwner && onDelete && (
          <button
            onClick={() => {
              if (window.confirm('Sigur vrei să ștergi acest grup?')) {
                onDelete(group.id);
              }
            }}
            style={{
              padding: '8px 16px',
              backgroundColor: '#dc3545',
              color: 'white',
              border: 'none',
              borderRadius: '5px',
              cursor: 'pointer'
            }}
          >
            Șterge Grup
          </button>
        )}
      </div>
    </div>
  );
};

const Groups = () => {
  const navigate = useNavigate();
  const [groups, setGroups] = useState<Group[]>([]);
  const [myGroups, setMyGroups] = useState<Group[]>([]);
  const [createdGroups, setCreatedGroups] = useState<Group[]>([]);
  const [availableGroups, setAvailableGroups] = useState<Group[]>([]);
  const [loading, setLoading] = useState(true);
  const [activeTab, setActiveTab] = useState<'all' | 'my' | 'available' | 'created'>('all');
  const [showCreateForm, setShowCreateForm] = useState(false);
  const [newGroup, setNewGroup] = useState({ name: '', description: '', subject: '' });

  const user = JSON.parse(localStorage.getItem('user') || '{}');
  const isProfessor = user.role === 'Professor';
  const isAdmin = user.role === 'Admin';
  const canCreateGroups = isProfessor || isAdmin;

  useEffect(() => {
    loadGroups();
  }, [activeTab]);

  const loadGroups = async () => {
    setLoading(true);
    try {
      switch (activeTab) {
        case 'all':
          const allGroups = await groupApi.getAllGroups();
          setGroups(allGroups);
          break;
        case 'my':
          const myGrps = await groupApi.getMyGroups();
          setMyGroups(myGrps);
          break;
        case 'available':
          const availGrps = await groupApi.getAvailableGroups();
          setAvailableGroups(availGrps);
          break;
        case 'created':
          if (canCreateGroups) {
            const createdGrps = await groupApi.getGroupsCreatedByMe();
            setCreatedGroups(createdGrps);
          }
          break;
      }
    } catch (error) {
      console.error('Error loading groups:', error);
      alert('Eroare la încărcarea grupurilor');
    } finally {
      setLoading(false);
    }
  };

  const handleJoinGroup = async (id: number) => {
    try {
      await groupApi.joinGroup(id);
      alert('Ai intrat în grup cu succes!');
      loadGroups();
    } catch (error) {
      console.error('Error joining group:', error);
      alert('Eroare la intrarea în grup');
    }
  };

  const handleLeaveGroup = async (id: number) => {
    try {
      await groupApi.leaveGroup(id);
      alert('Ai părăsit grupul');
      loadGroups();
    } catch (error) {
      console.error('Error leaving group:', error);
      alert('Eroare la părăsirea grupului');
    }
  };

  const handleDeleteGroup = async (id: number) => {
    try {
      await groupApi.deleteGroup(id);
      alert('Grupul a fost șters');
      loadGroups();
    } catch (error) {
      console.error('Error deleting group:', error);
      alert('Eroare la ștergerea grupului');
    }
  };

  const handleCreateGroup = async (e: React.FormEvent) => {
    e.preventDefault();
    try {
      await groupApi.createGroup(newGroup);
      alert('Grupul a fost creat cu succes!');
      setShowCreateForm(false);
      setNewGroup({ name: '', description: '', subject: '' });
      loadGroups();
    } catch (error) {
      console.error('Error creating group:', error);
      alert('Eroare la crearea grupului');
    }
  };

  const handleViewGroup = (id: number) => {
    navigate(`/groups/${id}`);
  };

  const tabStyle = (isActive: boolean) => ({
    padding: '10px 20px',
    backgroundColor: isActive ? '#007bff' : '#f8f9fa',
    color: isActive ? 'white' : '#333',
    border: 'none',
    borderRadius: '5px 5px 0 0',
    cursor: 'pointer',
    marginRight: '5px',
    fontWeight: isActive ? 'bold' : 'normal'
  });

  const getCurrentGroups = () => {
    switch (activeTab) {
      case 'all': return groups;
      case 'my': return myGroups;
      case 'available': return availableGroups;
      case 'created': return createdGroups;
      default: return [];
    }
  };

  return (
    <div className="container">
      <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '20px' }}>
        <h1>Grupuri</h1>
        <div>
          {canCreateGroups && (
            <button
              onClick={() => setShowCreateForm(!showCreateForm)}
              style={{
                padding: '10px 20px',
                backgroundColor: '#28a745',
                color: 'white',
                border: 'none',
                borderRadius: '5px',
                cursor: 'pointer',
                marginRight: '10px'
              }}
            >
              {showCreateForm ? 'Anulează' : '+ Creează Grup'}
            </button>
          )}
        </div>
      </div>

      {showCreateForm && (
        <div style={{
          backgroundColor: 'white',
          padding: '20px',
          borderRadius: '8px',
          marginBottom: '20px',
          boxShadow: '0 2px 4px rgba(0,0,0,0.1)'
        }}>
          <h3>Creează Grup Nou</h3>
          <form onSubmit={handleCreateGroup}>
            <div style={{ marginBottom: '15px' }}>
              <label style={{ display: 'block', marginBottom: '5px' }}>Nume Grup *</label>
              <input
                type="text"
                value={newGroup.name}
                onChange={(e) => setNewGroup({ ...newGroup, name: e.target.value })}
                required
                style={{ width: '100%', padding: '8px', borderRadius: '5px', border: '1px solid #ddd' }}
              />
            </div>
            <div style={{ marginBottom: '15px' }}>
              <label style={{ display: 'block', marginBottom: '5px' }}>Materie *</label>
              <input
                type="text"
                value={newGroup.subject}
                onChange={(e) => setNewGroup({ ...newGroup, subject: e.target.value })}
                required
                style={{ width: '100%', padding: '8px', borderRadius: '5px', border: '1px solid #ddd' }}
              />
            </div>
            <div style={{ marginBottom: '15px' }}>
              <label style={{ display: 'block', marginBottom: '5px' }}>Descriere</label>
              <textarea
                value={newGroup.description}
                onChange={(e) => setNewGroup({ ...newGroup, description: e.target.value })}
                rows={3}
                style={{ width: '100%', padding: '8px', borderRadius: '5px', border: '1px solid #ddd' }}
              />
            </div>
            <button
              type="submit"
              style={{
                padding: '10px 20px',
                backgroundColor: '#28a745',
                color: 'white',
                border: 'none',
                borderRadius: '5px',
                cursor: 'pointer'
              }}
            >
              Creează Grup
            </button>
          </form>
        </div>
      )}

      <div style={{ marginBottom: '20px' }}>
        <button onClick={() => setActiveTab('all')} style={tabStyle(activeTab === 'all')}>
          Toate Grupurile
        </button>
        {/* Studenții și adminii pot vedea Grupurile Mele și Grupuri Disponibile */}
        {(!isProfessor || isAdmin) && (
          <>
            <button onClick={() => setActiveTab('my')} style={tabStyle(activeTab === 'my')}>
              Grupurile Mele
            </button>
            <button onClick={() => setActiveTab('available')} style={tabStyle(activeTab === 'available')}>
              Grupuri Disponibile
            </button>
          </>
        )}
        {canCreateGroups && (
          <button onClick={() => setActiveTab('created')} style={tabStyle(activeTab === 'created')}>
            Grupurile Create de Mine
          </button>
        )}
      </div>

      {loading ? (
        <p>Se încarcă...</p>
      ) : (
        <div>
          {getCurrentGroups().length === 0 ? (
            <p style={{ textAlign: 'center', color: '#888', padding: '40px' }}>
              Nu există grupuri în această categorie
            </p>
          ) : (
            getCurrentGroups().map(group => (
              <GroupCard
                key={group.id}
                group={group}
                onJoin={activeTab === 'available' ? handleJoinGroup : undefined}
                onLeave={activeTab === 'my' ? handleLeaveGroup : undefined}
                onDelete={activeTab === 'created' ? handleDeleteGroup : undefined}
                onView={handleViewGroup}
                isProfessor={isProfessor}
                isAdmin={isAdmin}
                isOwner={group.professorId === user.id}
              />
            ))
          )}
        </div>
      )}
    </div>
  );
};

export default Groups;
