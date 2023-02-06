<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>

	<h1>Welcome to EMPLOYEE System</h1>

	<h4>${requestScope.msg}</h4>
	<a href='<spring:url value="/user/login"></spring:url>'>Login</a>
	<a href='<spring:url value="/user/register"></spring:url>'>Register</a>
</body>
</html>