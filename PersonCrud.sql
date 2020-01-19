CREATE PROCEDURE usp_InsertPerson
@personInsertList udt_PersonInsertList READONLY
AS
BEGIN TRAN
		BEGIN TRY
			declare @personCode int
			set @personCode = (select MAX(PersonCode) from dbo.Person)
			set @personCode = ISNULL(@personCode,1000)+1
			insert into dbo.Person(PersonCode,FirstName,LastName,Phone,Email,PersonAddress,City,Country,Company)
			select @personCode,firstName,lastName,phone,email,personAddress,city,country,company from @personInsertList
		COMMIT TRAN
		END TRY
		BEGIN CATCH
			ROLLBACK TRAN
		END CATCH
go

CREATE PROCEDURE usp_UpdatePerson
@personUpdateList udt_PersonUpdateList READONLY
AS
BEGIN TRAN
	BEGIN TRY
		update dbo.Person 
		set FirstName = pl.firstName,
		LastName = pl.lastName,
		Phone = pl.phone,
		Email = pl.email,
		PersonAddress = pl.personAddress,
		City = pl.city,
		Country = pl.country,
		Company = pl.company
		from @personUpdateList pl
		where PersonId = pl.Id
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

go

CREATE PROCEDURE [dbo].[usp_DeletePerson]
@personDeleteList udt_PersonDeleteList READONLY
AS
BEGIN TRAN
	BEGIN TRY
		delete from dbo.Person
		where PersonId = (select pl.Id from @personDeleteList pl)
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH


go

CREATE PROCEDURE usp_SelectPerson
AS
BEGIN TRAN
	BEGIN TRY
		select 
		PersonId,
		PersonCode,
		FirstName,
		LastName,
		Phone,
		Email,
		PersonAddress,
		City,
		Country,
		Company
		from dbo.Person
	COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	END CATCH

go