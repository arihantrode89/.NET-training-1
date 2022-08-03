Select * from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='Employee';
Select * from sys.tables;

Create view Employee_view
As
Select Name,Role,Salary from Employee

Select * from Employee_view;

Update Employee_view set Role = 'Trainee Software Engineer' where Name = 'Ayushya';

Select * from Employee_view;
Select * from Employee;

Alter view Employee_view 
As
Select Name,Role,Salary,Email from Employee

Insert into Employee_view(Name,Role,Salary,Email) values('Vishal','TSE','30000','vishal@gl.com')
Insert into Employee_view(Name,Role,Salary,Email) values('Ashish','TSE','20000','ashish@gl.com')
Insert into Employee_view(Name,Role,Salary,Email) values('Rashmii','TSE','70000','rashmi@gl.com')




