import { useState, useEffect } from 'react';
import { motion } from 'framer-motion';
import { BookOpen, GraduationCap, TrendingUp, Award, Sparkles } from 'lucide-react';
import { Layout } from '../../components/Layout';
import { Card, CardHeader, CardTitle, CardContent } from '../../components/ui/Card';
import { Badge } from '../../components/ui/Badge';
import * as gradesApi from '../../services/gradesApi';
import type { Grade } from '../../services/gradesApi';

const MyGrades = () => {
  const [grades, setGrades] = useState<Grade[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    loadGrades();
  }, []);

  const loadGrades = async () => {
    setLoading(true);
    try {
      const data = await gradesApi.getMyGrades();
      setGrades(data);
    } catch (error) {
      console.error('Error loading grades:', error);
    } finally {
      setLoading(false);
    }
  };

  const getGradeColor = (value: number) => {
    if (value >= 9) return 'text-green-600 bg-green-50 border-green-200';
    if (value >= 7) return 'text-blue-600 bg-blue-50 border-blue-200';
    if (value >= 5) return 'text-yellow-600 bg-yellow-50 border-yellow-200';
    return 'text-red-600 bg-red-50 border-red-200';
  };

  const calculateAverage = () => {
    if (grades.length === 0) return 0;
    const sum = grades.reduce((acc, grade) => acc + grade.value, 0);
    return (sum / grades.length).toFixed(2);
  };

  const groupGradesBySubject = () => {
    const grouped: { [key: string]: Grade[] } = {};
    grades.forEach((grade) => {
      if (!grouped[grade.subjectName]) {
        grouped[grade.subjectName] = [];
      }
      grouped[grade.subjectName].push(grade);
    });
    return grouped;
  };

  const getSubjectAverage = (subjectGrades: Grade[]) => {
    const sum = subjectGrades.reduce((acc, grade) => acc + grade.value, 0);
    return (sum / subjectGrades.length).toFixed(2);
  };

  const groupedGrades = groupGradesBySubject();
  const average = calculateAverage();

  return (
    <Layout>
      <div className="space-y-8">
        {/* Hero Header */}
        <motion.div
          initial={{ opacity: 0, y: -20 }}
          animate={{ opacity: 1, y: 0 }}
          className="relative overflow-hidden rounded-2xl bg-gradient-to-br from-teal-500 via-cyan-600 to-blue-600 p-8 text-white shadow-2xl"
        >
          <div className="absolute inset-0 bg-[url('data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iNjAiIGhlaWdodD0iNjAiIHZpZXdCb3g9IjAgMCA2MCA2MCIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj48ZyBmaWxsPSJub25lIiBmaWxsLXJ1bGU9ImV2ZW5vZGQiPjxwYXRoIGQ9Ik0zNiAxOGMzLjMxIDAgNiAyLjY5IDYgNnMtMi42OSA2LTYgNi02LTIuNjktNi02IDIuNjktNiA2LTZ6TTI0IDBoNnY2aC02VjB6TTAgMjRoNnY2SDB2LTZ6bTAgMGg2djZIMHYtNnoiIGZpbGw9IiNmZmYiIGZpbGwtb3BhY2l0eT0iLjA1Ii8+PC9nPjwvc3ZnPg==')] opacity-30"></div>
          
          <div className="relative z-10">
            <div className="flex items-center gap-4">
              <div className="p-3 bg-white/20 backdrop-blur-sm rounded-xl">
                <GraduationCap className="h-8 w-8" />
              </div>
              <div>
                <h1 className="text-4xl font-bold flex items-center gap-2">
                  Notele Mele
                  <Sparkles className="h-6 w-6 text-yellow-300" />
                </h1>
                <p className="text-white/80 mt-1">Vizualizează progresul tău academic</p>
              </div>
            </div>
          </div>
        </motion.div>

        <div className="container mx-auto px-4 max-w-7xl">
          {/* Statistics Cards */}
          <div className="grid grid-cols-1 md:grid-cols-3 gap-6 mb-8">
          <motion.div
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ delay: 0.1 }}
          >
            <Card className="bg-gradient-to-br from-primary/10 to-primary/5 border-primary/20">
              <CardContent className="pt-6">
                <div className="flex items-center justify-between">
                  <div>
                    <p className="text-sm text-primary font-medium mb-1">Media Generală</p>
                    <p className="text-3xl font-bold text-primary">{average}</p>
                  </div>
                  <TrendingUp className="w-12 h-12 text-primary opacity-50" />
                </div>
              </CardContent>
            </Card>
          </motion.div>

          <motion.div
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ delay: 0.2 }}
          >
            <Card className="bg-gradient-to-br from-green-500/10 to-green-500/5 border-green-500/20">
              <CardContent className="pt-6">
                <div className="flex items-center justify-between">
                  <div>
                    <p className="text-sm text-green-600 font-medium mb-1">Total Note</p>
                    <p className="text-3xl font-bold text-green-700">{grades.length}</p>
                  </div>
                  <Award className="w-12 h-12 text-green-600 opacity-50" />
                </div>
              </CardContent>
            </Card>
          </motion.div>

          <motion.div
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ delay: 0.3 }}
          >
            <Card className="bg-gradient-to-br from-purple-500/10 to-purple-500/5 border-purple-500/20">
              <CardContent className="pt-6">
                <div className="flex items-center justify-between">
                  <div>
                    <p className="text-sm text-purple-600 font-medium mb-1">Materii</p>
                    <p className="text-3xl font-bold text-purple-700">
                      {Object.keys(groupedGrades).length}
                    </p>
                  </div>
                  <BookOpen className="w-12 h-12 text-purple-600 opacity-50" />
                </div>
              </CardContent>
            </Card>
          </motion.div>
        </div>

        <div className="container mx-auto px-4 max-w-7xl">
          {/* Grades List */}
          {loading ? (
          <div className="flex justify-center items-center h-64">
            <div className="animate-spin rounded-full h-12 w-12 border-b-2 border-blue-600"></div>
          </div>
        ) : grades.length === 0 ? (
          <Card>
            <CardContent className="py-12 text-center">
              <GraduationCap className="w-16 h-16 text-muted-foreground mx-auto mb-4" />
              <p className="text-xl mb-2">Nu ai nicio notă încă</p>
              <p className="text-muted-foreground">Notele tale vor apărea aici după ce profesorii le acordă</p>
            </CardContent>
          </Card>
        ) : (
          <div className="space-y-6">
            {Object.entries(groupedGrades).map(([subjectName, subjectGrades], index) => (
              <motion.div
                key={subjectName}
                initial={{ opacity: 0, y: 20 }}
                animate={{ opacity: 1, y: 0 }}
                transition={{ delay: 0.1 * index }}
              >
                <Card>
                  <CardHeader>
                    <div className="flex justify-between items-center">
                      <div className="flex items-center gap-3">
                        <BookOpen className="w-6 h-6 text-primary" />
                        <div>
                          <CardTitle className="text-xl">{subjectName}</CardTitle>
                          <p className="text-sm text-muted-foreground">
                            {subjectGrades[0].professorName}
                          </p>
                        </div>
                      </div>
                      <Badge className="bg-primary/10 text-primary border-primary/20 text-lg px-4 py-2">
                        Media: {getSubjectAverage(subjectGrades)}
                      </Badge>
                    </div>
                  </CardHeader>
                  <CardContent>
                    <div className="space-y-3">
                      {subjectGrades.map((grade) => (
                        <div
                          key={grade.id}
                          className="p-4 border rounded-lg hover:shadow-md transition-shadow"
                        >
                          <div className="flex justify-between items-start">
                            <div className="flex-1">
                              <div className="flex items-center gap-3 mb-2">
                                <Badge className={`${getGradeColor(grade.value)} font-bold text-lg px-3 py-1`}>
                                  {grade.value.toFixed(2)}
                                </Badge>
                                <span className="text-sm text-muted-foreground">
                                  {new Date(grade.createdAt).toLocaleDateString('ro-RO', {
                                    year: 'numeric',
                                    month: 'long',
                                    day: 'numeric',
                                  })}
                                </span>
                              </div>
                              {grade.comments && (
                                <div className="mt-2 p-3 bg-accent rounded-lg">
                                  <p className="text-sm text-muted-foreground">
                                    <span className="font-medium">Comentarii: </span>
                                    {grade.comments}
                                  </p>
                                </div>
                              )}
                            </div>
                          </div>
                        </div>
                      ))}
                    </div>
                  </CardContent>
                </Card>
              </motion.div>
            ))}
          </div>
        )}
        </div>
        </div>
      </div>
    </Layout>
  );
};

export default MyGrades;
