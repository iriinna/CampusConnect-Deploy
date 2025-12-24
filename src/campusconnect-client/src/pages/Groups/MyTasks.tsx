import { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import { groupApi } from '../../services/groupApi';
import type { SavedTask } from '../../services/groupApi';
import '../../index.css';

const MyTasks = () => {
  const navigate = useNavigate();
  const [tasks, setTasks] = useState<SavedTask[]>([]);
  const [loading, setLoading] = useState(true);
  const [filter, setFilter] = useState<'all' | 'pending' | 'completed'>('all');

  useEffect(() => {
    loadTasks();
  }, []);

  const loadTasks = async () => {
    setLoading(true);
    try {
      const tasksData = await groupApi.getMySavedTasks();
      setTasks(tasksData);
    } catch (error) {
      console.error('Error loading tasks:', error);
      alert('Eroare la încărcarea taskurilor');
    } finally {
      setLoading(false);
    }
  };

  const handleToggleComplete = async (taskId: number, isCompleted: boolean) => {
    try {
      if (isCompleted) {
        await groupApi.markTaskAsIncomplete(taskId);
      } else {
        await groupApi.markTaskAsCompleted(taskId);
      }
      loadTasks();
    } catch (error) {
      console.error('Error toggling task completion:', error);
      alert('Eroare la actualizarea task-ului');
    }
  };

  const handleRemoveTask = async (taskId: number) => {
    if (window.confirm('Sigur vrei să elimini acest task din lista ta?')) {
      try {
        await groupApi.unsaveTask(taskId);
        alert('Task eliminat din lista ta');
        loadTasks();
      } catch (error) {
        console.error('Error removing task:', error);
        alert('Eroare la eliminarea task-ului');
      }
    }
  };

  const formatDate = (date?: string) => {
    if (!date) return null;
    return new Date(date).toLocaleDateString('ro-RO', {
      year: 'numeric',
      month: 'long',
      day: 'numeric',
      hour: '2-digit',
      minute: '2-digit'
    });
  };

  const getFilteredTasks = () => {
    switch (filter) {
      case 'pending':
        return tasks.filter(t => !t.isCompleted);
      case 'completed':
        return tasks.filter(t => t.isCompleted);
      default:
        return tasks;
    }
  };

  const filteredTasks = getFilteredTasks();
  const pendingCount = tasks.filter(t => !t.isCompleted).length;
  const completedCount = tasks.filter(t => t.isCompleted).length;

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

  return (
    <div className="container">
      <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '20px' }}>
        <h1>Taskurile Mele (TO-DO)</h1>
      </div>

      <div style={{
        backgroundColor: 'white',
        padding: '15px',
        borderRadius: '8px',
        marginBottom: '20px',
        display: 'flex',
        gap: '20px',
        justifyContent: 'center'
      }}>
        <div style={{ textAlign: 'center' }}>
          <div style={{ fontSize: '24px', fontWeight: 'bold', color: '#007bff' }}>{tasks.length}</div>
          <div style={{ fontSize: '14px', color: '#666' }}>Total Taskuri</div>
        </div>
        <div style={{ textAlign: 'center' }}>
          <div style={{ fontSize: '24px', fontWeight: 'bold', color: '#ffc107' }}>{pendingCount}</div>
          <div style={{ fontSize: '14px', color: '#666' }}>În Așteptare</div>
        </div>
        <div style={{ textAlign: 'center' }}>
          <div style={{ fontSize: '24px', fontWeight: 'bold', color: '#28a745' }}>{completedCount}</div>
          <div style={{ fontSize: '14px', color: '#666' }}>Completate</div>
        </div>
      </div>

      <div style={{ marginBottom: '20px' }}>
        <button onClick={() => setFilter('all')} style={tabStyle(filter === 'all')}>
          Toate ({tasks.length})
        </button>
        <button onClick={() => setFilter('pending')} style={tabStyle(filter === 'pending')}>
          În Așteptare ({pendingCount})
        </button>
        <button onClick={() => setFilter('completed')} style={tabStyle(filter === 'completed')}>
          Completate ({completedCount})
        </button>
      </div>

      {loading ? (
        <p>Se încarcă...</p>
      ) : (
        <div>
          {filteredTasks.length === 0 ? (
            <p style={{ textAlign: 'center', color: '#888', padding: '40px' }}>
              {filter === 'all' 
                ? 'Nu ai taskuri salvate. Intră într-un grup și salvează taskuri pentru a le vedea aici!'
                : filter === 'pending'
                ? 'Nu ai taskuri în așteptare'
                : 'Nu ai taskuri completate'}
            </p>
          ) : (
            filteredTasks.map(task => (
              <div
                key={task.id}
                style={{
                  border: '1px solid #ddd',
                  borderRadius: '8px',
                  padding: '15px',
                  marginBottom: '15px',
                  backgroundColor: task.isCompleted ? '#e8f5e9' : 'white',
                  boxShadow: '0 2px 4px rgba(0,0,0,0.1)'
                }}
              >
                <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'start' }}>
                  <div style={{ flex: 1 }}>
                    <div style={{ display: 'flex', alignItems: 'center', gap: '10px', marginBottom: '10px' }}>
                      <input
                        type="checkbox"
                        checked={task.isCompleted}
                        onChange={() => handleToggleComplete(task.taskId, task.isCompleted)}
                        style={{ width: '20px', height: '20px', cursor: 'pointer' }}
                      />
                      <h4 style={{
                        margin: 0,
                        color: '#333',
                        textDecoration: task.isCompleted ? 'line-through' : 'none'
                      }}>
                        {task.taskTitle}
                      </h4>
                    </div>
                    
                    {task.taskDescription && (
                      <p style={{ color: '#666', margin: '5px 0 5px 30px', fontSize: '14px' }}>
                        {task.taskDescription}
                      </p>
                    )}
                    
                    <div style={{ marginLeft: '30px', marginTop: '10px', fontSize: '13px', color: '#888' }}>
                      <p style={{ margin: '3px 0' }}>
                        📚 <strong>{task.groupName}</strong> - {task.subject}
                      </p>
                      {task.dueDate && (
                        <p style={{
                          margin: '3px 0',
                          color: new Date(task.dueDate) < new Date() && !task.isCompleted ? '#dc3545' : '#888'
                        }}>
                          📅 Deadline: {formatDate(task.dueDate)}
                          {new Date(task.dueDate) < new Date() && !task.isCompleted && ' (Întârziat!)'}
                        </p>
                      )}
                      <p style={{ margin: '3px 0' }}>
                        💾 Salvat: {formatDate(task.savedAt)}
                      </p>
                      {task.isCompleted && task.completedAt && (
                        <p style={{ margin: '3px 0', color: '#28a745' }}>
                          ✓ Completat: {formatDate(task.completedAt)}
                        </p>
                      )}
                    </div>
                  </div>

                  <button
                    onClick={() => handleRemoveTask(task.taskId)}
                    style={{
                      padding: '6px 12px',
                      backgroundColor: '#dc3545',
                      color: 'white',
                      border: 'none',
                      borderRadius: '5px',
                      cursor: 'pointer',
                      fontSize: '13px',
                      marginLeft: '10px'
                    }}
                  >
                    Elimină
                  </button>
                </div>
              </div>
            ))
          )}
        </div>
      )}
    </div>
  );
};

export default MyTasks;
