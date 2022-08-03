exec sp_helpindex Employee;


--we cannot create more than one clustered index
Create clustered index IX_Employee_Gender_Salary
on Employee (Gender DESC,Salary ASC);

Drop index IX_Employee_Gender_Salary on Employee;
Select * from Employee where Salary in (30000,26000,40000);

Create NonClustered index IX_nonclustered1 on Employee(Name);

Create unique NonClustered index IX_nonclustered_unique on Employee(Name);

Select * from Employee 

