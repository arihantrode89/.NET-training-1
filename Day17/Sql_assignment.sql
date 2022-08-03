Create table EmployeeDetails
(
	EmpId int primary key,
	FullName varchar(20),
	ManagerId int,
	DateofJoining Date,
	City varchar(20)
);

Create table EmployeeSalary
(
	EmpId int,
	Project varchar(10),
	Salary Float,
	Variable float
);

Insert into EmployeeDetails values
(121,'Lakshmi Kumar',321,'2001/01/31','Hyderabad'),
(321,'Damodaran',986,'2002/01/30','Chennai'),
(421,'Priyadarshini',876,'2003/11/27','Bangalore'),
(521,'Mahesh',768,'2004/09/08','Mumbai'),
(621,'Mrinalini',456,'2005/10/09','Thiruvanthapuram'),
(721,'Yuvraj',654,'2006/08/06','Bhopal'),
(821,'Shruti',546,'2007/05/05','Chandigarh'),
(921,'Nandini',256,'2008/06/09','Shimla'),
(221,'Santhya',345,'2009/11/07','Shillong'),
(122,'Priyavarshini',324,'2010/12/08','Amaravathi');

Insert into EmployeeSalary values
(121,'P1',15000,500),
(321,'P2',10000,1000),
(421,'P1',12000,0),
(521,'P2',9000,600),
(621,Null,11000,0),
(721,'P1',9000,850),
(821,'P2',14000,478),
(921,'P1',13000,0),
(221,'P2',9000,586),
(122,Null,7000,750);

--nth highest
Select MAX(Salary) from EmployeeSalary;
Create Procedure NhighestSal
@n int
as
begin
	Select TOP 1 Salary from (Select distinct TOP (@n) Salary from EmployeeSalary order by salary desc) as abc order by Salary;
end

exec NhighestSal @n=1;

--Write an SQL query to fetch the different projects available from the EmployeeSalary table.
Select Project from EmployeeSalary where Project is not NULL group by Project;

--Write an SQL query to find the employee id whose salary lies in the range of 9000 and 15000
Select EmpId,Salary from EmployeeSalary where Salary between 9000 and 15000;

--Write an SQL query to fetch the count of employees working in project ‘P1’.
Select Count('EmpID') as EmpCount from EmployeeSalary where Project='P1';

--Write an SQL query to find the maximum, minimum, and average salary of the employees.
Select MAX(Salary) as maxx ,MIN(Salary) as minn ,AVG(Salary)avgg from EmployeeSalary;

--Write an SQL query to fetch all the employees who either live in Hyderabad or work under a manager with ManagerId – 321.
Select * from EmployeeDetails where City='Hyderabad' or ManagerId=321;

--Write an SQL query to display both the EmpId and ManagerId together.
Select CAST(EmpId as varchar) + '--' + CAST(ManagerId as varchar) as EmpMgr from EmployeeDetails;


--Fetch all the employees who are not working on any project
Select EmpId from EmployeeSalary where Project is NULL;

--Write an SQL query to fetch all employee records from EmployeeDetails table who have a salary record in EmployeeSalary table.
Select * from EmployeeDetails where EmpId in (Select EmpId from EmployeeSalary where Salary is not NULL);

Select e.EmpID,e.FullName,s.Salary from EmployeeDetails as e
Inner join EmployeeSalary as s ON e.EmpId=s.EmpId where s.Salary is not NULL;

--Write an SQL query to fetch all the Employees who are also managers from the EmployeeDetails table.
Select e.EmpId,e.FullName from EmployeeDetails e,EmployeeDetails e1 where e.EmpId=e1.ManagerId;
