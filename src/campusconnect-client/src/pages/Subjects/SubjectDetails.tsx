import { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { motion } from 'framer-motion';
import { ArrowLeft, Plus, Search, X, Trash2, BookOpen } from 'lucide-react';
import { Layout } from '../../components/Layout';
import { Card, CardHeader, CardTitle, CardContent } from '../../components/ui/Card';
import { Button } from '../../components/ui/Button';
import { Input } from '../../components/ui/Input';
import { Badge } from '../../components/ui/Badge';
import * as gradesApi from '../../services/gradesApi';
import type { Subject, Grade, CreateGradeRequest } from '../../services/gradesApi';

interface Student {
  id: number;
  firstName: string;
  lastName: string;
  email: string;
  studentId?: string;
}

const SubjectDetails = () => {
  const { id } = useParams<{ id: string }>();
  const navigate = useNavigate();
  const [subject, setSubject] = useState<Subject | null>(null);
  const [grades, setGrades] = useState<Grade[]>([]);
  const [students, setStudents] = useState<Student[]>([]);
  const [searchQuery, setSearchQuery] = useState('');
  const [selectedStudent, setSelectedStudent] = useState<Student | null>(null);
  const [showAddGradeForm, setShowAddGradeForm] = useState(false);
  const [newGrade, setNewGrade] = useState<CreateGradeRequest>({
    subjectId: parseInt(id || '0'),
    studentId: 0,
    value: 10,
    comments: '',
  });
  const [loading, setLoading] = useState(true);
  const [loadingSubject, setLoadingSubject] = useState(true);
  const [searchingStudents, setSearchingStudents] = useState(false);

  useEffect(() => {
    if (id) {
      loadSubjectDetails();
      loadGrades();
    }
  }, [id]);

  const loadSubjectDetails = async () => {
    try {
      setLoadingSubject(true);
      const data = await gradesApi.subjectApi.getSubject(parseInt(id!));
      setSubject(data);
    } catch (error) {
      console.error('Error loading subject:', error);
    } finally {
      setLoadingSubject(false);
    }
  };

  const loadGrades = async () => {
    setLoading(true);
    try {
      console.log('Loading grades for subject:', id);
      const data = await gradesApi.gradeApi.getGradesBySubject(parseInt(id!));
      console.log('Grades loaded:', data);
      setGrades(data);
    } catch (error) {
      console.error('Error loading grades:', error);
    } finally {
      setLoading(false);
    }
  };

  const searchStudents = async (query: string) => {
    if (!query || query.length < 2) {
      setStudents([]);
      return;
    }
    
    try {
      setSearchingStudents(true);
      const response = await fetch(`http://localhost:5099/api/User/search?query=${encodeURIComponent(query)}`, {
        headers: {
          'Authorization': `Bearer ${localStorage.getItem('token')}`,
        },
      });
      if (response.ok) {
        const allUsers = await response.json();
        // Filter only students (users with role "User")
        const studentUsers = allUsers.filter((u: any) => u.role === 'User');
        setStudents(studentUsers);
      }
    } catch (error) {
      console.error('Error searching students:', error);
      setStudents([]);
    } finally {
      setSearchingStudents(false);
    }
  };

  const handleAddGrade = async (e?: React.FormEvent) => {
    if (e) e.preventDefault();
    if (!selectedStudent) return;

    try {
      await gradesApi.gradeApi.createGrade({
        ...newGrade,
        studentId: selectedStudent.id,
        subjectId: parseInt(id!),
      });
      setShowAddGradeForm(false);
      setSelectedStudent(null);
      setNewGrade({ subjectId: parseInt(id!), studentId: 0, value: 10, comments: '' });
      setSearchQuery('');
      loadGrades();
    } catch (error) {
      console.error('Error adding grade:', error);
    }
  };

  const handleDeleteGrade = async (gradeId: number) => {
    if (!window.confirm('Sigur vrei să ștergi această notă?')) return;
    try {
      await gradesApi.gradeApi.deleteGrade(gradeId);
      loadGrades();
    } catch (error) {
      console.error('Error deleting grade:', error);
    }
  };

  // Debounce search
  useEffect(() => {
    const timer = setTimeout(() => {
      if (searchQuery) {
        searchStudents(searchQuery);
      } else {
        setStudents([]);
      }
    }, 300);

    return () => clearTimeout(timer);
  }, [searchQuery]);

  const getGradeColor = (value: number) => {
    if (value >= 9) return 'text-green-600 bg-green-50';
    if (value >= 7) return 'text-blue-600 bg-blue-50';
    if (value >= 5) return 'text-yellow-600 bg-yellow-50';
    return 'text-red-600 bg-red-50';
  };

  return (
    <Layout>
      {loadingSubject ? (
        <div className="flex justify-center items-center h-64">
          <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-blue-600"></div>
        </div>
      ) : !subject ? (
        <div className="text-center py-12">
          <p className="text-xl text-red-600">Materia nu a fost găsită</p>
          <Button onClick={() => navigate('/subjects')} className="mt-4">
            Înapoi la Materii
          </Button>
        </div>
      ) : (
      <div className="space-y-8">
        {/* Hero Header */}
        <motion.div
          initial={{ opacity: 0, y: -20 }}
          animate={{ opacity: 1, y: 0 }}
          className="relative overflow-hidden rounded-2xl bg-gradient-to-br from-primary via-indigo-600 to-purple-600 p-8 text-white shadow-2xl"
        >
          <div className="absolute inset-0 bg-[url('data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iNjAiIGhlaWdodD0iNjAiIHZpZXdCb3g9IjAgMCA2MCA2MCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj48ZyBmaWxsPSJub25lIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiPjxwYXRoIGQ9Ik0zNiAxOGMzLjMxIDAgNiAyLjY5IDYgNnMtMi42OSA2LTYgNi02LTIuNjktNi02IDIuNjktNiA2LTZ6TTI0IDBoNnY2aC02VjB6TTAgMjRoNnY2SDB2LTZ6bTAgMGg2djZIMHYtNnoiIGZpbGw9IiNmZmYiIGZpbGwtb3BhY2l0eT0iLjA1Ii8+PC9nPjwvc3ZnPg==')] opacity-30"></div>
          
          <div className="relative z-10">
            <Button
              type="button"
              onClick={() => navigate('/subjects')}
              variant="outline"
              className="mb-4 bg-white/10 border-white/20 text-white hover:bg-white/20"
            >
              <ArrowLeft className="w-4 h-4 mr-2" />
              Back to Subjects
            </Button>
          
            <div className="flex flex-col sm:flex-row justify-between items-start sm:items-center gap-4">
              <div className="flex items-center gap-4">
                <div className="p-3 bg-white/20 backdrop-blur-sm rounded-xl">
                  <BookOpen className="h-8 w-8" />
                </div>
                <div>
                  <h1 className="text-4xl font-bold">{subject.name}</h1>
                  {subject.description && (
                    <p className="text-white/80 mt-1">{subject.description}</p>
                  )}
                  <Badge className="mt-2 bg-white/20 border-white/30 text-white">
                    {grades.length} {grades.length === 1 ? 'notă acordată' : 'note acordate'}
                  </Badge>
                </div>
              </div>
              <motion.div whileHover={{ scale: 1.05 }} whileTap={{ scale: 0.95 }}>
                <Button
                  type="button"
                  onClick={() => setShowAddGradeForm(!showAddGradeForm)}
                  className="bg-white text-indigo-600 hover:bg-white/90 shadow-lg"
                >
                  <Plus className="w-5 h-5 mr-2" />
                  Adaugă Notă
                </Button>
              </motion.div>
            </div>
          </div>
        </motion.div>

        <div className="container mx-auto px-4 max-w-7xl">
          {/* Add Grade Form */}
          {showAddGradeForm && (
          <motion.div
            initial={{ opacity: 0, height: 0 }}
            animate={{ opacity: 1, height: 'auto' }}
            className="mb-6"
          >
            <Card>
              <CardHeader>
                <CardTitle>Adaugă Notă Nouă</CardTitle>
              </CardHeader>
              <CardContent>
                <form onSubmit={(e) => { e.preventDefault(); handleAddGrade(); }} className="space-y-4">
                  {/* Student Search */}
                  <div>
                    <label className="block text-sm font-medium mb-2">
                      Caută Student *
                    </label>
                    <div className="relative">
                      <Search className="absolute left-3 top-1/2 transform -translate-y-1/2 text-gray-400 w-5 h-5" />
                      <Input
                        type="text"
                        placeholder="Caută după nume, email sau matricol... (minim 2 caractere)"
                        value={searchQuery}
                        onChange={(e) => setSearchQuery(e.target.value)}
                        onKeyDown={(e) => {
                          if (e.key === 'Enter') {
                            e.preventDefault();
                          }
                        }}
                        className="pl-10"
                        autoComplete="off"
                        disabled={searchingStudents}
                      />
                    </div>
                    
                    {/* Selected Student */}
                    {selectedStudent && (
                      <div className="mt-2 p-3 bg-primary/10 rounded-lg flex justify-between items-center">
                        <div>
                          <p className="font-medium">{selectedStudent.firstName} {selectedStudent.lastName}</p>
                          <p className="text-sm text-gray-600">{selectedStudent.email}</p>
                          {selectedStudent.studentId && (
                            <p className="text-xs text-gray-500">Matricol: {selectedStudent.studentId}</p>
                          )}
                        </div>
                        <Button
                          type="button"
                          onClick={() => setSelectedStudent(null)}
                          variant="ghost"
                          size="sm"
                        >
                          <X className="w-4 h-4" />
                        </Button>
                      </div>
                    )}
                    
                    {/* Student List */}
                    {searchQuery && !selectedStudent && (
                      <div className="mt-2 max-h-60 overflow-y-auto border rounded-lg">
                        {searchingStudents ? (
                          <p className="p-4 text-muted-foreground text-center">Se caută...</p>
                        ) : students.length === 0 ? (
                          <p className="p-4 text-muted-foreground text-center">{searchQuery.length < 2 ? 'Introdu minim 2 caractere' : 'Nu s-au găsit studenți'}</p>
                        ) : (
                          students.map((student) => (
                            <button
                              key={student.id}
                              type="button"
                              onClick={() => {
                                setSelectedStudent(student);
                                setSearchQuery('');
                              }}
                              className="w-full p-3 text-left hover:bg-accent border-b last:border-b-0"
                            >
                              <p className="font-medium">{student.firstName} {student.lastName}</p>
                              <p className="text-sm text-gray-600">{student.email}</p>
                              {student.studentId && (
                                <p className="text-xs text-gray-500">Matricol: {student.studentId}</p>
                              )}
                            </button>
                          ))
                        )}
                      </div>
                    )}
                  </div>

                  {/* Grade Value */}
                  <div>
                    <label className="block text-sm font-medium mb-2">
                      Nota (1-10) *
                    </label>
                    <Input
                      type="number"
                      min="1"
                      max="10"
                      step="0.01"
                      value={newGrade.value}
                      onChange={(e) => setNewGrade({ ...newGrade, value: parseFloat(e.target.value) })}
                      required
                      className="w-full"
                    />
                  </div>

                  {/* Comments */}
                  <div>
                    <label className="block text-sm font-medium mb-2">
                      Comentarii (opțional)
                    </label>
                    <textarea
                      placeholder="Observații despre notă..."
                      value={newGrade.comments || ''}
                      onChange={(e) => setNewGrade({ ...newGrade, comments: e.target.value })}
                      className="w-full px-3 py-2 border border-input rounded-md bg-background"
                      rows={3}
                    />
                  </div>

                  <div className="flex gap-3">
                    <Button 
                      type="submit"
                      disabled={!selectedStudent}
                    >
                      Adaugă Nota
                    </Button>
                    <Button
                      type="button"
                      onClick={() => {
                        setShowAddGradeForm(false);
                        setSelectedStudent(null);
                        setSearchQuery('');
                      }}
                      variant="outline"
                    >
                      Anulează
                    </Button>
                  </div>
                </form>
              </CardContent>
            </Card>
          </motion.div>
        )}

        {/* Grades List */}
        {loading ? (
          <div className="flex justify-center items-center h-64">
            <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-blue-600"></div>
          </div>
        ) : grades.length === 0 ? (
          <Card>
            <CardContent className="py-12 text-center">
              <p className="text-xl mb-2">Nu există note încă</p>
              <p className="text-muted-foreground">Adaugă prima notă pentru a începe</p>
            </CardContent>
          </Card>
        ) : (
          <Card>
            <CardHeader>
              <CardTitle>Note Acordate ({grades.length})</CardTitle>
            </CardHeader>
            <CardContent>
              <div className="overflow-x-auto">
                <table className="w-full">
                  <thead>
                    <tr className="border-b">
                      <th className="text-left py-3 px-4 font-semibold">Student</th>
                      <th className="text-left py-3 px-4 font-semibold">Email</th>
                      <th className="text-center py-3 px-4 font-semibold">Nota</th>
                      <th className="text-left py-3 px-4 font-semibold">Comentarii</th>
                      <th className="text-center py-3 px-4 font-semibold">Data</th>
                      <th className="text-center py-3 px-4 font-semibold">Acțiuni</th>
                    </tr>
                  </thead>
                  <tbody>
                    {grades.map((grade) => (
                      <tr key={grade.id} className="border-b last:border-b-0 hover:bg-accent">
                        <td className="py-3 px-4">
                          <div>
                            <p className="font-medium">{grade.studentName}</p>
                          </div>
                        </td>
                        <td className="py-3 px-4 text-sm text-muted-foreground">
                          {grade.studentEmail}
                        </td>
                        <td className="py-3 px-4 text-center">
                          <Badge className={`${getGradeColor(grade.value)} font-bold`}>
                            {grade.value.toFixed(2)}
                          </Badge>
                        </td>
                        <td className="py-3 px-4 text-sm text-muted-foreground">
                          {grade.comments || '-'}
                        </td>
                        <td className="py-3 px-4 text-center text-sm text-muted-foreground">
                          {new Date(grade.createdAt).toLocaleDateString('ro-RO')}
                        </td>
                        <td className="py-3 px-4 text-center">
                          <Button
                            type="button"
                            onClick={() => handleDeleteGrade(grade.id)}
                            variant="destructive"
                            size="sm"
                          >
                            <Trash2 className="w-4 h-4" />
                          </Button>
                        </td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              </div>
            </CardContent>
          </Card>
        )}
        </div>
      </div>
      )}
    </Layout>
  );
};

export default SubjectDetails;
