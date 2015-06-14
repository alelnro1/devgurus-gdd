create procedure dbo.eliminar_Cliente
	@Id_Cliente int
AS
 
UPDATE Clientes SET Cliente_Estado = 'Inhabilitado' where Cliente_Id = @Id_Cliente
GO
