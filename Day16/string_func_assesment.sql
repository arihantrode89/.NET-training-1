Select * from Employee;

Select SUBSTRING(Email,CHARINDEX('@',Email,1)+1,LEN(Email)-CHARINDEX('@',Email,1)) as Domain,Count(*) as Total from Employee 
group by SUBSTRING(Email,CHARINDEX('@',Email,1)+1,LEN(Email)-CHARINDEX('@',Email,1));