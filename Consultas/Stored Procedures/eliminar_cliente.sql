CREATE procedure dbo.eliminar_Cliente
	@Id_Cliente numeric (18,0)
AS
	delete from dbo.Transaccion_Pendiente WHERE Transaccion_Pendiente_Cliente = @Id_Cliente
	delete from dbo.Facturas WHERE Factura_Cliente = @Id_Cliente
	delete from dbo.Cuentas WHERE Cuenta_Cliente = @Id_Cliente	
	delete from dbo.Clientes WHERE Cliente_Id = @Id_Cliente	
GO

//para mi quengo que hacer el exect eliminar cuentas de cliente o algo asi 