package com.proiect.pssc.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import com.proiect.pssc.dao.StudentDAO;
import com.proiect.pssc.entity.Student;


@Controller 
@RequestMapping("/student")
public class StudentController {

	// need to inject our customer service
	@Autowired
	private StudentDAO studentDAO;
	
	@RequestMapping("/list")
	public String listStudents(Model theModel) {
		
		// get student from dao
		List<Student> theStudents = studentDAO.getStudents();
		
		System.out.println("Students: " + theStudents);
		// add students to the model
		theModel.addAttribute("students", theStudents);
		
		
		return "list-students";
	}
	
}
