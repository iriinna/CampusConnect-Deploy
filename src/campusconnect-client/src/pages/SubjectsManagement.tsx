import React, { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import { motion, AnimatePresence } from 'framer-motion';
import { subjectApi } from '../services/gradesApi';
import type { Subject, CreateSubjectRequest, UpdateSubjectRequest } from '../services/gradesApi';
import { Pencil, Trash2, Plus, X, ArrowRight, BookOpen, Calendar, GraduationCap, Sparkles, ArrowLeft } from 'lucide-react';
import { Layout } from '../components/Layout';

const SubjectsManagement: React.FC = () => {
  const navigate = useNavigate();
  const [subjects, setSubjects] = useState<Subject[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');
  const [showModal, setShowModal] = useState(false);
  const [editingSubject, setEditingSubject] = useState<Subject | null>(null);
  const [formData, setFormData] = useState({
    name: '',
    code: '',
    description: '',
    year: 1,
  });

  useEffect(() => {
    loadSubjects();
  }, []);

  const loadSubjects = async () => {
    try {
      setLoading(true);
      const data = await subjectApi.getMySubjects();
      setSubjects(data);
      setError('');
    } catch (err: any) {
      setError(err.response?.data?.message || 'Error loading subjects');
    } finally {
      setLoading(false);
    }
  };

  const handleCreate = () => {
    setEditingSubject(null);
    setFormData({ name: '', code: '', description: '', year: 1 });
    setShowModal(true);
  };

  const handleEdit = (subject: Subject) => {
    setEditingSubject(subject);
    setFormData({
      name: subject.name,
      code: subject.code,
      description: subject.description || '',
      year: subject.year,
    });
    setShowModal(true);
  };

  const handleDelete = async (id: number, name: string) => {
    if (!confirm(`Are you sure you want to delete the subject "${name}"?`)) return;

    try {
      await subjectApi.deleteSubject(id);
      await loadSubjects();
      setError('');
    } catch (err: any) {
      setError(err.response?.data?.message || 'Eroare la ștergerea materiei');
    }
  };

  const generateSubjectCode = (name: string): string => {
    const prefix = name.substring(0, 3).toUpperCase().replace(/[^A-Z]/g, 'X');
    const randomNum = Math.floor(100 + Math.random() * 900);
    return `${prefix}${randomNum}`;
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    
    try {
      if (editingSubject) {
        const updateData: UpdateSubjectRequest = {
          name: formData.name,
          description: formData.description || undefined,
          year: formData.year,
        };
        await subjectApi.updateSubject(editingSubject.id, updateData);
      } else {
        const generatedCode = generateSubjectCode(formData.name);
        const createData: CreateSubjectRequest = {
          name: formData.name,
          code: generatedCode,
          description: formData.description || undefined,
          year: formData.year,
        };
        await subjectApi.createSubject(createData);
      }
      
      setShowModal(false);
      await loadSubjects();
      setError('');
    } catch (err: any) {
      setError(err.response?.data?.message || 'Eroare la salvarea materiei');
    }
  };

  const closeModal = () => {
    setShowModal(false);
    setEditingSubject(null);
    setFormData({ name: '', code: '', description: '', year: 1 });
  };

  if (loading) {
    return (
      <Layout>
        <div className="flex justify-center items-center h-screen">
          <div className="relative">
            <div className="animate-spin rounded-full h-16 w-16 border-b-4 border-indigo-600"></div>
            <BookOpen className="absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 text-indigo-600" size={24} />
          </div>
        </div>
      </Layout>
    );
  }

  return (
    <Layout>
      <div className="min-h-screen bg-gradient-to-br from-slate-900 via-slate-800 to-slate-900">
        {/* Hero Header */}
        <motion.div
          initial={{ opacity: 0, y: -20 }}
          animate={{ opacity: 1, y: 0 }}
          className="bg-gradient-to-r from-indigo-600 via-purple-600 to-pink-600 text-white"
        >
          <div className="container mx-auto px-4 py-12">
            <div className="flex flex-col md:flex-row justify-between items-start md:items-center gap-6">
              <div className="flex items-center gap-4">
                <motion.button
                  initial={{ opacity: 0, x: -20 }}
                  animate={{ opacity: 1, x: 0 }}
                  whileHover={{ scale: 1.05 }}
                  whileTap={{ scale: 0.95 }}
                  onClick={() => navigate(-1)}
                  className="flex items-center gap-2 bg-white/20 hover:bg-white/30 backdrop-blur-sm text-white px-4 py-3 rounded-xl font-semibold shadow-lg hover:shadow-xl transition-all duration-300 border border-white/30"
                >
                  <ArrowLeft size={20} />
                  Back
                </motion.button>
                
                <motion.div
                  initial={{ opacity: 0, x: -20 }}
                  animate={{ opacity: 1, x: 0 }}
                  transition={{ delay: 0.1 }}
                  className="flex items-center gap-3"
                >
                  <div className="p-3 bg-white/20 backdrop-blur-sm rounded-xl">
                    <BookOpen className="h-10 w-10" />
                  </div>
                  <div>
                    <h1 className="text-4xl font-bold mb-1">My Subjects</h1>
                    <p className="text-indigo-100">Manage your subjects</p>
                  </div>
                </motion.div>
              </div>

              <motion.button
                initial={{ opacity: 0, scale: 0.9 }}
                animate={{ opacity: 1, scale: 1 }}
                whileHover={{ scale: 1.05 }}
                whileTap={{ scale: 0.95 }}
                onClick={handleCreate}
                className="flex items-center gap-2 bg-white text-indigo-600 px-6 py-3 rounded-xl font-semibold shadow-lg hover:shadow-xl transition-all duration-300"
              >
                <Plus size={22} />
                Add Subject
              </motion.button>
            </div>
          </div>
        </motion.div>

        <div className="container mx-auto px-4 py-8 max-w-7xl">
          {error && (
            <motion.div
              initial={{ opacity: 0, y: -10 }}
              animate={{ opacity: 1, y: 0 }}
              className="bg-red-50 border-l-4 border-red-500 text-red-800 px-6 py-4 rounded-lg shadow-md mb-6"
            >
              <p className="font-semibold">Error!</p>
              <p>{error}</p>
            </motion.div>
          )}

          {subjects.length === 0 ? (
            <motion.div
              initial={{ opacity: 0, y: 20 }}
              animate={{ opacity: 1, y: 0 }}
              className="text-center py-20"
            >
              <div className="inline-block p-6 bg-gradient-to-br from-indigo-900/50 to-purple-900/50 rounded-full mb-6">
                <BookOpen className="text-indigo-400" size={64} />
              </div>
              <h2 className="text-3xl font-bold text-gray-100 mb-3">No subjects yet</h2>
              <p className="text-gray-400 text-lg mb-6">Create your first subject to start adding grades</p>
              <motion.button
                whileHover={{ scale: 1.05 }}
                whileTap={{ scale: 0.95 }}
                onClick={handleCreate}
                className="inline-flex items-center gap-2 bg-gradient-to-r from-indigo-600 to-purple-600 text-white px-8 py-4 rounded-xl font-semibold shadow-lg hover:shadow-xl transition-all"
              >
                <Plus size={24} />
                Create First Subject
              </motion.button>
            </motion.div>
          ) : (
            <>
              {[1, 2, 3].map(year => {
                const yearSubjects = subjects.filter(s => s.year === year);
                if (yearSubjects.length === 0) return null;
                
                return (
                  <div key={year} className="mb-12">
                    <motion.div
                      initial={{ opacity: 0, x: -20 }}
                      animate={{ opacity: 1, x: 0 }}
                      className="flex items-center gap-3 mb-6"
                    >
                      <div className="flex items-center gap-2 bg-gradient-to-r from-indigo-600 to-purple-600 text-white px-6 py-3 rounded-xl shadow-lg">
                        <GraduationCap size={24} />
                        <h2 className="text-2xl font-bold">Year {year}</h2>
                      </div>
                      <div className="h-1 flex-1 bg-gradient-to-r from-indigo-600/50 to-transparent rounded"></div>
                    </motion.div>

                    <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
                      {yearSubjects.map((subject, index) => (
                        <motion.div
                          key={subject.id}
                          initial={{ opacity: 0, y: 20 }}
                          animate={{ opacity: 1, y: 0 }}
                          transition={{ delay: index * 0.1 }}
                          whileHover={{ y: -8 }}
                          onClick={() => navigate(`/subjects/${subject.id}`)}
                          className="group bg-slate-800 rounded-2xl shadow-lg overflow-hidden border border-slate-700 hover:shadow-2xl hover:border-indigo-500 transition-all duration-300 cursor-pointer relative"
                        >
                          {/* Decorative gradient */}
                          <div className="absolute top-0 right-0 w-32 h-32 bg-gradient-to-br from-indigo-600/20 to-purple-600/20 rounded-bl-full transform translate-x-8 -translate-y-8"></div>
                          
                          <div className="p-6 relative">
                            {/* Header with icons */}
                            <div className="flex justify-between items-start mb-4">
                              <div className="flex items-start gap-3 flex-1">
                                <div className="p-3 bg-gradient-to-br from-indigo-900/50 to-purple-900/50 rounded-xl group-hover:from-indigo-800/50 group-hover:to-purple-800/50 transition-all">
                                  <GraduationCap className="h-6 w-6 text-indigo-400" />
                                </div>
                                <div className="flex-1 min-w-0">
                                  <h3 className="text-xl font-bold text-gray-100 mb-1 group-hover:text-indigo-400 transition-colors truncate">
                                    {subject.name}
                                  </h3>
                                  <div className="flex items-center gap-2">
                                    <span className="text-sm font-mono text-gray-400 bg-slate-700 px-2 py-1 rounded">{subject.code}</span>
                                  </div>
                                </div>
                              </div>

                              {/* Action buttons */}
                              <div className="flex gap-1 opacity-0 group-hover:opacity-100 transition-opacity" onClick={(e) => e.stopPropagation()}>
                                <motion.button
                                  whileHover={{ scale: 1.1 }}
                                  whileTap={{ scale: 0.9 }}
                                  onClick={(e) => {
                                    e.stopPropagation();
                                    handleEdit(subject);
                                  }}
                                  className="p-2 text-indigo-400 hover:bg-indigo-900/50 rounded-lg transition-all"
                                  title="Editează"
                                >
                                  <Pencil size={18} />
                                </motion.button>
                                <motion.button
                                  whileHover={{ scale: 1.1 }}
                                  whileTap={{ scale: 0.9 }}
                                  onClick={(e) => {
                                    e.stopPropagation();
                                    handleDelete(subject.id, subject.name);
                                  }}
                                  className="p-2 text-red-400 hover:bg-red-900/50 rounded-lg transition-all"
                                  title="Șterge"
                                >
                                  <Trash2 size={18} />
                                </motion.button>
                              </div>
                            </div>
                            
                            {/* Description */}
                            {subject.description && (
                              <p className="text-gray-400 text-sm mb-4 line-clamp-3 leading-relaxed">
                                {subject.description}
                              </p>
                            )}
                            
                            {/* Footer */}
                            <div className="flex justify-between items-center pt-4 border-t border-slate-700">
                              <div className="flex items-center gap-2 text-xs text-gray-500">
                                <Calendar size={14} />
                                {new Date(subject.createdAt).toLocaleDateString('en-US')}
                              </div>
                              <motion.div
                                initial={{ opacity: 0, x: -10 }}
                                animate={{ opacity: 1, x: 0 }}
                                className="flex items-center gap-1 text-indigo-400 font-medium text-sm"
                              >
                                <span>Manage Grades</span>
                                <ArrowRight size={16} className="group-hover:translate-x-1 transition-transform" />
                              </motion.div>
                            </div>
                          </div>

                          {/* Hover effect sparkle */}
                          <div className="absolute -top-1 -right-1 opacity-0 group-hover:opacity-100 transition-opacity">
                            <Sparkles className="text-yellow-400" size={20} />
                          </div>
                        </motion.div>
                      ))}
                    </div>
                  </div>
                );
              })}
            </>
          )}
        </div>

        {/* Modal */}
        <AnimatePresence>
          {showModal && (
            <motion.div
              initial={{ opacity: 0 }}
              animate={{ opacity: 1 }}
              exit={{ opacity: 0 }}
              className="fixed inset-0 bg-black/50 backdrop-blur-sm flex items-center justify-center p-4 z-50"
              onClick={closeModal}
            >
              <motion.div
                initial={{ opacity: 0, scale: 0.95, y: 20 }}
                animate={{ opacity: 1, scale: 1, y: 0 }}
                exit={{ opacity: 0, scale: 0.95, y: 20 }}
                onClick={(e) => e.stopPropagation()}
                className="bg-white rounded-2xl shadow-2xl max-w-md w-full overflow-hidden"
              >
                {/* Modal Header */}
                <div className="bg-gradient-to-r from-indigo-600 to-purple-600 p-6 text-white">
                  <div className="flex justify-between items-center">
                    <div className="flex items-center gap-3">
                      <div className="p-2 bg-white/20 rounded-lg">
                        {editingSubject ? <Pencil size={24} /> : <Plus size={24} />}
                      </div>
                      <h2 className="text-2xl font-bold">
                        {editingSubject ? 'Edit Subject' : 'Add New Subject'}
                      </h2>
                    </div>
                    <motion.button
                      whileHover={{ scale: 1.1, rotate: 90 }}
                      whileTap={{ scale: 0.9 }}
                      onClick={closeModal}
                      className="text-white/80 hover:text-white transition p-2 hover:bg-white/20 rounded-lg"
                    >
                      <X size={24} />
                    </motion.button>
                  </div>
                </div>

                {/* Modal Body */}
                <form onSubmit={handleSubmit} className="p-6 space-y-5">
                  <div>
                    <label className="block text-gray-700 font-semibold mb-2 flex items-center gap-2">
                      <BookOpen size={18} className="text-indigo-600" />
                      Subject Name *
                    </label>
                    <input
                      type="text"
                      value={formData.name}
                      onChange={(e) => setFormData({ ...formData, name: e.target.value })}
                      className="w-full px-4 py-3 border-2 border-gray-200 rounded-xl focus:ring-2 focus:ring-indigo-500 focus:border-indigo-500 transition-all"
                      required
                      placeholder="e.g.: Mathematics"
                    />
                  </div>

                  <div>
                    <label className="block text-gray-700 font-semibold mb-2 flex items-center gap-2">
                      <GraduationCap size={18} className="text-indigo-600" />
                      Academic Year *
                    </label>
                    <select
                      value={formData.year}
                      onChange={(e) => setFormData({ ...formData, year: parseInt(e.target.value) })}
                      className="w-full px-4 py-3 border-2 border-gray-200 rounded-xl focus:ring-2 focus:ring-indigo-500 focus:border-indigo-500 transition-all"
                      required
                    >
                      <option value={1}>Year 1</option>
                      <option value={2}>Year 2</option>
                      <option value={3}>Year 3</option>
                    </select>
                  </div>

                  <div>
                    <label className="block text-gray-700 font-semibold mb-2">
                      Description (optional)
                    </label>
                    <textarea
                      value={formData.description}
                      onChange={(e) => setFormData({ ...formData, description: e.target.value })}
                      className="w-full px-4 py-3 border-2 border-gray-200 rounded-xl focus:ring-2 focus:ring-indigo-500 focus:border-indigo-500 transition-all resize-none"
                      rows={4}
                      placeholder="Subject description..."
                    />
                  </div>

                  <div className="flex gap-3 pt-4">
                    <motion.button
                      type="button"
                      whileHover={{ scale: 1.02 }}
                      whileTap={{ scale: 0.98 }}
                      onClick={closeModal}
                      className="flex-1 px-6 py-3 border-2 border-gray-300 text-gray-700 rounded-xl font-semibold hover:bg-gray-50 transition-all"
                    >
                      Cancel
                    </motion.button>
                    <motion.button
                      type="submit"
                      whileHover={{ scale: 1.02 }}
                      whileTap={{ scale: 0.98 }}
                      className="flex-1 px-6 py-3 bg-gradient-to-r from-indigo-600 to-purple-600 hover:from-indigo-700 hover:to-purple-700 text-white rounded-xl font-semibold shadow-lg transition-all"
                    >
                      {editingSubject ? 'Save' : 'Create'}
                    </motion.button>
                  </div>
                </form>
              </motion.div>
            </motion.div>
          )}
        </AnimatePresence>
      </div>
    </Layout>
  );
};

export default SubjectsManagement;
