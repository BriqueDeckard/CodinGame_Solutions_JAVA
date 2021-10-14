package edu.bd.notes.jdbc;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class JDBCExample {

	// Connection string
	private static final String conUrl = "jdbc:postgresql://localhost/TestConnectJava";

	// User
	private static final String username = "postgres";

	// the pasword of the user
	private static final String password = "6845";
	
	
	public static Connection connection() {
		Connection conn = null;
		
		try {
			conn = DriverManager.getConnection(conUrl, username, password);
			System.out.println("You are connected to the database server.");
		}catch (SQLException e) {
			System.err.println(e.getMessage());
		}
		
		return conn;
	}

}
