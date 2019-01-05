<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>

<!DOCTYPE html>
<html>
<head>

<title>Borrowed books</title>

<!-- reference out style sheet -->

<link type="text/css"
	  rel="stylesheet"
	  href="${pageContext.request.contextPath}/resources/css/style.css" />

</head>


<body>

	<div id="wrapper">
		<div id="header">
			<h3>Borrowed books</h3>
		</div>
	</div>

	<div id="container">
		<div id="content">
			<!-- add the html table here -->
			<table>
				<tr>
					<th>Title</th>
					<th>Author</th>
					<th>Publishing</th>
					<th>Release year</th>

				</tr>
				<!-- loop over and print our books -->

				<c:forEach var="tempBook" items="${books}">
					<tr>
						<td>${tempBook.title}</td>
						<td>${tempBook.author}</td>
						<td>${tempBook.publishing}</td>
						<td>${tempBook.releaseYear}</td>
					</tr>
				</c:forEach>
			</table>
		</div>
	</div>

</body>
</html>