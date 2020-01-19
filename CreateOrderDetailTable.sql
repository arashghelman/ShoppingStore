CREATE TABLE OrderDetail
(
    OrderId int foreign key references OrderMaster (OrderId) ,
    ProductId int foreign key references Product (ProductId) ,
	Quantity int not null,
	primary key clustered (OrderId, ProductId)
)