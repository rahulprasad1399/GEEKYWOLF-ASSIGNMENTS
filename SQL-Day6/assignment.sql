1) Extract the middle 3 characters from the string 'ABCDEFG'.
-> select substring('ABCDEFG', 3, 3);

2) From a table 'Employees' with a column 'FullName', write a query to extract the first name (assuming it's always the first word before a space).
-> select substring(name, 1, charindex(' ', name)) from employee;

3) Extract the first 5 characters from the string 'SQL Server 2022'.
-> select substring(ProductCode, 1, 3) from Employee;

4) From a 'Products' table with a 'ProductCode' column, write a query to get the first 3 characters of each product code.
-> select substring(productCode, 1, 3) from products;

5) Extract the last 4 characters from the string 'ABCDEFGHIJKL'.
-> select substring('ABCDEFGHIJKL', LEN('ABCDEFGHIJKL')-3, 4);

6) From an 'Orders' table with an 'OrderID' column (format: ORD-YYYY-NNNN), write a query to extract just the numeric portion at the end.
-> select substring(orderId, 10, 4) from Orders;

7) Write a query to find the length of the string 'SQL Server Functions'.
-> select len('SQL Server Functions');

8) From a 'Customers' table, find customers whose names are longer than 20 characters.
-> select customerName from customer where LEN(customerName) > 20;

9) Compare the results of character count and byte count for the string 'SQL Server' with a trailing space.
-> select LEN('SQL Server '); // 10
-> select DATALENGTH('SQL Server '); // 11

10) Write a query to find the byte count of an empty string and explain the result.
-> select datalength('  '); // DATALENGTH() counts everything that takes storage.

11) Find the position of 'Server' in the string 'Microsoft SQL Server'.
-> select CHARINDEX('Server', 'Microsoft SQL Server');

12) From an 'Emails' table, write a query to extract the domain name from email addresses
-> select substring(email, CHARINDEX('@', email)+1, len(email)) from customer;

13) Find the position of the first number in the string 'ABC123DEF456'.
-> select PATINDEX('%[0-9]%', 'ABC123DEF456')

14) Write a query to find all product names from a 'Products' table that contain a number.
-> select * from products where PATINDEX('%[0-9]%', productName) > 0;

15) Join the strings 'SQL', 'Server', and '2022' with spaces between them.
-> select CONCAT('SQL', ' ', 'Server', ' ', '2022');

16) From 'Employees' table with 'FirstName' and 'LastName' columns, create a 'FullName' column.
-> SELECT CONCAT(FIRSTNAME, ' ' , LASTNAME) FROM EMPLOYEE;

17) Join the array ('SQL', 'Server', '2022') with a hyphen as the separator.
-> select concat_ws('-','SQL','Server', '2022');

18) From an 'Addresses' table, combine 'Street', 'City', 'State', and 'ZIP' columns into a single address string.
-> select concat_ws(' ', street, city, state, zip) from addresses;

19) Change all occurrences of 'a' to 'e' in the string 'database management'.
-> select REPLACE('database management','a','e');

20) From a 'Products' table, write a query to replace all spaces in product names with underscores.
-> select replace(productName, ' ', '_') from products;

21) Create a string of 10 asterisks (*).
-> select REPLICATE('*', 10)

22) Write a query to pad all product codes in a 'Products' table to a length of 10 characters with leading zeros.
-> select right(concat(replicate('*', 10), productName), 10) from products;

23) Insert the string 'New ' at the beginning of 'York City'.
-> SELECT stuff('York City', 1, 0, 'New ') AS City_Name;

24) From an 'Emails' table, mask the username part of email addresses, showing only the first and last characters.
-> select left(email, 1)+replicate('*', CHARINDEX('@', email)-2)+SUBSTRING(email, CHARINDEX('@', email)-1, 1)+substring(email, CHARINDEX('@', email), len(email)) as Email from customer;

25) Convert the string 'sql server' to uppercase.
-> select UPPER('sql server');

26) Write a query to convert all customer names in a 'Customers' table to uppercase.
-> select upper(customerName) from customer;

27) Convert the string 'SQL SERVER' to lowercase.
-> select lower('SQL SERVER');

28) From a 'Products' table, write a query to convert all product descriptions to lowercase.
-> select lower(description) from products;

29) Remove trailing spaces from the string 'SQL Server    '.
-> select trim('  SQL SERVER  ');

30) Write a query to remove trailing spaces from all email addresses in an 'Employees' table.
-> select trim(email) from customer;

31) Remove leading spaces from the string '   SQL Server'.
-> select LTRIM('   SQL Server');

32) From a 'Comments' table, write a query to remove leading spaces from all comment texts.
-> select LTRIM(comment) from comments;

33) Display the current date in the format 'dd-MM-yyyy
-> select format(GETDATE(), 'dd-MM-yyyy');

34) From an 'Orders' table with an 'OrderTotal' column, display the total as a currency with 2 decimal places.
-> select FORMAT(orderTotal, 'c2') from orders;
