Begin try
	Declare @num tinyint,@msg varchar(20)
	set @num = 50/0
	print 'this is try block'
end try
begin catch
	print 'This is catch block'
	Select ERROR_MESSAGE() as message,ERROR_LINE() as Line, ERROR_NUMBER() as Number,
			ERROR_SEVERITY() as Severity ,ERROR_STATE() as State
end catch

Select * from dbo.sysmessages where error=8134;