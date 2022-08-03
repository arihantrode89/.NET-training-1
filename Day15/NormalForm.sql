Create Table Student1NF
(
	Id int,
	Name varchar(20),
	Email varchar(30),
	Location varchar(20)
);

Insert into Student1NF values
(1,'Arihant','arihantrode@gmail.com','Nagpur'),
(2,'Ayushya','ayushya@gmail.com','Lucknow'),
(3,'Amit','amit@gmail.com','Agra'),
(4,'Anmol','anmol@gmail.com','Shegaon');

Alter table Student1NF ADD Unique(Id,Email);

Insert into Student1NF values(1,'Ari','arihantrode@gmail.com','Noida')

Alter table Student1NF add PostalCode int;

Select * from Student1NF;

Create Table Student
(
	Id int primary key,
	Name varchar(20),
	Email varchar(30),
	PostalCode int,
	Unique(Id,Email)

)
Create table Location 
(
	PostalCode int primary key,
	Location varchar(30)
)

Insert into Student(Id,Name,Email,PostalCode) Select Id,Name,Email,PostalCode from Student1NF ;

Select * from Student1NF;
Select * from Student;
Select  * from Location;
