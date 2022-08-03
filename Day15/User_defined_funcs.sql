--------User Defined Function----------------

Create function GetEmpNameRole
(
	@name varchar(20),
	@role varchar(20)
)
returns varchar(40)
As
Begin return(Select @name +''+@role)
end;

Select dbo.GetEmpNameRole(Name,Role) as Name,Salary from Employee;

