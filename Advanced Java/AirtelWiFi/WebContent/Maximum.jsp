	<%@page import="java.util.ArrayList"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Maximum</title>
</head>
<body>

<%
	String numberList[] = request.getParameterValues("input");
	int numbers[] = null;
	out.print(numberList.length);
	for(int i = 0; i <= numberList.length; ++i){
		numbers[i] = Integer.parseInt(numberList[i]);
	}
	int max = numbers[0];
	for(int i = 1; i <= numbers.length; i++){
		if(max > numbers[i]){
			max = numbers[i];
		}
	}
	out.print("Max: " + max);
%>

</body>
</html>