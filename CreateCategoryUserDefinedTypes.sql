CREATE TYPE udt_CategoryInsertList AS TABLE
(
    categoryName nvarchar(max)
)

go

CREATE TYPE udt_CategoryUpdateList AS TABLE
(
    categoryId int,
    categoryName nvarchar(max)
)

go

CREATE TYPE udt_CategoryDeleteList AS TABLE
(
    categoryId int
)
