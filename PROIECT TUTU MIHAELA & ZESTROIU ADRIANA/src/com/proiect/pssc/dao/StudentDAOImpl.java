package com.proiect.pssc.dao;

import java.util.List;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.query.Query;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;
import org.springframework.transaction.annotation.Transactional;

import com.proiect.pssc.entity.Student;

@Repository // this annotation is always applied to the DAO implementation
public class StudentDAOImpl implements StudentDAO {

	// need to inject the hibernate sesion factory
	@Autowired
	private SessionFactory sessionFactory;

	@Override
//	@Transactional spring starts and ends session automatically 
	// commented bc this annotation was added to the StudentServiceImpl
	public List<Student> getStudents() {

		// get the current hibernate session
		Session currentSession = sessionFactory.getCurrentSession();

		// create a query ... sort by last name
		Query<Student> theQuery = 
				currentSession.createQuery("from Student order by last_name", Student.class);

		// execute query and get result list
		List<Student> students = theQuery.getResultList();

		// return the results
		return students;
	}

	@Override
	public void saveStudent(Student theStudent) {

		// get current hibernate session
		Session currentSession = sessionFactory.getCurrentSession();
		
		// save the student 
		currentSession.saveOrUpdate(theStudent);
	}

	@Override
	public Student getStudent(int theId) {

		// get current hibernate session
		Session currentSession = sessionFactory.getCurrentSession();
		
		// retrieve/read from the database using the primary key 
		Student theStudent = currentSession.get(Student.class, theId);
		
		return theStudent;
	}

	@Override
	public void deleteStudent(int theId) {

		// get current hibernate session
		Session currentSession = sessionFactory.getCurrentSession();
		
		// delete object with primary key equat to the id that was passed in
		Query theQuery = currentSession.createQuery("delete from Student where id=:studentId");
		
		theQuery.setParameter("studentId", theId);
		
		theQuery.executeUpdate();
	}

}

