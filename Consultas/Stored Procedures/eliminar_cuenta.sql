CREATE procedure dbo.eliminar_Cuenta
	@Id_Cuenta numeric (18,0)
AS
	delete from dbo.Depositos WHERE Deposito_Cuenta = @Id_Cuenta
	delete from dbo.Cuentas WHERE Cuenta_Nro = @Id_Cuenta	
GO