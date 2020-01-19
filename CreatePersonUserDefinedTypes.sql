CREATE TYPE udt_PersonInsertList AS TABLE
(
    firstName nvarchar(max),
	lastName nvarchar(max),
	phone nvarchar(13),
	email nvarchar(90),
	personAddress nvarchar(max),
	city nvarchar(50),
	country nvarchar(50),
	company nvarchar(max)
)
go

CREATE TYPE udt_PersonUpdateList AS TABLE
(
    Id int,
    firstName nvarchar(max),
	lastName nvarchar(max),
	phone nvarchar(13),
	email nvarchar(90),
	personAddress nvarchar(max),
	city nvarchar(50),
	country nvarchar(50),
	company nvarchar(max)
)
go

CREATE TYPE udt_PersonDeleteList AS TABLE
(
    Id int
)
