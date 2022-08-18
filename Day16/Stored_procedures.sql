Select * from Employee;


--without paramter
Create Procedure Sp_Get_Employees
As
begin 
	Select Name,Email,Salary from Employee;
End
-------------------------------------------
--ways of using Stored PRocedure
Sp_Get_Employees

exec Sp_Get_Employees
-------------------------------------------

Create Procedure GetEmpByGenderAndDept
@Gender char,
@DeptId int
As
begin
	Select Name,Gender,dept_no from Employee where Gender = @Gender and dept_no=@DeptId
end

GetEmpByGenderAndDept @Gender='M',@DeptId=100

sp_helptext GetEmpByGenderAndDept;

Create Procedure GetEmpCountByGender
@Gender char,
@EmpCount int output
as
begin
	Select @EmpCount = Count(*)  from Employee where Gender = @Gender;
end

Declare @emptotal int
Exec GetEmpCountByGender 'M' ,@emptotal output
print @emptotal


Create Proc GetName
@Gender char
as
begin
	Select Name from Employee where Gender = @Gender;
end

GetName 'M';