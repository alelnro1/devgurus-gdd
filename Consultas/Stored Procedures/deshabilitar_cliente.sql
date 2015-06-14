CREATE PROCEDURE deshabilitar_cliente
	@id_cliente int

AS
	
	UPDATE [GD1C2015].[dbo].[Clientes]
   SET [Cliente_Estado] = 'Deshabilitado'
 WHERE @id_cliente = Cliente_Id

GO
	
	