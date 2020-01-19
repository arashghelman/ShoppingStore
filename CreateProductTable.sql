CREATE TABLE Product 
(
    ProductId int primary key identity(1,1),
    ProductCode int,
    Category_Ref int foreign key references Category(CategoryId) not null,
	ProductName nvarchar(max) not null,
	UnitPrice money not null,
	Discount money,
	ProductPhoto varbinary(max)
)