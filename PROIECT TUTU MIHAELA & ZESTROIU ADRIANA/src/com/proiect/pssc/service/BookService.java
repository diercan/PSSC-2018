package com.proiect.pssc.service;

import java.util.List;

import com.proiect.pssc.entity.Book;


public interface BookService {

	public List<Book> getBooks(int theId);
	
}
