--greater than or equal to input
Select CEILING(15.2)
Select CEILING(-15.2)

--lesser than or equal to input
Select Floor(15.2)
Select Floor(-15.2)

--removes negative sign
Select Abs(-15.2)

Select POWER(2,4);

Select SQUARE(2);

Select SQRT(81);

Select RAND(4)

Select FLOOR(RAND()*100);

--below query prints any 10 random values bet 1-100
Declare @counter int
set @counter=1
While(@counter<=10)
begin
	print FLOOR(RAND()*100)
	set @counter = @counter+1
end

--used for rounding off the values
Select ROUND(345.6557,2);

Select ROUND(345.6557,2,1)

--rounding off values to 1 position by truncating this to 1 postion
Select ROUND(245.5557,1,2)

-- minus specify the rounding off value before decimal
Select ROUND(850.78,-2)





