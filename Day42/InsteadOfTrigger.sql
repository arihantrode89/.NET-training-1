Alter trigger insert_insteadoftrigger
on Employee
Instead of Insert
as
Begin
	Declare @Name varchar(30)
	print 'cannot insert data in these table'
	Insert into LoginLog Select USER+' tried to insert name as '+Name,GETDATE(),'Violation' from inserted
End

Create trigger delete_insteadoftrigger
on Employee
Instead of Delete
as
Begin
	Declare @Name varchar(30)
	print 'You cannot delete any data from these table'
	Insert into LoginLog select User+' tried to delete '+Name,GETDATE(),'Violation' from deleted
end

Create trigger update_insteadoftrigger
on Employee
Instead of Update
as
Begin
	print 'You cannot update data of this table'
	Insert into LoginLog Select User+' tried to update name from '+d.Name+' to '+i.Name,GETDATE(),'Violation' from deleted as d inner join inserted as i on i.Id=d.Id
end

Insert into Employee values('Khaana');
Delete from Employee where Id=1;
Update Employee set Name='Akhil' where Name='Arihant';
Select * from Employee;