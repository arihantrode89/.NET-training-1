--CREATE TABLE [dbo].[Employee_Table](
--[EMPNO] [int] NOT NULL,
--[ENAME] [varchar](50) NULL,
--[JOB] [varchar](50) NULL,
--[MGR] [int] NULL,
--[HIREDATE] [datetime] NULL,
--[SAL] [int] NULL,
--[COMM] [int] NULL,
--[DEPTNO] [int] NULL
--);

--Select * from Employee_Table;

--Insert into Employee_Table values 
--(7070,'Arihant','TSE',1001,'2022-07-07',30000,96370100,100),
--(7071,'Amit','TSE',1001,'2022-07-07',30000,9637010,100),
--(7071,'Ayushya','TSE',1001,'2022-07-07',30000,9876543,100),
--(8029,'Amir','ISO',1008,'2015-07-07',30000,9637011,102),
--(9071,'panwesa','CTO',1007,'2021-07-07',30000,9636010,101),
--(9871,'Priya','IMo',1006,'2012-07-07',30000,9876573,103);

Select * from Employee_Table where DEPTNO in(100,101);

Select * from Employee_Table where ENAME like 'A%';

Select * from Employee_Table where ENAME like '_A%';

Select * from Employee_Table where SAL between 10000 and 40000;

Select * from Employee_Table where ENAME not like 'A%';

Select * from Employee_Table where ENAME <> 'Arihant';

Select * from Employee_Table where ENAME like 'A%' and SAL >= (Select AVG(SAL) from Employee_Table);

Select * from Employee_Table where ENAME like 'A%' and Job <> 'TSE';

Select DEPTNO,MAX(SAL) from Employee_Table Group by DEPTNO;

Select EName,DEPTNO,SAL from Employee_Table 
Cross join Department ;

Select EName,DEPTNO,dept_name,SAL from Employee_Table as e
inner join Department as d  ON e.DEPTNO = d.dept_no;


