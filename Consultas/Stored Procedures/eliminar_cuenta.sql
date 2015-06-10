CREATE procedure dbo.eliminar_Cuenta
	@Id_Cuenta numeric (18,0)
AS
	delete from dbo.Depositos WHERE Deposito_Cuenta = @Id_Cuenta
	delete from dbo.Transferencia 
		where Transferencia_Cuenta_Destino = @Id_Cuenta OR Transferencia_Cuenta_Emisora = @Id_Cuenta
	delete from dbo.Retiros
		where Retiro_Cuenta = @Id_Cuenta
	delete from dbo.Cuentas WHERE Cuenta_Nro = @Id_Cuenta	
GO

exec eliminar_Cuenta 1111111111111115