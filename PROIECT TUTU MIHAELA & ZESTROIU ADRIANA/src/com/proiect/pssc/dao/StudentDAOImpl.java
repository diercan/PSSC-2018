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
	@Transactional // spring starts and ends session automatically 
	// commented bc this annotation was added to the CustomerServiceImpl
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

}

