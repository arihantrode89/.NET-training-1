Create table Products
(
	product_id int identity(1000,1),
	product_name varchar(30),
	product_desc varchar(50),
	Mrp double precision,
	Origin varchar(20)
)

Create table Customers
(
	customer_id int identity(10,1),
	customer_name varchar(30),
	customer_type varchar(10),
	location varchar(20)
)

Insert into Customers values('Ashama','Seller','Nagpur'),
('Aswath','Distri','Chennia'),
('Ambika','Buyer','Noida'),
('Anwesa','Seller','Bangalore')

Insert into Products values('Chawanprash','Immunity Booster',200,'Jaipur'),
('Bath Soap','Neem Flavor',20,'Jaisalmer'),
('Toothpaste','Dantkanti',100,'Merath'),
('ToothBrush','Brushing Purpose',20,'Noida');