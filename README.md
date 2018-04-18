# webservices-activity2 (CRUD OPERATIONS)
# Technologies - c# XML JSON 
# Software - Fiddler
# Run this on Fiddler
#https://en.wikipedia.org/wiki/Fiddler_(software)

Books

GET
http://localhost:28520/api/Book
This will give the list of all Books available or their status is true.
http://localhost:28520/api/Book/5
This will give the detail of book number 5.
http://localhost:28520/api/Book?category=computer science
This will give the detail of books belongs to a particular category.
http://localhost:28520/api/Book/1/2
This should return Author of book with id 1. Since we enhanced the method to return HttpResponseMessage, the author information is present in header as ‘Book-Author’.

POST
http://localhost:28520/api/Book
This will add the book to the booklist with following details of book.
{ "BookName":"Introduction to webservices", "Author":"Brown", "Category":"computer science", "Status": true}
http://localhost:28520/api/Book?name=Introduction%20to%20webservices&author=Brow n&cat=computer%20science
This will add the book to the booklist with status = true.
http://localhost:28520/api/Book?name=Introduction%20to%20webservices&author=Brow n
This will add the book to the booklist with category=none and status = true.

PUT 
(reserve or free book) http://localhost:28520/api/Book?name=Algorithms%20to%20Live&req=r
1. req=r This will reserve the given book.
2. req=f This will free the given book.
http://localhost:28520/api/Book?name1=Algorithms%20to%20Live&name2=Introduction %20to%20webservices
This will free the given book free the given books in name1 and name2.
http://localhost:28520/api/Book/5
This will edit the book number 5 in the booklist with following details of book.
{ "BookName":"Introduction to webservices", "Author":"Brown", "Category":"computer science", "Status": true}

DELETE
http://localhost:28520/api/Book/5
This will delete the book number 5 from the booklist. http://localhost:28520/api/Book?name=Introduction%20to%20webservices This will delete the book with given name from the booklist.

Code:
AC_06 - Copy\AC_06\Controllers\BookController.cs
This file includes the whole code for CURD functionality.

AC_06 - Copy\AC_06\user.aspx.cs
This file includes all the functionality to call API and parse XML Document to display result. GET and PUT are used to provide this functionality.

Additional work:
USER INTERFACE
I have created the following user interface for some Get methods: 1. The following page will display.
http://localhost:28520/user.aspx
 
