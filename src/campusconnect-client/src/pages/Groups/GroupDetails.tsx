import { useState, useEffect, useMemo } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { groupApi } from '../../services/groupApi';
import type { Group, GroupTask } from '../../services/groupApi';
import '../../index.css';

interface TaskCardProps {
  task: GroupTask;
  onSave?: (id: number) => void;
  onUnsave?: (id: number) => void;
  onComplete?: (id: number) => void;
  onIncomplete?: (id: number) => void;
  onDelete?: (id: number) => void;
  isProfessor: boolean;
  isGroupOwner: boolean;
}

const TaskCard = ({ task, onSave, onUnsave, onComplete, onIncomplete, onDelete, isProfessor, isGroupOwner }: TaskCardProps) => {
  const formatDate = (date?: string) => {
    if (!date) return null;
    return new Date(date).toLocaleDateString('ro-RO', {
      year: 'numeric',
      month: 'long',
      day: 'numeric'
    });
  };

  return (
    <div style={{
      border: '1px solid #ddd',
      borderRadius: '8px',
      padding: '15px',
      marginBottom: '15px',
      backgroundColor: task.isCompleted ? '#e8f5e9' : 'white',
      boxShadow: '0 2px 4px rgba(0,0,0,0.1)'
    }}>
      <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'start' }}>
        <div style={{ flex: 1 }}>
          <h4 style={{ margin: '0 0 10px 0', color: '#333' }}>
            {task.isCompleted && '✓ '}
            {task.title}
          </h4>
          {task.description && (
            <p style={{ color: '#666', margin: '5px 0', fontSize: '14px' }}>
              {task.description}
            </p>
          )}
          <div style={{ marginTop: '10px', fontSize: '13px', color: '#888' }}>
            <p style={{ margin: '3px 0' }}>
              👨‍🏫 {task.createdByProfessorName}
            </p>
            {task.dueDate && (
              <p style={{ margin: '3px 0', color: new Date(task.dueDate) < new Date() ? '#dc3545' : '#888' }}>
                📅 Deadline: {formatDate(task.dueDate)}
              </p>
            )}
          </div>
        </div>
      </div>

      <div style={{ display: 'flex', gap: '10px', marginTop: '15px', flexWrap: 'wrap' }}>
        {!isProfessor && (
          <>
            {task.isSavedByUser ? (
              <>
                <button
                  onClick={() => onUnsave && onUnsave(task.id)}
                  style={{
                    padding: '6px 12px',
                    backgroundColor: '#6c757d',
                    color: 'white',
                    border: 'none',
                    borderRadius: '5px',
                    cursor: 'pointer',
                    fontSize: '13px'
                  }}
                >
                  Elimină din Salvate
                </button>
                {task.isCompleted ? (
                  <button
                    onClick={() => onIncomplete && onIncomplete(task.id)}
                    style={{
                      padding: '6px 12px',
                      backgroundColor: '#ffc107',
                      color: 'white',
                      border: 'none',
                      borderRadius: '5px',
                      cursor: 'pointer',
                      fontSize: '13px'
                    }}
                  >
                    Marchează ca Nefinalizat
                  </button>
                ) : (
                  <button
                    onClick={() => onComplete && onComplete(task.id)}
                    style={{
                      padding: '6px 12px',
                      backgroundColor: '#28a745',
                      color: 'white',
                      border: 'none',
                      borderRadius: '5px',
                      cursor: 'pointer',
                      fontSize: '13px'
                    }}
                  >
                    Marchează ca Finalizat
                  </button>
                )}
              </>
            ) : (
              <button
                onClick={() => onSave && onSave(task.id)}
                style={{
                  padding: '6px 12px',
                  backgroundColor: '#007bff',
                  color: 'white',
                  border: 'none',
                  borderRadius: '5px',
                  cursor: 'pointer',
                  fontSize: '13px'
                }}
              >
                💾 Salvează Task
              </button>
            )}
          </>
        )}

        {isGroupOwner && onDelete && (
          <button
            onClick={() => {
              if (window.confirm('Sigur vrei să ștergi acest task?')) {
                onDelete(task.id);
              }
            }}
            style={{
              padding: '6px 12px',
              backgroundColor: '#dc3545',
              color: 'white',
              border: 'none',
              borderRadius: '5px',
              cursor: 'pointer',
              fontSize: '13px'
            }}
          >
            Șterge Task
          </button>
        )}
      </div>
    </div>
  );
};

