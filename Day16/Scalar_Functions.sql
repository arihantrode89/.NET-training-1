Create function CalcAge(@dob Date)
returns INT
begin
	Declare @age int
	set @age = YEAR(GETDATE()) - YEAR(@dob)
	return @age
end


Create function CalcAgeWithCondition(@dob DAte)
returns INT
begin
	Declare @age int
	set @age =( YEAR(GETDATE()) - YEAR(@dob) )- Case when (MONTH(GETDATE())<=MONTH(@dob) and DAY(@dob) >= DAY(GETDATE()) )
	then 1
	else 0
	end
	return @age
end


Select dbo.CalcAge(CAST('2001/07/20' as DATE));


Select dbo.CalcAgeWithCondition(CAST('2001/09/20' as DATE));

Select Name,Role,dbo.CalcAgeWithCondition(Dob) as Age from Employee;

Select Name,Role,dbo.CalcAgeWithCondition(Dob) as Age from Employee where dbo.CalcAgeWithCondition(Dob)>21;


Create Function AreaofCircle
(
	@radius float
)
returns float
begin return (Select Pi()*SQUARE(@radius))
end;

--using aboove created function
Select dbo.AreaofCircle(20);