package db;
import java.sql.*;

public class DBConnectionHandler {

	static Connection con = null;
	
	public static Connection getConnection() {
		try {
			Class.forName("com.mysql.jdbc.Driver");
			con = DriverManager.getConnection("jdbc:mysql://localhost:3306","root","password");
		} catch (Exception e) {
			e.printStackTrace();
		}
		return con;
	}
	
	public static void main(String[] args) {
		try {
			con = getConnection();
			if (con != null) {
				System.out.println("Databse Connected");
			}
			
		} catch (Exception e) {
			e.printStackTrace();
		}
		
	}

}
