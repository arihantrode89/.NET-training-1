Create function GetCustomer()
returns table
as
return (Select CompanyName,City,PostalCode from Customers)

select * from GetCustomer();

Create function InsertandUpdateCustomer()
returns @cust table
(
	cst_name varchar(40),
	cst_city varchar(20),
	cst_PostalCode nvarchar(10)
)
as
begin
	Insert into @cust Select CompanyName,City,PostalCode from Customers;

	Update @cust Set cst_city='Nagpur',cst_PostalCode='440008'  where cst_PostalCode='12209';

	return
end

Select * from Customers;
select * from InsertandUpdateCustomer();