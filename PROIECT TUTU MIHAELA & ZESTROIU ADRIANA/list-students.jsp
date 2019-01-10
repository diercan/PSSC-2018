<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>

<!DOCTYPE html>
<html>
<head>

<title>List Students</title>

<!-- reference out style sheet -->

<link type="text/css"
	  rel="stylesheet"
	  href="${pageContext.request.contextPath}/resources/css/style.css" />

</head>


<body>

	<div id="wrapper">
		<div id="header">
			<h3>Books for Students</h3>
		</div>
	</div>

	<div id="container">
		<div id="content">

			<table>
				<tr>
					<th>First Name</th>
					<th>Last Name</th>
					<th>Email</th>
					<th>University</th>
					<th>Action</th>

				</tr>
				<!-- loop over and print our students -->

				<c:forEach var="tempStudent" items="${students}">
					<tr>
						<td>${tempStudent.firstName}</td>
						<td>${tempStudent.lastName}</td>
						<td>${tempStudent.email}</td>
						<td>${tempStudent.university}</td>
					</tr>
				</c:forEach>
			</table>
		</div>
	</div>

</body>
</html>