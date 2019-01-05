package com.proiect.pssc.dao;

import java.util.List;

import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.query.Query;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import com.proiect.pssc.entity.Book;

@Repository
public class BookDAOImpl implements BookDAO {

	// need to inject the hibernate sesion factory
	@Autowired
	private SessionFactory sessionFactory;

	@Override
	public List<Book> getBooks(int theId) {

		// get the current hibernate session
		Session currentSession = sessionFactory.getCurrentSession();
		
		// create a query ... sort by last name
		Query<Book> theQuery = 
				currentSession.createQuery("from Book where student_id=:studentId ", Book.class);

		theQuery.setParameter("studentId", theId);
		
		// execute query and get result list
		List<Book> books = theQuery.getResultList();

		// return the results
		return books;
	}

}
