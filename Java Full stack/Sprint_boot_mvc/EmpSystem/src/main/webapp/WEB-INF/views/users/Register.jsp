<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<table>
		<form method="post">
			<tr>
				<th><label for="fname">First Name</label></th>
				<td><input type="text" name="fname" required></td>
			</tr>
			<tr>
				<th><label for="lname">Last Name</label></th>
				<td><input type="text" name="lname" required></td>
			</tr>
			<tr>
				<th><label for="fname">email id</label></th>
				<td><input type="email" name="email" required></td>
			</tr>
			<tr>
				<th><label for="pass">Password</label></th>
				<td><input type="password" name="pass" required></td>
			</tr>
			<tr>
				<td>
					<button type="submit">Register</button>
				</td>
			</tr>
		</form>
	</table>



</body>
</html>