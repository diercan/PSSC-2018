package com.proiect.pssc.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;

import com.proiect.pssc.entity.Student;
import com.proiect.pssc.service.StudentService;


@Controller 
@RequestMapping("/student")
public class StudentController {

	// need to inject our student service
	@Autowired
	private StudentService studentService;
	
	@GetMapping("/list")
	public String listStudents(Model theModel) {
		
		// get student from the service
		List<Student> theStudents = studentService.getStudents();
		
		System.out.println("Students: " + theStudents);
		// add students to the model
		theModel.addAttribute("students", theStudents);
		
		return "list-students";
	}
	
	@GetMapping("/showFormForAddingStudent")
	public String showFromForAddingStudent(Model theModel) {
		
		// create model attribute to bind form data
		Student theStudent = new Student();
		
		theModel.addAttribute("student", theStudent);
		
		
		return "student-form";
	}
	
	@PostMapping("/saveStudent")
	public String saveStudent(@ModelAttribute("student") Student theStudent) {
		
		// save the customer 
		studentService.saveStudent(theStudent);
		
		return "redirect:/student/list";
		
	}
	
	@GetMapping("/showFormForUpdateStudent")
	public String showFormForUpdateStudent(@RequestParam("studentId") int theId, Model theModel) {
		
		// get the student from the service
		Student theStudent = studentService.getStudent(theId);

		// set student as a model attribute to pre-poulate the form
		theModel.addAttribute("student", theStudent);
		
		// send it over to our form
		return "student-form";
		
	}
	
	@GetMapping("/delete")
	public String deleteStudent(@RequestParam("studentId") int theId) {
		
		// delete the student
		studentService.deleteStudent(theId);
		
		return "redirect:/student/list";
		
	}
}
