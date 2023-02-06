<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://www.springframework.org/tags/form"
	prefix="spring"%>

<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>


	<table>
		<spring:form method="post" modelAttribute="emp">
			<tr>

				<th>Id</th>
				<td><spring:input path="id" readonly="true" /></td>
			</tr>
			<tr>

				<th>first name</th>
				<td><spring:input path="fName" /></td>
			</tr>
			<tr>

				<th>Last name</th>
				<td><spring:input path="lName" /></td>
			</tr>

			<tr>

				<th>Email id</th>
				<td><spring:input type="email" path="email" /></td>
			</tr>
			<tr>
				<td><spring:button type="submit">update details</spring:button>
				</td>
			</tr>

		</spring:form>

	</table>




</body>
</html>