Select  * from Employee;
Select * from Department;

--simple transaction
Begin transaction trans
begin try
	Insert into Employee values(8,'Apeksha',987899,'apeksha@gmail.com','TTE','1997/04/07','F','X','TT01',40000,'2019/07/07',101);
	Insert into Department values('DevOps','Bangalore');
	Insert into Employee values(9,'Ashish',987899,'ashish@gmail.com','DOE','2000/04/07','M','X','DO01',40000,'2019/07/07',101);
	
	if @@TRANCOUNT>0
		Begin commit transaction trans
		print @@TRANCOUNT
		end
end try
begin catch
	print 'Error Occured'
	print ERROR_MESSAGE()
	if @@TRANCOUNT >0
		begin rollback transaction trans
		end
end catch

--save transaction
begin try
Insert into Department values('HR','Noida');
if @@TRANCOUNT>0
	begin save transaction save_tran
	end
    Insert into Employee values(8,'Apeksha',987899,'apeksha@gmail.com','TTE','1997/04/07','F','X','TT01',40000,'2019/07/07',101);
	if @@TRANCOUNT>0
		Begin commit transaction trans
		print @@TRANCOUNT
		end
end try
begin catch
	print 'Error Occured'
	print ERROR_MESSAGE()
	if @@TRANCOUNT >0
		begin rollback transaction trans
		end
end catch