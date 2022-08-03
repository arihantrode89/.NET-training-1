Create table Person
(
	Id int identity(1,1) primary key,
	Name varchar(20),
	Mobile int,
	Age tinyint,
)

Insert into Person values
('Arihant Rode',96370100,21),
('Apeksha Rode',989898,25),
('Ayushya Tripathi',9899898,21),
('Amit Gupta',989898,22),
('Vishal Rathore',98987698,21),
('Pratik Thakre',9894898,25),
('Pragati Thakare',98988298,22),
('Sanket Sapate',989898,21),
('Rutuja Shende',989898,25),
('Suramya Deshpande',9898398,22),
('Aman Deshkar',9849898,26),
('Nitesh Shahi',9869898,22);


Alter table Person add Country varchar(20);

Select * from Person;

--for finding diffrent Age groups
Select Age from Person group by Age;

--getting count of person in diffrent age group
Select Age,Count(*) from Person Group by Age;

--getting count of person in distinct countries
Select Country,Count(*) from Person Group By Country;

--getting count of person in diffrent age group in Descending order of Age
Select Age,Count(*) as 'count' from Person Group by Age Order by Age DESC;

--getting count of person in distinct countries in ascending order of their count
Select Country,Count(*) as 'count' from Person Group By Country order by 'count';

--getting ages diffrent ages in respective countries
Select Age,Country from Person Group by Country,Age;

--Getting avg age per country
Select AVG(Age),Country from Person Group by Country;

--Getting Name,Agr of Person whose Age is greater than or equals to avg age of person in diffrent countries
Select Name,Age from Person where Age >= (Select AVG(AGE) from Person);

--Getting Country having Average greater than 22.
Select Country from Person group by Country having AVG(AGE)>22;

--getting Name,Age of Person living in country where average age is greater than 22
Select Name,Age,Country from Person where Country in (Select Country from Person group by Country having AVG(AGE)>22);