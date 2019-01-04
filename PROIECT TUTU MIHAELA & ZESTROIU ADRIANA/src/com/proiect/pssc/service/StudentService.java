package com.proiect.pssc.service;

import java.util.List;

import com.proiect.pssc.entity.Student;

public interface StudentService {

	public List<Student> getStudents();

	public void saveStudent(Student theStudent);

	public Student getStudent(int theId);

	public void deleteStudent(int theId);
}
