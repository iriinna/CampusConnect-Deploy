import React, { useState, useEffect } from 'react';
import { motion } from 'framer-motion';
import { gradeApi } from '../services/gradesApi';
import type { StudentGradesResponse } from '../services/gradesApi';
import { BookOpen, Calendar, Award, BarChart3, Star, GraduationCap, Trophy } from 'lucide-react';
import { Layout } from '../components/Layout';

const StudentGrades: React.FC = () => {
  const [gradesData, setGradesData] = useState<StudentGradesResponse | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');

  useEffect(() => {
    loadGrades();
  }, []);

  const loadGrades = async () => {
    try {
      setLoading(true);
      const data = await gradeApi.getMyGrades();
      setGradesData(data);
      setError('');
    } catch (err: any) {
      setError(err.response?.data?.message || 'Eroare la încărcarea notelor');
    } finally {
      setLoading(false);
    }
  };

  if (loading) {
    return (
      <Layout>
        <div className="flex justify-center items-center h-screen bg-slate-900">
          <div className="relative">
            <div className="animate-spin rounded-full h-16 w-16 border-b-4 border-indigo-500"></div>
            <GraduationCap className="absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 text-indigo-500" size={24} />
          </div>
        </div>
      </Layout>
    );
  }

  if (error) {
    return (
      <Layout>
        <div className="min-h-screen bg-slate-900 py-8">
          <div className="container mx-auto px-4">
            <motion.div 
              initial={{ opacity: 0, y: 20 }}
              animate={{ opacity: 1, y: 0 }}
              className="bg-red-900/20 border-l-4 border-red-500 text-red-200 px-6 py-4 rounded-lg shadow-md"
            >
              <p className="font-semibold text-lg">Eroare!</p>
              <p className="text-red-300">{error}</p>
            </motion.div>
          </div>
        </div>
      </Layout>
    );
  }

  if (!gradesData || gradesData.subjectGrades.length === 0) {
    return (
      <Layout>
        <div className="min-h-screen bg-slate-900">
          <div className="container mx-auto px-4 py-12">
            <motion.div
              initial={{ opacity: 0, y: 20 }}
              animate={{ opacity: 1, y: 0 }}
              className="text-center py-20"
            >
              <div className="inline-block p-6 bg-gradient-to-br from-indigo-900/50 to-purple-900/50 rounded-full mb-6">
                <BookOpen className="text-indigo-400" size={64} />
              </div>
              <h1 className="text-4xl font-bold text-white mb-4">My Grades</h1>
              <p className="text-gray-400 text-xl">No grades recorded yet.</p>
              <p className="text-gray-500 mt-2">Your grades will appear here when professors add them.</p>
            </motion.div>
          </div>
        </div>
      </Layout>
    );
  }

  // Calculate overall average
  const allGrades = gradesData.subjectGrades.flatMap((sg) => sg.grades);
  const overallAverage =
    allGrades.length > 0
      ? allGrades.reduce((sum, g) => sum + g.value, 0) / allGrades.length
      : 0;
  
  const getGradeColor = (grade: number) => {
    if (grade >= 9) return 'from-emerald-500 to-green-600';
    if (grade >= 7) return 'from-blue-500 to-indigo-600';
    if (grade >= 5) return 'from-amber-500 to-orange-600';
    return 'from-red-500 to-rose-600';
  };

  const getGradeBadgeColor = (grade: number) => {
    if (grade >= 9) return 'bg-gradient-to-r from-emerald-500 to-green-600 text-white shadow-lg shadow-green-500/30';
    if (grade >= 7) return 'bg-gradient-to-r from-blue-500 to-indigo-600 text-white shadow-lg shadow-blue-500/30';
    if (grade >= 5) return 'bg-gradient-to-r from-amber-500 to-orange-600 text-white shadow-lg shadow-amber-500/30';
    return 'bg-gradient-to-r from-red-500 to-rose-600 text-white shadow-lg shadow-red-500/30';
  };

  return (
    <Layout>
      <div className="min-h-screen bg-slate-900">
        {/* Hero Header */}
        <motion.div 
          initial={{ opacity: 0, y: -20 }}
          animate={{ opacity: 1, y: 0 }}
          className="bg-gradient-to-br from-slate-800 via-purple-900 to-slate-800 text-white shadow-xl border-b border-purple-700/30"
        >
          <div className="container mx-auto px-4 py-10">
            <motion.div
              initial={{ opacity: 0, y: 20 }}
              animate={{ opacity: 1, y: 0 }}
              transition={{ delay: 0.1 }}
              className="mb-6"
            >
              <div className="flex items-center gap-3 mb-3">
                <div className="p-3 bg-indigo-600 rounded-xl shadow-lg">
                  <GraduationCap className="h-8 w-8 text-white" />
                </div>
                <div>
                  <h1 className="text-3xl md:text-4xl font-bold text-white">My Grades</h1>
                  <p className="text-purple-200 text-sm md:text-base">Academic Performance</p>
                </div>
              </div>
            </motion.div>

            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-4">
              {/* Student Info */}
              <motion.div
                initial={{ opacity: 0, x: -20 }}
                animate={{ opacity: 1, x: 0 }}
                transition={{ delay: 0.2 }}
                className="lg:col-span-2 bg-white/10 backdrop-blur-md rounded-xl p-4 border border-white/20"
              >
                <h2 className="text-xl font-bold text-white mb-1">{gradesData.studentName}</h2>
                <p className="text-purple-200">{gradesData.studentEmail}</p>
              </motion.div>

              {/* Stats */}
              <motion.div
                initial={{ opacity: 0, x: -10 }}
                animate={{ opacity: 1, x: 0 }}
                transition={{ delay: 0.3 }}
                className="bg-gradient-to-br from-emerald-500 to-green-600 rounded-xl p-4 text-white shadow-lg"
              >
                <div className="flex items-center gap-2 mb-2">
                  <Trophy className="h-5 w-5" />
                  <span className="text-sm font-medium opacity-90">Overall Average</span>
                </div>
                <div className="text-3xl font-bold">{overallAverage.toFixed(2)}</div>
              </motion.div>

              <motion.div
                initial={{ opacity: 0, x: 10 }}
                animate={{ opacity: 1, x: 0 }}
                transition={{ delay: 0.4 }}
                className="bg-gradient-to-br from-blue-500 to-indigo-600 rounded-xl p-4 text-white shadow-lg"
              >
                <div className="flex items-center gap-2 mb-2">
                  <BookOpen className="h-5 w-5" />
                  <span className="text-sm font-medium opacity-90">Subjects</span>
                </div>
                <div className="text-3xl font-bold">{gradesData.subjectGrades.length}</div>
                <div className="text-xs opacity-75 mt-1">{allGrades.length} total grades</div>
              </motion.div>
            </div>
          </div>
        </motion.div>

        {/* Subjects Grid */}
        <div className="container mx-auto px-4 py-8 max-w-7xl">
          <div className="grid grid-cols-1 lg:grid-cols-2 gap-6">
            {gradesData.subjectGrades.map((subjectGrade, index) => (
              <motion.div
                key={subjectGrade.subjectId}
                initial={{ opacity: 0, y: 20 }}
                animate={{ opacity: 1, y: 0 }}
                transition={{ delay: index * 0.1 }}
                whileHover={{ y: -5, scale: 1.01 }}
                className="bg-slate-800 rounded-2xl shadow-xl overflow-hidden border-2 border-slate-700 hover:border-indigo-500 hover:shadow-2xl hover:shadow-indigo-500/20 transition-all duration-300"
              >
                {/* Subject Header */}
                <div className={`bg-gradient-to-br ${getGradeColor(subjectGrade.averageGrade || 0)} p-6 text-white relative overflow-hidden shadow-lg`}>
                  <div className="absolute top-0 right-0 opacity-10">
                    <BookOpen size={120} />
                  </div>
                  <div className="relative z-10">
                    <div className="flex justify-between items-start mb-3">
                      <div className="flex-1">
                        <h3 className="text-2xl md:text-3xl font-bold mb-2 text-white drop-shadow-lg">
                          {subjectGrade.subjectName}
                        </h3>
                        <div className="inline-block bg-white/30 backdrop-blur-sm px-3 py-1 rounded-full">
                          <p className="text-white font-mono text-sm font-semibold">{subjectGrade.subjectCode}</p>
                        </div>
                      </div>
                      {subjectGrade.averageGrade !== undefined && (
                        <div className="bg-white/25 backdrop-blur-md rounded-2xl p-4 text-center border-2 border-white/40 shadow-xl">
                          <div className="flex items-center gap-1 mb-1 justify-center">
                            <Star className="h-4 w-4 fill-yellow-300 text-yellow-300" />
                            <p className="text-xs font-bold text-white">AVERAGE</p>
                          </div>
                          <div className="text-4xl font-black text-white drop-shadow-lg">
                            {subjectGrade.averageGrade.toFixed(2)}
                          </div>
                        </div>
                      )}
                    </div>
                    <div className="flex items-center gap-2 mt-4 bg-white/15 backdrop-blur-sm rounded-lg p-2 inline-flex">
                      <div className="h-7 w-7 bg-white/30 rounded-full flex items-center justify-center">
                        <GraduationCap size={16} className="text-white" />
                      </div>
                      <p className="text-sm font-medium text-white">
                        Professor: <span className="font-bold">{subjectGrade.professorName}</span>
                      </p>
                    </div>
                  </div>
                </div>

                {/* Grades List */}
                <div className="p-6 bg-slate-800/50">
                  {subjectGrade.grades.length === 0 ? (
                    <div className="text-center py-12">
                      <div className="inline-block p-5 bg-slate-700/50 rounded-2xl mb-4">
                        <Award className="text-slate-500" size={40} />
                      </div>
                      <p className="text-gray-400 font-semibold text-lg">No grades for this subject yet.</p>
                    </div>
                  ) : (
                    <div className="space-y-4">
                      {subjectGrade.grades.map((grade, gradeIndex) => (
                        <motion.div
                          key={grade.id}
                          initial={{ opacity: 0, x: -20 }}
                          animate={{ opacity: 1, x: 0 }}
                          transition={{ delay: gradeIndex * 0.05 }}
                          className="group relative bg-slate-700/50 rounded-2xl p-5 border-2 border-slate-600 hover:border-indigo-500 hover:shadow-xl hover:shadow-indigo-500/10 transition-all duration-300"
                        >
                          <div className="flex items-start gap-4">
                            <div className={`${getGradeBadgeColor(grade.value)} rounded-2xl px-5 py-4 text-center min-w-[80px] transform group-hover:scale-110 transition-transform duration-300`}>
                              <div className="text-3xl font-black leading-none">{grade.value.toFixed(2)}</div>
                            </div>
                            <div className="flex-1">
                              <div className="flex items-center gap-2 mb-3">
                                <div className="bg-indigo-600/30 p-1.5 rounded-lg">
                                  <Calendar size={16} className="text-indigo-400" />
                                </div>
                                <span className="text-sm font-bold text-gray-300">
                                  {new Date(grade.createdAt).toLocaleDateString('en-US', {
                                    day: '2-digit',
                                    month: 'long',
                                    year: 'numeric',
                                  })}
                                </span>
                              </div>
                              {grade.comments && (
                                <div className="bg-gradient-to-r from-indigo-900/40 to-purple-900/40 border-l-4 border-indigo-500 p-4 rounded-r-xl mb-3 shadow-sm">
                                  <p className="text-sm text-gray-200 font-medium italic leading-relaxed">"{grade.comments}"</p>
                                </div>
                              )}
                              <div className="flex items-center gap-2 text-xs text-gray-400 bg-slate-700/70 px-3 py-2 rounded-lg inline-flex">
                                <GraduationCap size={14} className="text-indigo-400" />
                                <span>Added by: <span className="font-bold text-gray-200">{grade.createdByProfessorName}</span></span>
                              </div>
                            </div>
                          </div>
                        </motion.div>
                      ))}
                    </div>
                  )}
                </div>

                {/* Subject Footer Stats */}
                {subjectGrade.grades.length > 0 && (
                  <div className="bg-slate-700/50 px-6 py-4 border-t-2 border-slate-600">
                    <div className="flex justify-between items-center">
                      <div className="flex items-center gap-2">
                        <BarChart3 size={18} className="text-indigo-400" />
                        <span className="font-bold text-gray-200">Total grades: {subjectGrade.grades.length}</span>
                      </div>
                      <div className="flex gap-4 text-sm font-bold">
                        <span className="flex items-center gap-1.5">
                          <span className="text-xs text-gray-500">Min:</span>
                          <span className="text-red-400 text-lg">{Math.min(...subjectGrade.grades.map((g) => g.value)).toFixed(2)}</span>
                        </span>
                        <span className="h-6 w-px bg-slate-600"></span>
                        <span className="flex items-center gap-1.5">
                          <span className="text-xs text-gray-500">Max:</span>
                          <span className="text-green-400 text-lg">{Math.max(...subjectGrade.grades.map((g) => g.value)).toFixed(2)}</span>
                        </span>
                      </div>
                    </div>
                  </div>
                )}
              </motion.div>
            ))}
          </div>
        </div>
      </div>
    </Layout>
  );
};

export default StudentGrades;
