package com.proiect.pssc.dao;

import java.util.List;

import com.proiect.pssc.entity.Student;

public interface StudentDAO {

	public List<Student> getStudents();

	public void saveStudent(Student theStudent);

	public Student getStudent(int theId);

	public void deleteStudent(int theId);

}
