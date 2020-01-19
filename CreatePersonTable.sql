CREATE TABLE Person
(
    PersonId int primary key identity(1,1),
    PersonCode int,
    FirstName nvarchar(max) not null,
	LastName nvarchar(max) not null,
	Phone nvarchar(13) check (Phone like '%[+][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]%') not null,
	Email nvarchar(90) check (Email like '%_@_%_.__%'),
	PersonAddress nvarchar(max),
	City nvarchar(50) not null,
	Country nvarchar(50) not null,
	Company nvarchar(max)

)