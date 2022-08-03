Select LTRIM('  Arihant');

Select RTRIM('  Arihant');

Select LOWER('ARIHANT RODE');

Select UPPER('arihant rode');

Select REVERSE('Arihant Rode');

--it also calculate spaces between words but it donot calculate spaces after lst word
Select LEN('Arihant Rode   ');

--give string of length 3 from left side
Select LEFT('Arihant',3);

--give string of length 3 from right side
Select Right('Arihant',3);


--find exp,source,location
Select CHARINDEX('@','Arihant@gmail.com',1);

--source str,
Select SUBSTRING('Arihant@gmail.com',2,7);

Select SUBSTRING
(
	'Arihantrode@gmail.com',
	Select CHARINDEX('@','Arihantrode@gmail.com',1),
	LEN('Arihantrode@gmail.com') - CHARINDEX('@','Arihantrode@gmail.com',1)
)


--source,old,new
Select REPLACE('arihantrode@gmail.com','@','89@')

Select ASCII('A');

--first if deletes character from 2 to 7 then it will add HTML at postion 2
Select STUFF('arihantrode89@gmail.com',1,7,'Arihant')

--concat the string by using separator '@'-->separator,str1,str2
Select CONCAT_WS('@','arihantrode89','globallogic.com');

Select SOUNDEX('arihantrode89gmail.com');