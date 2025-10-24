ASSIGNMENT-1
------------

1) List all patients and their appointments, including patients who have never had an appointment.
-> select * from patients left join appointments on appointments.patientId = patients.patientId;

2) Display all doctors and their scheduled appointments, including doctors without any appointments.
-> select * from doctors left join appointments on doctors.doctorId = appointments.doctorId;

3) Show all medications and the patients they've been prescribed to, including medications that haven't been prescribed.
-> select * from medications left join prescriptions on medications.medicationId = prescriptions.medicationId left join patients on patients.patientId = prescriptions.patientId;

4) List all possible patient-doctor combinations, regardless of whether an appointment has occurred.
-> select * from patients cross join doctors;

5) Display all prescriptions with patient and medication information, including prescriptions where either the patient or medication information is missing.
-> select * from prescriptions left join patients on prescriptions.patientId = patients.patientId left join medications on medications.medicationId = prescriptions.medicationId;

6) Show all patients who have never been prescribed any medication, along with their appointment history.
-> select * from patients left join Prescriptions on Prescriptions.patientid = patients.patientid left join appointments on appointments.patientid = patients.patientid where prescriptions.prescriptionid is null;

7) List all doctors who have appointments in the next week, along with the patients they're scheduled to see.
-> select * from doctors inner join appointments on  doctors.doctorId =  appointments.doctorid inner join patients on patients.patientid = appointments.patientid where appointments.appointmentDate between cast(getdate() as date) and dateadd(day, 7, getdate());

8) Display all medications prescribed to patients over 60 years old, including medications not prescribed to this age group.
-> select * from medications left join prescriptions on prescriptions.medicationid = medications.medicationid left join patients on patients.patientid = prescriptions.patientid and datediff(year, patients.dateofbirth, getdate()) > 60;

9) Show all appointments from last year and any associated prescription information.
-> select * from appointments left join prescriptions on appointments.patientid = prescriptions.patientid where year(appointments.appointmentDate) = year(getdate())-1;

10) List all possible specialty-medication combinations, regardless of whether a doctor of that specialty has prescribed that medication
-> select * from doctors cross join medications;

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

ASSIGNMENT 2 
-------------

1) List all products with their category names, including products without a category.
-> select productName, categoryName from products left join categories on products.categoryId = categories.categoryId;

2) Display all customers and their order history, including customers who haven't placed any orders.
-> select * from customers left join orders on customers.customerId = orders.customerId;

3) Show all categories and the products in each category, including categories without any products.
-> select * from categories left join products on categories.categoryId = products.categoryid;

4) List all possible customer-product combinations, regardless of whether a purchase has occurred.
-> select * from customers cross join products;

5) Display all orders with customer and product information, including orders where either the customer or product information is missing.
-> -- 5. Display all orders with customer and product information, including orders where either the customer or product information is missing.
select * from orders left join customers on orders.customerid = customers.customerid left join orderdetails on orders.orderid = orderdetails.orderid left join products on products.productid = orderdetails.productid;

6) Show all products that have never been ordered, along with their category information.
-> select * from products left join orderdetails on products.productid = orderdetails.productid left join orders on orderdetails.orderid = orders.orderid left join categories on categories.categoryid = products.categoryid where orderdetails.orderdetailid is null;

7) List all customers who have placed orders in the last week, along with the products they've purchased.
-> select * from customers inner join orders on orders.customerid = customers.customerid left join orderdetails on orders.orderid = orderdetails.orderid left join products on orderdetails.productid = products.productid where orders.orderdate >= dateadd(day, -7, getdate());

8) Display all categories with products priced over $100, including categories without such products.
-> select * from categories left join products on products.categoryid = categories.categoryid and products.price > 100;

9) Show all orders placed before 2023 and any associated product information.
-> select * from orders left join orderdetails on orders.orderid = orderdetails.orderid left join products on products.productid = orderdetails.productid where 2023 > year(orders.orderdate);

10) List all possible category-customer combinations, regardless of whether the customer has purchased a product from that category.
-> select * from categories cross join customers;

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

ASSIGNMENT 3
------------

1) List all books along with their authors, including books without assigned authors.
-> select * from books left join authors on books.authorid = authors.authorid;

2) Display all patrons and their loan history, including patrons who have never borrowed a book.
-> select * from patrons left join loans on patrons.patronid = loans.patronid;

3) Show all authors and the books they've written, including authors who haven't written any books in our collection.
-> select * from authors left join books on authors.authorid = books.authorid;

4) List all possible book-patron combinations, regardless of whether a loan has occurred.
-> select * from books cross join patrons;

5) Display all loans with book and patron information, including loans where either the book or patron information is missing.
-> select * from loans left join books on loans.bookid = books.bookid left join patrons on patrons.patronid = loans.patronid;

6) Show all books that have never been loaned, along with their author information.
-> select * from books left join loans on loans.bookid = books.bookid left join authors on books.authorid = authors.authorid where loans.loanid is null;

7) List all patrons who have borrowed books in the last month, along with the books they've borrowed.
-> select * from patrons left join loans on loans.patronid = patrons.patronid left join books on loans.bookid = books.bookid where loans.loandate >= dateadd(month, -1, getdate());

8) Display all authors born after 1970 and their books, including those without any books in our collection.
-> select * from authors left join books on authors.authorid = books.authorid where authors.birthyear > 1970;

9) Show all books published before 2000 and any associated loan information.
-> select * from books left join loans on loans.bookid = books.bookid where books.publicationyear < 2000;

10) List all possible author-patron combinations, regardless of whether the patron has borrowed a book by that author.
-> select * from authors cross join patrons;
