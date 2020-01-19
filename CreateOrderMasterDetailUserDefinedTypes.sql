CREATE TYPE udt_InsertOrderMasterList AS TABLE
(
    salespersonId int,
	customerId int
)

go

CREATE TYPE udt_InsertOrderDetailList AS TABLE
(
    productId int,
	quantity int
)

go

CREATE TYPE udt_UpdateOrderMasterList AS TABLE
(
    orderId int,
	salespersonId int,
	customerId int
)

go

CREATE TYPE udt_UpdateOrderDetailList AS TABLE
(
    orderId int,
    productId int,
	quantity int
)

go

CREATE TYPE udt_DeleteOrderMasterList AS TABLE
(
    orderId int
)

go

CREATE TYPE udt_DeleteOrderDetailList AS TABLE
(
    OrderId int
)

go

CREATE TYPE udt_DeleteOrderProductList AS TABLE
(
    productId int
)


