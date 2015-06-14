CREATE PROCEDURE actualizar_cliente
	@id_cliente int

AS
	
	UPDATE [GD1C2015].[dbo].[Clientes]
   SET [Cliente_Estado] = 'Habilitado'
 WHERE @id_cliente = Cliente_Id

GO
	
	
	
	
	

