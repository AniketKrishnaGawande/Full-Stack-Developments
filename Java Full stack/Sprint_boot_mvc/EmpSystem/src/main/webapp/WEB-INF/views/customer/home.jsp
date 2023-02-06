<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>

	<h1>Name :: ${sessionScope.dtls.getFName()} ${sessionScope.dtls.getLName()}</h1>
	<h3>Logged in as ${sessionScope.dtls.getRole()}</h3>

</body>
</html>