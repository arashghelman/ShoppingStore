use ShoppingStoreDBFirst
go


CREATE PROCEDURE usp_InsertCategory
@categoryInsertList udt_CategoryInsertList READONLY
AS
BEGIN TRAN
	BEGIN TRY
		insert into dbo.Category(CategoryName)
		select categoryName from @categoryInsertList
		COMMIT TRAN
	END TRY
	BEGIN CATCH
	ROLLBACK TRAN
	END CATCH

go

CREATE PROCEDURE usp_UpdateCategory
@categoryUpdateList udt_CategoryUpdateList READONLY
AS
BEGIN TRAN
	BEGIN TRY
		update dbo.Category
		set CategoryName = ul.categoryName
		from @categoryUpdateList ul
		where (select CategoryId from dbo.Category) = ul.categoryId
		COMMIT TRAN
	END TRY
	BEGIN CATCH
	ROLLBACK TRAN
	END CATCH

go

CREATE PROCEDURE usp_DeleteCategory
@categoryDeleteList udt_CategoryDeleteList READONLY
AS
BEGIN TRAN
	BEGIN TRY
		delete from dbo.Category
		where CategoryId = (select categoryId from @categoryDeleteList)
		COMMIT TRAN
	END TRY
	BEGIN CATCH
	ROLLBACK TRAN
	END CATCH

go

CREATE PROCEDURE usp_SelectCategory
AS
BEGIN TRAN
BEGIN TRY
select c.CategoryId,c.CategoryName
from dbo.Category c
COMMIT TRAN
END TRY
BEGIN CATCH
ROLLBACK TRAN
END CATCH