Create Proc InsertUser
@firstname varchar(20),
@lastname varchar(20),
@Email varchar(20),
@Mobile varchar(20),
@Password varchar(20)
As
	Begin
	Declare @id int
	Insert into Users(First_Name,Last_Name,Email,Mobile) values(@firstname,@lastname,@Email,@Mobile);
	Select @id=Id from Users where Email=@Email;
	Insert into User_Password values(@Password,@id)
	end

exec InsertUser @firstname='Ayushya',@lastname='Tripathi',@Email='ayuhsya@gmail.com',@Mobile='96370100084',@Password='Ayu@123';


