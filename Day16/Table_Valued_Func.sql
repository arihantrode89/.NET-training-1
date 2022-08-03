Create Function GetEmpTable()
returns table
As return (Select * from Employee_Table)

Select * from GetEmpTable();
Select * from Employee;

Create Function MultivaluedFunc()
returns @emp Table
(
	EmpId int ,
	Employee_Name varchar(30),
	Emp_salary float
)
As 
begin
	--for inserting into @emp table
	Insert into @emp Select Id,Name,Salary from Employee;
	--for update the above inserted data
	update @emp set Emp_salary = 56000 where Employee_Name = 'Amir';
return
end

Select * from MultivaluedFunc();
Select * from Employee;
