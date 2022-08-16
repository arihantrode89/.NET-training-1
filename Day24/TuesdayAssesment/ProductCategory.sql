
Create Table Category
(
	CategoryId int primary key,
	CategoryName varchar(30)
);

Create table Product
(
	ProductId int primary key,
	ProductName varchar(30),
	Price float,
	CategoryId int
);

ALTER TABLE Product
ADD FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId);

Select * from Product
Select * from Category
