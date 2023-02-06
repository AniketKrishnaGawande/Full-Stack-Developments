<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ taglib uri="http://www.springframework.org/tags" prefix="spring"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>

	<h2>${requestScope.msg}</h2>
	<table>
		<tr>
			<th>Employee Id</th>
			<th>Employee Name</th>
			<th>Employee Email</th>
			<th>Update</th>
			<th>delete</th>
		</tr>

		<c:forEach var="emp" items="${requestScope.emps}">
			<tr>
				<td>${emp.getId()}</td>
				<td>${emp.getFName()}${emp.getLName()}</td>
				<td>${emp.getEmail()}</td>
				<td><a
					href="<spring:url value='/customer/update/${emp.getId()}'/>">Update
						info</a></td>
				<td><a
					href="<spring:url value='/customer/delete?id=${emp.getId()}'/>">delete
						info</a></td>
			</tr>





		</c:forEach>


	</table>





</body>
</html>