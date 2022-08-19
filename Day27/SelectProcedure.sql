Select * from Users;
Select * from User_Password;

Create proc SelectUser
AS
	begin
	Select u.First_Name,u.Last_Name,u.Email,u.Mobile,p.Password from Users u inner join User_Password p on u.Id=p.User_id; 
	end

exec SelectUser;
