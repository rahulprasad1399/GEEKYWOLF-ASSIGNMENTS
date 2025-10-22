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

35) Separate the string 'apple,banana,cherry' into individual fruits.
-> select value from string_split('apple,banana,cherry', ',');

36) From a 'Skills' table with a 'SkillList' column containing comma-separated skills, write a query to create a row for each individual skill.
-> 

37) Write a query to display the current date and time.
-> select getdate();

38) From an 'Orders' table, find all orders placed in the last 24 hours.
-> select * from orders where orderplaced >= DATEADD(hour, -24, getdate());

39) Display the current UTC date and time.
-> select GETUTCDATE();

40) Write a query to show the time difference between local time and UTC time.
-> select DATEDIFF(minute, GETUTCDATE(), getdate()) as MinuteDifference;

41) Convert the current date and time to 'Pacific Standard Time'.
-> select GETUTCDATE() at time zone 'Pacific Standard Time' as PacificTime;

42) From a 'Flights' table with a 'DepartureTime' column in UTC, convert all departure times to 'Eastern Standard Time'.
-> select departuretime at time zone 'Eastern Standard Time' as EasternTime from flights;

43) Add 3 months to the current date.
-> select dateadd(month, 3, getdate());

44) From an 'Employees' table, write a query to calculate each employee's retirement date (65 years from their 'DateOfBirth')
-> select dateadd(Year, 65, dateofbirth) from employee;

45) Calculate the number of days between '2023-01-01' and '2023-12-31'.
-> select datediff(DAY, '2023-01-01', '2023-12-31');

46) From an 'Orders' table, find the average number of days between order date and ship date.
-> select avg(DATEDIFF(DAY, orderdate,shipdate)) as NumAvgDays from orders;

47) Extract the month number from the date '2023-09-15'.
-> select MONTH('2023-09-15');

48) From a 'Sales' table, write a query to group total sales by the quarter of the sale date.
-> 

49) Extract the year from the current date.
-> select year(GETDATE());

50) From an 'Employees' table, find all employees hired in the year 2022.
-> select * from employee where year(hiredate)=2022

51) Check if '2023-02-30' is a valid date.
-> select isdate('2023-02-30'); // No

52) Write a query to find all rows in a 'UserInputs' table where the 'EnteredDate' column contains invalid dates.
-> select * from userInputs where isDate(enteredDate)=0;

53) Find the last day of the current month.
-> select EOMONTH(getDate());

54) From a 'Subscriptions' table, write a query to extend all subscription end dates to the end of their respective months.
-> update subscriptions set subscriptionEndDate=EOMONTH(subscriptionEndDate);

55) Display the current date and time.
-> select GETDATE();

56) Compare the results of two different methods to get the current timestamp - are they always the same?
-> select getdate(), getutcdate(), SYSDATETIME(); // No they are different 

57) Get the current date and time with higher precision than standard methods.
-> select SYSDATETIME();

58) Write a query to insert the current high-precision timestamp into a 'Logs' table.
-> create table Logs (LogId INT PRIMARY KEY IDENTITY(1, 1), description varchar(100), LogTime datetime2)
-> insert into Logs (eventDescription, logtime) values ('Test', sysdatetime());

59) Display the current UTC date and time with high precision.
-> select SYSUTCDATETIME();

60) Calculate the difference in microseconds between the current local time and UTC time.
-> select DATEDIFF(MILLISECOND,getdate(), getutcdate());

61) Get the current date, time, and time zone offset.
-> select sysdatetimeoffset();

62) From a 'GlobalEvents' table, convert all event times to include time zone offset information.
-> create table GlobalEvents (EventTime datetimeoffset);
-> insert into GlobalEvents (EventTime) values (sysdatetimeoffset());

63) Extract the month number from the date '2023-12-25'.
-> select month('2023-12-25');

64) From a 'Sales' table, find the total sales for each month of the previous year.
-> select year(saledate) as SaleYear, month(saledate) as SaleMonth, sum(saleamount) as SaleAmount from sales where year(saledate) = year(getdate())-1 group by year(saledate), month(saledate);

65) Extract the day of the month from '2023-03-15'.
-> select DATENAME(WEEKDAY,'2023-03-15');

66) Write a query to find all orders from an 'Orders' table that were placed on the 15th day of any month.
-> SELECT * FROM ORDERS WHERE DAY(ORDERDATE)=15;

67) Get the name of the month for the date '2023-09-01'.
-> SELECT DATENAME(month, '2023-09-01');

68) From an 'Events' table, write a query to display the day of the week (in words) for each event date.
-> select datename(weekday, eventdate) from events;

69) Create a date for Christmas Day 2023.
-> select datefromparts(2023,12,15);

70) Write a query to convert separate year, month, and day columns from a 'Dates' table into a single DATE column.
-> select DATEFROMPARTS(year, month, day) from dates;



1) Find the total number of customers in each country.
-> select country, count(*) as TotalNumberOfCustomers from customers group by country;

2) Calculate the average unit price of products in each category.
-> select category, AVG(unitprice) from products group by category;

3) Find the maximum and minimum salary in each department.
-> select department, min(salary) as MinSalary, max(salary) as MaxSalary from Employees group by department;

4) Count the total number of products supplied by each supplier.
-> select supplier, count(*) as NumOfProducts from products group by supplier;

5) Calculate the total value of inventory (UnitsInStock × UnitPrice) for each product category.
-> select category, sum(UnitPrice*UnitsInStock) as TotalInventoryValue from products group by category;

6) Find all product categories that have more than 2 products.
-> select category, count(*) as NumOfProducts from products group by category having count(*)>2;

7) List departments where the average salary is greater than $60,000.
-> select avg(salary) as AvgSalary from employees group by department having avg(salary)>60000;

8) Show product categories where the average unit price is between $100 and $500.
-> select category, avg(unitprice) from products group by category having avg(unitprice)>100 and avg(unitprice)<500;

9) Find suppliers who supply products worth more than $10,000 in total inventory value.
-> select supplier, sum(unitprice*UnitsInStock) as InventoryValue from products group by supplier having sum(unitprice*UnitsInStock) > 10000;

10) List countries that have more than 1 customer and show the customer count.
-> select country, count(*) as customerCount from customers group by country having count(*)>1;