const GroupDetails = () => {
  const { id } = useParams<{ id: string }>();
  const navigate = useNavigate();
  const [group, setGroup] = useState<Group | null>(null);
  const [tasks, setTasks] = useState<GroupTask[]>([]);
  const [loading, setLoading] = useState(true);
  const [showCreateForm, setShowCreateForm] = useState(false);
  const [newTask, setNewTask] = useState({ title: '', description: '', dueDate: '' });

  const user = JSON.parse(localStorage.getItem('user') || '{}');
  const isProfessor = user.role === 'Professor';
  const isAdmin = user.role === 'Admin';
  
  // Calculate these based on the loaded group
  const isGroupOwner = useMemo(() => {
    if (!group) return false;
    console.log('Checking ownership:', {
      groupProfessorId: group.professorId,
      userId: user.id,
      userIdNumber: Number(user.id),
      match: group.professorId === Number(user.id)
    });
    return group.professorId === Number(user.id);
  }, [group, user.id]);
  
  const canManageTasks = useMemo(() => {
    console.log('Can manage tasks:', {
      isGroupOwner,
      isAdmin,
      result: isGroupOwner || isAdmin
    });
    return isGroupOwner || isAdmin;
  }, [isGroupOwner, isAdmin]);

  useEffect(() => {
    loadGroupDetails();
  }, [id]);

  const loadGroupDetails = async () => {
    setLoading(true);
    try {
      const groupData = await groupApi.getGroupById(Number(id));
      console.log('Group data loaded:', groupData);
      console.log('Current user:', user);
      setGroup(groupData);
      const tasksData = await groupApi.getGroupTasks(Number(id));
      setTasks(tasksData);
    } catch (error) {
      console.error('Error loading group details:', error);
      alert('Eroare la încărcarea grupului');
      setGroup(null); // Asigură-te că group este null în caz de eroare
    } finally {
      setLoading(false);
    }
  };

  const handleCreateTask = async (e: React.FormEvent) => {
    e.preventDefault();
    try {
      await groupApi.createTask(Number(id), {
        title: newTask.title,
        description: newTask.description || undefined,
        dueDate: newTask.dueDate || undefined
      });
      alert('Task-ul a fost creat cu succes!');
      setShowCreateForm(false);
      setNewTask({ title: '', description: '', dueDate: '' });
      loadGroupDetails();
    } catch (error) {
      console.error('Error creating task:', error);
      alert('Eroare la crearea task-ului');
    }
  };

  const handleSaveTask = async (taskId: number) => {
    try {
      await groupApi.saveTask(taskId);
      alert('Task salvat în profilul tău!');
      loadGroupDetails();
    } catch (error) {
      console.error('Error saving task:', error);
      alert('Eroare la salvarea task-ului');
    }
  };

  const handleUnsaveTask = async (taskId: number) => {
    try {
      await groupApi.unsaveTask(taskId);
      alert('Task eliminat din salvate');
      loadGroupDetails();
    } catch (error) {
      console.error('Error unsaving task:', error);
      alert('Eroare la eliminarea task-ului');
    }
  };

  const handleCompleteTask = async (taskId: number) => {
    try {
      await groupApi.markTaskAsCompleted(taskId);
      loadGroupDetails();
    } catch (error) {
      console.error('Error completing task:', error);
      alert('Eroare la marcarea task-ului');
    }
  };

  const handleIncompleteTask = async (taskId: number) => {
    try {
      await groupApi.markTaskAsIncomplete(taskId);
      loadGroupDetails();
    } catch (error) {
      console.error('Error marking task as incomplete:', error);
      alert('Eroare la marcarea task-ului');
    }
  };

  const handleDeleteTask = async (taskId: number) => {
    try {
      await groupApi.deleteTask(taskId);
      alert('Task-ul a fost șters');
      loadGroupDetails();
    } catch (error) {
      console.error('Error deleting task:', error);
      alert('Eroare la ștergerea task-ului');
    }
  };

  if (loading) {
    return <div className="container"><p>Se încarcă...</p></div>;
  }

  if (!group) {
    return <div className="container"><p>Grupul nu a fost găsit</p></div>;
  }

  return (
    <div className="container">
      <div style={{ marginBottom: '20px' }}>

        <div style={{
          backgroundColor: 'white',
          padding: '20px',
          borderRadius: '8px',
          marginBottom: '20px',
          boxShadow: '0 2px 4px rgba(0,0,0,0.1)'
        }}>
          <h1 style={{ margin: '0 0 10px 0' }}>{group.name}</h1>
          <p style={{ color: '#666', margin: '5px 0' }}>
            <strong>Materie:</strong> {group.subject}
          </p>
          <p style={{ color: '#666', margin: '5px 0' }}>
            <strong>Professor:</strong> {group.professorName}
          </p>
          {group.description && (
            <p style={{ color: '#666', margin: '10px 0' }}>{group.description}</p>
          )}
          <div style={{ display: 'flex', gap: '15px', marginTop: '10px' }}>
            <span style={{ color: '#888' }}>👥 {group.membersCount} membri</span>
            <span style={{ color: '#888' }}>📝 {group.tasksCount} taskuri</span>
          </div>
        </div>
      </div>

      <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '20px' }}>
        <h2>Taskuri</h2>
        {canManageTasks && (
          <button
            onClick={() => setShowCreateForm(!showCreateForm)}
            style={{
              padding: '10px 20px',
              backgroundColor: '#28a745',
              color: 'white',
              border: 'none',
              borderRadius: '5px',
              cursor: 'pointer'
            }}
          >
            {showCreateForm ? 'Anulează' : '+ Adaugă Task'}
          </button>
        )}
      </div>

      {showCreateForm && (
        <div style={{
          backgroundColor: 'white',
          padding: '20px',
          borderRadius: '8px',
          marginBottom: '20px',
          boxShadow: '0 2px 4px rgba(0,0,0,0.1)'
        }}>
          <h3>Creează Task Nou</h3>
          <form onSubmit={handleCreateTask}>
            <div style={{ marginBottom: '15px' }}>
              <label style={{ display: 'block', marginBottom: '5px' }}>Titlu *</label>
              <input
                type="text"
                value={newTask.title}
                onChange={(e) => setNewTask({ ...newTask, title: e.target.value })}
                required
                style={{ width: '100%', padding: '8px', borderRadius: '5px', border: '1px solid #ddd' }}
              />
            </div>
            <div style={{ marginBottom: '15px' }}>
              <label style={{ display: 'block', marginBottom: '5px' }}>Descriere</label>
              <textarea
                value={newTask.description}
                onChange={(e) => setNewTask({ ...newTask, description: e.target.value })}
                rows={3}
                style={{ width: '100%', padding: '8px', borderRadius: '5px', border: '1px solid #ddd' }}
              />
            </div>
            <div style={{ marginBottom: '15px' }}>
              <label style={{ display: 'block', marginBottom: '5px' }}>Deadline</label>
              <input
                type="date"
                value={newTask.dueDate}
                onChange={(e) => setNewTask({ ...newTask, dueDate: e.target.value })}
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
              Creează Task
            </button>
          </form>
        </div>
      )}

      {tasks.length === 0 ? (
        <p style={{ textAlign: 'center', color: '#888', padding: '40px' }}>
          Nu există taskuri în acest grup
        </p>
      ) : (
        tasks.map(task => (
          <TaskCard
            key={task.id}
            task={task}
            onSave={handleSaveTask}
            onUnsave={handleUnsaveTask}
            onComplete={handleCompleteTask}
            onIncomplete={handleIncompleteTask}
            onDelete={canManageTasks ? handleDeleteTask : undefined}
            isProfessor={isProfessor}
            isGroupOwner={canManageTasks}
          />
        ))
      )}
    </div>
  );
};

export default GroupDetails;
