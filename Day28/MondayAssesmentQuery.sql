Create table BookDetails
(
	BookId int not null,
	BookName varchar(30),
	Author varchar(30),
	Publisher varchar(30),
	Price decimal

)

Create Proc SelectBookData
As
Begin
	Select * from BookDetails
End

Create Proc InsertBookData
@BookId int,
@BookName varchar(30),
@Author varchar(30),
@Publisher varchar(30),
@Price decimal
As
Begin
	Insert into BookDetails values(@BookId,@BookName,@Author,@Publisher,@Price)
End

Create Proc UpdateBookData
@BookId int,
@BookName varchar(30),
@Author varchar(30),
@Publisher varchar(30),
@Price decimal
As
Begin
	Update BookDetails Set BookId=@BookId,BookName=@BookName,Author=@Author,Publisher=@Publisher,Price=@Price Where BookId=@BookId
End

Create Proc DeleteBookData
@BookId int
As
Begin
	Delete from BookDetails where BookId=@BookId
End


exec SelectBookData