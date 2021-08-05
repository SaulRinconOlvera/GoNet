--  Create work table
Create Table EstructuraTest(Id int not null, [Name] nvarchar(20) not null, ParentId int null)
Go;

--  Add data
Insert into EstructuraTest Values
(1, 'Jose', null), 
(2, 'Marco', 1), (3, 'Pedro', 1),
(4, 'Aracely', 2), (5, 'Antonio', 2), (6, 'Andrea', 2),
(7, 'Abigail', 4), (8, 'Noemi', 4),
(9, 'Josue', 3), (10, 'Adriana', 3),
(11, 'Victor', 9), (12, 'Mónica', 9)
Go;

--  Create GetMando function
Create  function GetMando(@Name as nVarChar(30))
Returns NVARCHAR(max)
as
BEGIN

    Declare @Result as NVARCHAR(max)

    SELECT  @Result = [Name]
    FROM    EstructuraTest
    WHERE   Id = (
            SELECT  ParentId
            FROM    EstructuraTest
            WHERE   [Name] = @Name
    )

    If Not @Result is null
        Set @Result = @Result + ',' + dbo.GetMando(@Result)
    ELSE
        return ''

   return @Result
End
Go;

--  Exec function
Select dbo.GetMando('Abigail')
Go;