<%@page import="javax.websocket.Session"%>
<%@page import="java.sql.*" %>
<%@page import="db.DBConnectionHandler" %>
<%@page import="com.sun.org.apache.xalan.internal.xsltc.runtime.Parameter"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Login</title>
</head>
<body>

<%
	String username = request.getParameter("username");
	String password = request.getParameter("password");
	Connection con  = DBConnectionHandler.getConnection();
	PreparedStatement query = con.prepareStatement("select * from users where username = ? and password = ?");
	query.setString(1, username);
	query.setString(2, password);
	ResultSet result = query.executeQuery();
	if(result != null) {
		session.setAttribute("username", username);
		response.sendRedirect("results.jsp");
	} else {
		response.reset();
	}
%>

</body>
</html>