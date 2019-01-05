package com.proiect.pssc.dao;

import java.util.List;

import com.proiect.pssc.entity.Book;

public interface BookDAO {

	public List<Book> getBooks(int theId);
		
}
