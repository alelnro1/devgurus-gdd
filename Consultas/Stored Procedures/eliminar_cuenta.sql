CREATE PROCEDURE DEVGURUS.eliminar_Cuenta
	@Id_Cuenta numeric (18,0)
AS
	UPDATE DEVGURUS.Cuentas SET Cuenta_Estado = 'Cerrada' WHERE Cuenta_Nro = @Id_Cuenta;
	UPDATE DEVGURUS.Cuentas SET Cuenta_Fec_Cierre = GETDATE() WHERE Cuenta_Nro = @Id_Cuenta;
GO