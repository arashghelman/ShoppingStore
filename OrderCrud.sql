alter PROCEDURE usp_InsertOrder
@insertOrderMasterList udt_InsertOrderMasterList READONLY,
@insertOrderDetailList udt_InsertOrderDetailList READONLY
AS
BEGIN TRAN
	BEGIN TRY
	IF( (select salespersonId from @insertOrderMasterList) != (select customerId from @insertOrderMasterList) )
	BEGIN
	    declare @orderCode int
		set @orderCode = (select MAX(OrderCode) from dbo.OrderMaster)
		set @orderCode = ISNULL(@orderCode,1000)+1
		insert into dbo.OrderMaster(OrderCode,SalespersonId,CustomerId)
		select @orderCode,salespersonId,customerId from @insertOrderMasterList
		declare @orderMasterId int
		set @orderMasterId = SCOPE_IDENTITY()
		declare @orderIdCount int
		set @orderIdCount = (select COUNT(OrderId) from dbo.OrderMaster)
		declare @index int
		set @index = 0

		WHILE( @index <= @orderIdCount )
		BEGIN
		insert into dbo.OrderDetail(OrderId,ProductId,Quantity)
        select @orderMasterId,productId,quantity from @insertOrderDetailList
		order by productId offset @index rows fetch next 1 rows only
		set @index = @index + 1
		END

	END 
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

go

CREATE PROCEDURE usp_UpdateOrder 
@updateOrderMasterList udt_UpdateOrderMasterList READONLY,
@updateOrderDetailList udt_UpdateOrderDetailList READONLY
AS
BEGIN TRAN
	BEGIN TRY
	IF( (select salespersonId from @updateOrderMasterList) != (select customerId from @updateOrderMasterList) )
	BEGIN
		update dbo.OrderMaster
		set SalespersonId = ml.salespersonId,
		CustomerId = ml.customerId
		from @updateOrderMasterList ml
		where (select OrderId from dbo.OrderMaster) = ml.orderId
		update dbo.OrderDetail
		set ProductId = dl.productId,
		Quantity = dl.quantity
		from @updateOrderDetailList dl
		where (select OrderId from dbo.OrderDetail) = dl.orderId
	END
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

go

CREATE PROCEDURE usp_DeleteOrder
@orderMasterDeleteList udt_DeleteOrderMasterList READONLY,
@orderDetailDeleteList udt_DeleteOrderDetailList READONLY
AS
BEGIN TRAN
	BEGIN TRY
		delete from dbo.OrderDetail
		where OrderId = (select dl.OrderId from @orderDetailDeleteList dl)
		delete from dbo.OrderMaster
		where OrderId = (select ml.orderId from @orderMasterDeleteList ml)
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

go

CREATE PROCEDURE usp_DeleteOrderProducts
@deleteOrderProductList udt_DeleteOrderProductList READONLY
AS
BEGIN TRAN
	BEGIN TRY
		delete from dbo.OrderDetail
		where ProductId = (select productId from @deleteOrderProductList)
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH


go

CREATE PROCEDURE usp_SelectOrderMaster
AS
BEGIN TRAN
	BEGIN TRY
		select o.OrderId
		,o.OrderCode, 
		o.OrderDate, 
		p1.FirstName+' '+p1.LastName as [SalespersonName],
		p1.Company as [SalespersonCompany], 
		p1.PersonAddress+','+p1.City+','+p1.Country as [SalespersonAddress],
		p2.FirstName+' '+p2.LastName as [CustomerName],
		p2.Company as [CustomerCompany],
		p2.PersonAddress+','+p2.City+','+p2.Country as [CustomerAddress],
		COUNT(od.ProductId) as [NumberOfOrderedProducts],
		SUM((p3.UnitPrice-p3.Discount)*od.Quantity)* COUNT(od.ProductId) as [TotalPrice]
		from 
		OrderMaster o inner join dbo.Person p1
		on o.SalespersonId = p1.PersonId 
		inner join dbo.Person p2 
		on o.CustomerId = p2.PersonId
		inner join dbo.OrderDetail od 
		on o.OrderId = od.OrderId
		inner join dbo.Product p3 
		on od.ProductId = p3.ProductId
		group by o.OrderId,
		o.OrderCode, 
		o.OrderDate, 
		p1.FirstName+' '+p1.LastName,
		p1.Company, 
		p1.PersonAddress+','+p1.City+','+p1.Country,
		p2.FirstName+' '+p2.LastName,
		p2.Company,
		p2.PersonAddress+','+p2.City+','+p2.Country 
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

go

CREATE PROCEDURE usp_SelectOrderDetail
AS
BEGIN TRAN
	BEGIN TRY
		select p.ProductCode, 
		p.ProductName, 
		p.UnitPrice, 
		od.Quantity, 
		p.Discount,
		SUM(p.UnitPrice-p.Discount) * od.Quantity as [Price]
		from dbo.OrderDetail od inner join dbo.Product p
		on od.ProductId = p.ProductId
		group by p.ProductCode, p.ProductName, p.UnitPrice, od.Quantity, p.Discount
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

