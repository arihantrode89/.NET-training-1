-- print columns of emp where dept are from department table
Select * from Employee where dept_no in (Select dept_no from Department);

-- print columns from employee table where dept are from department table and then order the results by Gender in Ascending order(default)
Select * from Employee where dept_no in (Select dept_no from Department) order by Gender;

--print columns from employee table where dept are only Testing from department table
Select * from Employee where dept_no in (Select dept_no from Department where dept_name='Testing');

-- print columns from employee table where dept are from department table and then order the results by Gender in Descending order. 
Select * from Employee where dept_no in (Select dept_no from Department) order by Gender desc;

--print columns from employee table where dept are from department table which belogs to only testing and info-security
Select * from Employee where dept_no in (Select dept_no from Department where dept_name in ('Testing','Info-Security'));

--print columns from dept table where dept only include employee having role as Trainee SE
Select * from Department where dept_no in (Select dept_no from Employee where Role = 'Trainee SE');

-- print columns from department table where it include employee having band X
Select * from Department where dept_no in (Select dept_no from Employee where Band = 'X');

Select * from Employee where dept_no in (Select dept_no from Department where location like 'N%');