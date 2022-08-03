Create table Project_Details
(
	project_id int primary key identity(100,1),
	project_name varchar(20),
	project_type varchar(30),
	project_manager varchar(20)
)


Select * from Employee_Table;

ALter table Employee_Table add Project_id int foreign key references Project_Details(project_id);

--cross join
Select ENAME,JOB,project_name from Employee_Table
Cross Join Project_Details;

--inner join for getting employees with assigned project 
Select ENAME,JOB,project_name from Employee_Table e
inner join Project_Details p ON e.project_id = p.project_id;

--left join for getting all employees whether they're assigned with any project or not 
Select ENAME,JOB,project_name from Employee_Table e
left join Project_Details p ON e.project_id = p.project_id;


--left join for getting employees that have not been assigned with any project
Select ENAME,JOB,project_name from Employee_Table e
left join Project_Details p ON e.project_id = p.project_id
where e.project_id is NULL;

--right join for getting details of Project whether they got assigned to employee or not
Select ENAME,JOB,project_name from Employee_Table e
right join Project_Details p on e.project_id = p.project_id;


-- right join for getting project name which is not assigned to any employee rn.
Select project_name from Employee_Table e
right join Project_Details p on e.project_id = p.project_id
where e.project_id is NULL;


--full join for getting details for Employee with assigned project ,Emp who havent been assigned with any project and
-- Unassigned Project
Select ENAME,JOB,project_name from Employee_Table e
full join Project_Details p on e.project_id = p.project_id;

--full join for getting  Emp who havent been assigned with any project and Unassigned Project
Select ENAME,JOB,project_name from Employee_Table e
full join Project_Details p on e.project_id = p.project_id
where e.project_id is NULL;