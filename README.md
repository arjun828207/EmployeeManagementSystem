This project can be divided in three layers i.e., Presentation Layer, Business Layer, Data Layer.
There are three modules in it which inturn has different tabs inside it.

1.	User Login Screen.

2.	Admin Dashboard – In this there are three tabs 
i.	Employee Record- Capable for doing CRUD operation for Employees.
ii.	Leave Record- For approving and rejecting the leaves for Employees.
iii.	Time Record- For Getting the summarized idea of the time logging for every employee.

3.	Employee Dashboard – In this there are two tabs
i.	Leave – In this module an employee can apply leaves which will be visible to the admin dashboard for further operations.
ii.	Attendance- In this module  an employee can log in his time for log in and log out from the work.

There is an abstract class that is implemented by two classes i.e. Non-teaching staffs and Teaching Staffs.
The classes that are implementing the abstract class has some functions which are specific to that so some functions are made as abstract so that the classes’ respective operations can override the methods as per the requirement.

The UI Layer is taking the data from the UI , some business layer processing is done on that data in the class methods and finally the database persisting/Query operations are done via the business layer which is contacting with a DataBaseManager which handles the operations. These all segregations are done to modularize the program and have proper separation.
