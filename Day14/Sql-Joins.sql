Create table tblDepartment(
ID int primary key,
DepartmentName nvarchar(50),
Location nvarchar(50),
Department_Head varchar(50)
)

Insert into tblDepartment values (1, 'IT', 'London', 'Ram')
Insert into tblDepartment values (2, 'Finance', 'US', 'Pam') 
Insert into tblDepartment values (3, 'HR', 'New York', 'Christie')
Insert into tblDepartment values (4, 'Other Department', 'Sydney', 'Nivea')

Create table tblEmployee(
ID int primary key,
Name nvarchar(50),
Gender nvarchar(50),
Salary int,
DepartmentId int foreign key references tblDepartment (Id)
)

Insert into tblEmployee values (1, 'Terry', 'Male', 4000, 1)
Insert into tblEmployee values (2, 'Pam', 'Female', 3000, 3)
Insert into tblEmployee values (3, 'Johnny', 'Male', 3500, 1)
Insert into tblEmployee values (4, 'Sammy', 'Male', 4500, 2)
Insert into tblEmployee values (5, 'Toddy', 'Male', 2800, 2) 
Insert into tblEmployee values (6, 'Beny', 'Male', 7000, 1)
Insert into tblEmployee values (7, 'Sara', 'Female', 4800, 3)
Insert into tblEmployee values (8, 'Vikas', 'Female', 5500, 1)
Insert into tblEmployee values (9, 'Jakie', 'Male', 6500, NULL) 
Insert into tblEmployee values (10, 'Rohan', 'Male', 8800, NULL)


--Cross join

Select Name,Gender,Salary from tblEmployee 
cross join tblDepartment;

--Inner Join

Select Name,Gender,DepartmentName from tblEmployee e
Inner join tblDepartment d On e.DepartmentId = d.ID;

--Outer left

Select Name,Gender,DepartmentName from tblEmployee e
left join tblDepartment d ON e.DepartmentId = d.ID;

--outer right

Select Name,Gender,DepartmentName from tblEmployee e
right join tblDepartment d ON e.DepartmentId = d.ID;

--full join with condition
Select Name,Gender,DepartmentName from tblEmployee e
left join tblDepartment d ON e.DepartmentId = d.ID;

--left join with condition
Select Name,Gender,DepartmentName from tblEmployee e
left join tblDepartment d ON e.DepartmentId = d.ID where d.ID is NULL;

--right join with condition
Select Name,Gender,DepartmentName from tblEmployee e
right join tblDepartment d ON e.DepartmentId = d.ID where e.Name is NULL;