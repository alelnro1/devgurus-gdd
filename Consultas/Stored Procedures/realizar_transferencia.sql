CREATE PROCEDURE realizar_transferencia
	@cuenta_origen numeric (18,0),
	@cuenta_destino numeric (18,0),
	@importe float,
	@mismo_usuario int
AS
	UPDATE Cuentas SET Cuenta_Saldo = Cuenta_Saldo - @importe WHERE Cuenta_Nro = @cuenta_origen
	UPDATE Cuentas SET Cuenta_Saldo = Cuenta_Saldo + @importe WHERE Cuenta_Nro = @cuenta_destino
	
	IF @mismo_usuario = 1
		INSERT INTO Transaccion_Pendiente (Transaccion_Pendiente_Cliente, Transaccion_Pendiente_Descr, Transaccion_Pendiente_Fecha, Transaccion_Pendiente_Importe)
			VALUES ((SELECT Cuenta_Cliente FROM Cuentas WHERE Cuenta_Nro = @cuenta_origen),
					'Transferencia de ' + @importe + ' ' + (SELECT CU.Cuenta_Moneda FROM Cuentas CU, Tipo_De_Moneda TM WHERE Cuenta_Nro = @cuenta_origen AND CU.Cuenta_Moneda = TM.Tipo_De_Moneda_Nombre) + ' de la cuenta ',
					
			)
GO
