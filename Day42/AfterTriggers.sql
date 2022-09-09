Alter Trigger logn_forinsert
on Employee
For Insert
As
Begin
	--Declare @Count int
	--Declare @num int
	--Declare @Name varchar(30)
	
	--Select @Name=Name from inserted
	--Select @Count=Count(*) from inserted
	--Select  @num = min(Id) from inserted
	--Select * from inserted
	--While @Count>=1
	--Begin
		
	--	Select @Name = Name from Inserted where Id=@num
	--	set @num = @num+1
	--	set @Count = @Count-1
	--	Insert into LoginLog values('New Employee is added having name as '+@Name,GETDATE())
	--End
	insert into LoginLog
		select 'New user is added with name ' + name  ,GETDATE(),'INSERT' from inserted
	
End


Create Trigger login_delete
on Employee
For Delete
As
Begin
	Declare @Old varchar(30)
	Declare @New varchar(30)

	Insert into LoginLog Select 'User having '+Name+' is deleted from table',GETDATE(),'DELETE' from deleted
end

--Delete login_updatetrigger

Alter trigger login_update
on Employee
After update
As
Begin
	Select * from Inserted
	Select * from deleted

	Insert into LoginLog Select 'Employee Name changed from '+d.Name+' to '+i.Name,GETDATE(),'Update' from deleted as d inner join inserted as i on d.Id=i.Id
end


update Employee Set Name='Arihant' where Id in (14)
Delete from LoginLog
Delete from Employee where Id in (8,9);
Insert into Employee values('Akshara'),('Anunay'),('Brinda');
--Select * from Employee