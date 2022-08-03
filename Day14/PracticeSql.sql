Insert into Employee(Id,Name,Phone,Email,Role,Dob) values(2,'Ayushya',99999990,'ayushya@gl.com','Trainee SE','2000-08-21'),(3,'Amit',99999990,'amit@gl.com','Trainee SE','2000-04-22')

Alter table Employee Add Gender char;

exec sp_renamedb 'demo','Training';

Update  Employee set Gender='F' where Name='Ayushya';

ALter table Employee Add Band char,Grade varchar(5);

Update Employee set Band='X',Grade = 'TE00';

sp_rename 'Employee.Grade1','Grade'; 

ALter table Employee Add Salary double precision;

Create table abc(id int identity(1,1),name varchar(10));

Create table Department
(
	dept_no int identity(100,1),
	dept_name varchar(20),
	location varchar(20)
);

ALter table Employee Add DOJ Date;

Update Employee set DOJ='2022-07-07';

Alter table Employee add  Dot datetime;

Alter table Employee drop column Dot;

Drop table abc;

Insert into Department values('Info-Security','Bangalore'),('Immigration','Chennia');

Alter table Employee Add dept_no int;

Alter table Department Add Constraint dept_id_pk Primary Key(dept_no);

Alter table Employee Add Constraint emp_dept_fk Foreign Key(dept_no) references Department(dept_no);

Select * from Employee Where dept_no = (Select dept_no from department where dept_name='Info-Security' );

Select * from Employee where salary = (select MAX(Salary) from Employee);

Select * from Employee where salary between 20000 and 40000;


