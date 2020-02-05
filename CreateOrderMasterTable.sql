CREATE TABLE OrderMaster
(
    OrderId int primary key identity(1,1),
	SalespersonId int foreign key references Person (PersonId) not null,
	CustomerId int foreign key references Person (PersonId) not null,
    OrderCode int,
	OrderDate as getdate(),
	unique (SalespersonId, CustomerId)
)

