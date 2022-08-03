Select * from Employee;
Select * from Department;

--getting dept having more than one employee
Select * from Department where dept_no in (Select dept_no from Employee group by dept_no having count(*)>=1);

--getting max salary
Select Max(Salary) from Employee;

--getting 2nd max salary
Select Max(Salary) from Employee where Salary<(Select MAX(Salary) from Employee);

--getting 3rd max salary ..if we used min instead of max then we will get minimum salary
Select Max(Salary) from Employee where Salary<(Select MAX(Salary) from Employee where Salary<(Select MAX(Salary) from Employee));

Select dept_name from Department where dept_no in (Select dept_no from Employee group by dept_no having count('ISO')=1);

Select *
Select TOP 3 Min(Salary) as Salary from Employee order by Salary Desc;
select min(Salary) from (select distinct Salary from Employee order by Salary desc) where rownum>3;