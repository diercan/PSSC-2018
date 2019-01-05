package com.proiect.pssc.entity;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name="book")
public class Book {

	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	@Column(name="id")
	private int id;
	
	@Column(name="title")
	private String title;
	
	@Column(name="author")
	private String author;
	
	@Column(name="publishing")
	private String publishing;
	
	@Column(name="release_year")
	private String releaseYear;
	
	@Column(name="isBorrowed")
	private boolean isBorrowed;
	
	public Book() {
		
	}
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public String getTitle() {
		return title;
	}
	public void setTitle(String title) {
		this.title = title;
	}
	public String getAuthor() {
		return author;
	}
	public void setAuthor(String author) {
		this.author = author;
	}
	public String getPublishing() {
		return publishing;
	}
	public void setPublishing(String publishing) {
		this.publishing = publishing;
	}
	public String getReleaseYear() {
		return releaseYear;
	}
	public void setReleaseYear(String releaseYear) {
		this.releaseYear = releaseYear;
	}

	public boolean isBorrowed() {
		return isBorrowed;
	}
	public void setBorrowed(boolean isBorrowed) {
		this.isBorrowed = isBorrowed;
	}
	
	public Book(int id, String title, String author, String publishing, String releaseYear, String studentId,
			boolean isBorrowed) {
		super();
		this.id = id;
		this.title = title;
		this.author = author;
		this.publishing = publishing;
		this.releaseYear = releaseYear;
		this.isBorrowed = isBorrowed;
	}
	@Override
	public String toString() {
		return "Book [id=" + id + ", title=" + title + ", author=" + author + ", publishing=" + publishing
				+ ", releaseYear=" + releaseYear + ", isBorrowed=" + isBorrowed + "]";
	}
	
}
