import React, { useState, useEffect } from 'react';
import { motion } from 'framer-motion';
import { gradeApi } from '../services/gradesApi';
import type { StudentGradesResponse } from '../services/gradesApi';
import { BookOpen, GraduationCap, Trophy } from 'lucide-react';
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
    if (grade >= 9) return 'text-green-600 bg-green-50 border-green-200';
    if (grade >= 7) return 'text-blue-600 bg-blue-50 border-blue-200';
    if (grade >= 5) return 'text-yellow-600 bg-yellow-50 border-yellow-200';
    return 'text-red-600 bg-red-50 border-red-200';
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

        {/* Grades List - Minimalist */}
        <div className="container mx-auto px-4 py-8 max-w-7xl">
          <div className="space-y-12">
            {[1, 2, 3].map(year => {
              const yearSubjects = gradesData.subjectGrades.filter(sg => sg.year === year);
              if (yearSubjects.length === 0) return null;

              // Calculate year average
              const yearGrades = yearSubjects.flatMap(sg => sg.grades);
              const yearAverage = yearGrades.length > 0 
                ? yearGrades.reduce((sum, g) => sum + g.value, 0) / yearGrades.length 
                : 0;

              return (
                <motion.div 
                  key={year}
                  initial={{ opacity: 0, y: 20 }}
                  animate={{ opacity: 1, y: 0 }}
                  className="space-y-6 bg-slate-800/30 rounded-xl p-6"
                >
                  {/* Year Header - Ultra Minimalist */}
                  <div className="flex items-center justify-between mb-6 pb-3 border-b-2 border-indigo-500/50">
                    <div className="flex items-center gap-3">
                      <GraduationCap className="text-indigo-400" size={32} />
                      <h2 className="text-3xl font-bold text-white">Anul {year}</h2>
                    </div>
                    <div className="bg-gradient-to-r from-indigo-600 to-purple-600 text-white px-6 py-3 rounded-xl shadow-lg">
                      <div className="text-sm font-medium opacity-90">Media anul {year}</div>
                      <div className="text-2xl font-bold">{yearAverage.toFixed(2)}</div>
                    </div>
                  </div>

                  {/* Subjects List - No Containers */}
                  <div className="space-y-8 pl-2">
                    {yearSubjects.map((subjectGrade, index) => (
                      <motion.div
                        key={subjectGrade.subjectId}
                        initial={{ opacity: 0, x: -10 }}
                        animate={{ opacity: 1, x: 0 }}
                        transition={{ delay: 0.05 * index }}
                        className="space-y-3 bg-slate-800/50 rounded-lg p-4"
                      >
                        {/* Subject Name with Average */}
                        <div className="flex items-baseline gap-3 flex-wrap">
                          <h3 className="text-xl font-semibold text-white">
                            {subjectGrade.subjectName}
                          </h3>
                          <span className="text-sm text-indigo-400 font-medium bg-indigo-900/30 px-3 py-1 rounded-full">
                            Media: {subjectGrade.averageGrade?.toFixed(2) || 'N/A'}
                          </span>
                        </div>

                        {/* Grades - Simple Inline List */}
                        <div className="flex items-center gap-2 flex-wrap pl-2">
                          <span className="text-gray-400 font-medium text-sm">Note:</span>
                          {subjectGrade.grades.map((grade, idx) => (
                            <span key={grade.id} className="inline-flex items-center">
                              <span
                                className={`${getGradeColor(grade.value)} px-3 py-1.5 rounded-md font-bold text-base cursor-help transition-all hover:scale-105 border-2 shadow-sm`}
                                title={`${new Date(grade.createdAt).toLocaleDateString('ro-RO', { day: '2-digit', month: '2-digit', year: 'numeric' })}${grade.comments ? '\n' + grade.comments : ''}`}
                              >
                                {grade.value.toFixed(2)}
                              </span>
                              {idx < subjectGrade.grades.length - 1 && (
                                <span className="text-gray-500 mx-1.5">•</span>
                              )}
                            </span>
                          ))}
                        </div>
                      </motion.div>
                    ))}
                  </div>
                </motion.div>
              );
            })}
          </div>
        </div>
      </div>
    </Layout>
  );
};

export default StudentGrades;
