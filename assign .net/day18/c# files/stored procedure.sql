Create Procedure abhi

@abc nvarchar(50)
as
Begin
 Select * from Product where Name like @abc
End
