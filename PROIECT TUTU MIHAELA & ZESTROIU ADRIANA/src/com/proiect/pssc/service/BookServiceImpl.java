package com.proiect.pssc.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import com.proiect.pssc.dao.BookDAO;
import com.proiect.pssc.entity.Book;

@Service
public class BookServiceImpl implements BookService {

	// need to inject the StudentDAO
	@Autowired
	private BookDAO bookDAO;

	@Override
	@Transactional
	public List<Book> getBooks(int theId) {
		return bookDAO.getBooks(theId);
	}

}
