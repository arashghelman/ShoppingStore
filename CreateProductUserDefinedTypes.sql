CREATE TYPE udt_ProductInsertList AS TABLE
(
	productName nvarchar(max),
	categoryId int,
	unitPrice money,
	discount money,
	productPhoto varbinary(max)
)

go

CREATE TYPE udt_ProductUpdateList AS TABLE
(
    Id int,
	productName nvarchar(max),
	categoryId int,
	unitPrice money,
	discount money,
	productPhoto varbinary(max)
)

go

CREATE TYPE udt_ProductDeleteList AS TABLE
(
	Id int
)
