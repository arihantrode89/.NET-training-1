Select * from Employees;

--used for conve
Select CONVERT(nvarchar,HireDate) from Employees;

--type,column,conversion style
Select CONVERT(nvarchar,HireDate,104) from Employees;

Select CONVERT(Date,'May  1 1992 12:00AM');

Select Cast(GETDATE() as DATE);

Select EmployeeID,FirstName+' '+LastName, FirstName +' ' + CAST(EmployeeID as nvarchar) as [name-id] from Employees;