const API_BASE_URL = 'http://localhost:5099/api';

// Helper pentru a obține token-ul
const getAuthToken = () => {
  return localStorage.getItem('token');
};

// Helper pentru headere cu autentificare
const getAuthHeaders = () => {
  const token = getAuthToken();
  return {
    'Content-Type': 'application/json',
    ...(token && { 'Authorization': `Bearer ${token}` })
  };
};

export interface Subject {
  id: number;
  name: string;
  description?: string;
  professorId: number;
  professorName: string;
  createdAt: string;
  gradesCount: number;
}

export interface Grade {
  id: number;
  subjectId: number;
  subjectName: string;
  studentId: number;
  studentName: string;
  studentEmail: string;
  studentId_Number?: string;
  value: number;
  comments?: string;
  createdAt: string;
  updatedAt?: string;
  professorName: string;
}

export interface CreateSubjectRequest {
  name: string;
  description?: string;
}

export interface UpdateSubjectRequest {
  name: string;
  description?: string;
}

export interface CreateGradeRequest {
  subjectId: number;
  studentId: number;
  value: number;
  comments?: string;
}

export interface UpdateGradeRequest {
  value: number;
  comments?: string;
}

// Subject API functions
export const getAllSubjects = async (): Promise<Subject[]> => {
  try {
    const response = await fetch(`${API_BASE_URL}/Subject`, {
      method: 'GET',
      headers: getAuthHeaders(),
    });

    if (!response.ok) {
      throw new Error('Failed to fetch subjects');
    }

    return await response.json();
  } catch (error) {
    console.error('Error fetching subjects:', error);
    throw error;
  }
};

export const getMySubjects = async (): Promise<Subject[]> => {
  try {
    const response = await fetch(`${API_BASE_URL}/Subject/my-subjects`, {
      method: 'GET',
      headers: getAuthHeaders(),
    });

    if (!response.ok) {
      throw new Error('Failed to fetch my subjects');
    }

    return await response.json();
  } catch (error) {
    console.error('Error fetching my subjects:', error);
    throw error;
  }
};

export const getSubjectById = async (id: number): Promise<Subject> => {
  try {
    const response = await fetch(`${API_BASE_URL}/Subject/${id}`, {
      method: 'GET',
      headers: getAuthHeaders(),
    });

    if (!response.ok) {
      throw new Error('Failed to fetch subject');
    }

    return await response.json();
  } catch (error) {
    console.error('Error fetching subject:', error);
    throw error;
  }
};

export const createSubject = async (request: CreateSubjectRequest): Promise<Subject> => {
  try {
    const response = await fetch(`${API_BASE_URL}/Subject`, {
      method: 'POST',
      headers: getAuthHeaders(),
      body: JSON.stringify(request),
    });

    if (!response.ok) {
      throw new Error('Failed to create subject');
    }

    return await response.json();
  } catch (error) {
    console.error('Error creating subject:', error);
    throw error;
  }
};

export const updateSubject = async (id: number, request: UpdateSubjectRequest): Promise<Subject> => {
  try {
    const response = await fetch(`${API_BASE_URL}/Subject/${id}`, {
      method: 'PUT',
      headers: getAuthHeaders(),
      body: JSON.stringify(request),
    });

    if (!response.ok) {
      throw new Error('Failed to update subject');
    }

    return await response.json();
  } catch (error) {
    console.error('Error updating subject:', error);
    throw error;
  }
};

export const deleteSubject = async (id: number): Promise<void> => {
  try {
    const response = await fetch(`${API_BASE_URL}/Subject/${id}`, {
      method: 'DELETE',
      headers: getAuthHeaders(),
    });

    if (!response.ok) {
      throw new Error('Failed to delete subject');
    }
  } catch (error) {
    console.error('Error deleting subject:', error);
    throw error;
  }
};

// Grade API functions
export const getMyGrades = async (): Promise<Grade[]> => {
  try {
    const response = await fetch(`${API_BASE_URL}/Grade/my-grades`, {
      method: 'GET',
      headers: getAuthHeaders(),
    });

    if (!response.ok) {
      throw new Error('Failed to fetch my grades');
    }

    return await response.json();
  } catch (error) {
    console.error('Error fetching my grades:', error);
    throw error;
  }
};

export const getSubjectGrades = async (subjectId: number): Promise<Grade[]> => {
  try {
    const response = await fetch(`${API_BASE_URL}/Grade/subject/${subjectId}`, {
      method: 'GET',
      headers: getAuthHeaders(),
    });

    if (!response.ok) {
      throw new Error('Failed to fetch subject grades');
    }

    return await response.json();
  } catch (error) {
    console.error('Error fetching subject grades:', error);
    throw error;
  }
};

export const getGradeById = async (id: number): Promise<Grade> => {
  try {
    const response = await fetch(`${API_BASE_URL}/Grade/${id}`, {
      method: 'GET',
      headers: getAuthHeaders(),
    });

    if (!response.ok) {
      throw new Error('Failed to fetch grade');
    }

    return await response.json();
  } catch (error) {
    console.error('Error fetching grade:', error);
    throw error;
  }
};

export const createGrade = async (request: CreateGradeRequest): Promise<Grade> => {
  try {
    const response = await fetch(`${API_BASE_URL}/Grade`, {
      method: 'POST',
      headers: getAuthHeaders(),
      body: JSON.stringify(request),
    });

    if (!response.ok) {
      throw new Error('Failed to create grade');
    }

    return await response.json();
  } catch (error) {
    console.error('Error creating grade:', error);
    throw error;
  }
};

export const updateGrade = async (id: number, request: UpdateGradeRequest): Promise<Grade> => {
  try {
    const response = await fetch(`${API_BASE_URL}/Grade/${id}`, {
      method: 'PUT',
      headers: getAuthHeaders(),
      body: JSON.stringify(request),
    });

    if (!response.ok) {
      throw new Error('Failed to update grade');
    }

    return await response.json();
  } catch (error) {
    console.error('Error updating grade:', error);
    throw error;
  }
};

export const deleteGrade = async (id: number): Promise<void> => {
  try {
    const response = await fetch(`${API_BASE_URL}/Grade/${id}`, {
      method: 'DELETE',
      headers: getAuthHeaders(),
    });

    if (!response.ok) {
      throw new Error('Failed to delete grade');
    }
  } catch (error) {
    console.error('Error deleting grade:', error);
    throw error;
  }
};
