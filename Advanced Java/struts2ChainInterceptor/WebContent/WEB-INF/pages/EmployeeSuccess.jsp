<%@taglib uri="/struts-tags" prefix="s"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<title>Employee Suucess Page</title>
</head>
<body>
<h2>Employee details from two Actions<br>
<hr/>
Employee Code :<s:property value="id"/><br>
Employee Name :<s:property value="name"/><br>
Employee City :<s:property value="city"/><br>
Employee Salary :<s:property value="salary"/><br>
<hr/>
<a href="index.jsp"> Try Again</a>
</h2>
</body>
</html>