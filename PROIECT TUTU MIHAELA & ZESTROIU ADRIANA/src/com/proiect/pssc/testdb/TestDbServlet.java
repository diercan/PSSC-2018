package com.proiect.pssc.testdb;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class TestDbServlet
 */
@WebServlet("/TestDbServlet")
public class TestDbServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		// setup connection variables
		String user = "proiectpssc";
		String password = "proiectpssc";
		
		String jdbcUrl = "jdbc:mysql://localhost:3306/proiect_pssc?useSSL=false";
		String driver = "com.mysql.jdbc.Driver";
		
		// get connection to database
		try {
			PrintWriter out = response.getWriter();
			
			out.println("Connecting to database: " + jdbcUrl);
			
			Class.forName(driver);
			
			Connection myConn = DriverManager.getConnection(jdbcUrl, user, password);
			
			Statement st = myConn.createStatement();
			String sql = ("SELECT * FROM student");
			ResultSet rs = st.executeQuery(sql);
			if(rs.next()) { 
			 int id = rs.getInt("id"); 
			 String str1 = rs.getString("first_name");
			 
			 out.println("id: " + id);
			 out.println("name: " + str1);
			}

			out.println("\nConnection successful!");
			
			myConn.close();
			
			
		} catch(Exception ex) {
			ex.printStackTrace();
			throw new ServletException();
		}
		
	}

}
