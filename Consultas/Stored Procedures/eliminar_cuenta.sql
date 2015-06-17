Create procedure dbo.eliminar_Cuenta
	@Id_Cuenta numeric (18,0)
AS

	UPDATE [GD1C2015].[dbo].[Cuentas]
   
   SET [Cuenta_Estado] = 'Cerrada'

 WHERE Cuenta_Nro = @Id_Cuenta;

GO

