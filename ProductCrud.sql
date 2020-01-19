CREATE PROCEDURE usp_InsertProduct
@productInsertList udt_ProductInsertList READONLY
AS
BEGIN TRAN
		BEGIN TRY
			declare @productCode int
			set @productCode = (select MAX(ProductCode) from dbo.Product)
			set @productCode = ISNULL(@productCode,1000)+1
			insert into dbo.Product(ProductCode,Category_Ref,ProductName,UnitPrice,Discount,ProductPhoto)
			select @productCode,categoryId,productName,unitPrice,discount,productPhoto from @productInsertList
		COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH

go


CREATE PROCEDURE usp_UpdateProduct
@productUpdateList udt_ProductUpdateList READONLY
AS
BEGIN TRAN
	BEGIN TRY
		update dbo.Product 
		set Category_Ref = pl.categoryId, 
		ProductName = pl.productName, 
		UnitPrice = pl.unitPrice, 
		Discount = pl.discount,
		ProductPhoto = pl.productPhoto
		from @productUpdateList pl
		where ProductId = pl.Id
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

go

CREATE PROCEDURE usp_SelectProduct
AS
BEGIN TRAN
	BEGIN TRY
		select p.ProductId,
		p.ProductCode, 
		p.ProductName, 
		c.CategoryName, 
		p.UnitPrice, 
		p.Discount, 
		p.UnitPrice - p.Discount as [Product Price], 
		p.ProductPhoto
		from dbo.Product p inner join dbo.Category c 
		on p.Category_Ref = c.CategoryId
		group by p.ProductId,p.ProductCode, p.ProductName, c.CategoryName, p.UnitPrice, p.Discount, p.ProductPhoto
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

go

CREATE PROCEDURE usp_DeleteProduct
@productDeleteList udt_ProductDeleteList READONLY
AS
BEGIN TRAN
	BEGIN TRY
		delete from dbo.Product
		where ProductId = (select pl.Id from @productDeleteList pl)
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH
