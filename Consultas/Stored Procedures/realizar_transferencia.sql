CREATE PROCEDURE realizar_transferencia
	@cuenta_origen numeric (18,0),
	@cuenta_destino numeric (18,0),
	@importe float,
	@mismo_usuario int
AS
	UPDATE Cuentas SET Cuenta_Saldo = Cuenta_Saldo - @importe WHERE Cuenta_Nro = @cuenta_origen
	UPDATE Cuentas SET Cuenta_Saldo = Cuenta_Saldo + @importe WHERE Cuenta_Nro = @cuenta_destino
	DECLARE @costo numeric(18,2);
	
	IF @mismo_usuario = 1
		SET @costo = 0
	ELSE
		SET @costo = (SELECT Tipo_De_Cuentas_Costo FROM Tipo_De_Cuentas WHERE Tipo_De_Cuentas_Id = (SELECT Cuenta_Tipo FROM Cuentas WHERE Cuenta_Nro = @cuenta_origen))
	
	INSERT INTO Transaccion_Pendiente (Transaccion_Pendiente_Cliente, Transaccion_Pendiente_Descr, 
			Transaccion_Pendiente_Fecha, Transaccion_Pendiente_Importe, Transaccion_Pendiente_Cuenta_Nro)
	VALUES ((SELECT Cuenta_Cliente FROM Cuentas WHERE Cuenta_Nro = @cuenta_origen),   
			'Transferencia de ' + CAST(@importe AS VARCHAR) + ' ' + CAST((SELECT TM.Tipo_De_Moneda_Nombre FROM Cuentas CU, Tipo_De_Moneda TM WHERE Cuenta_Nro = @cuenta_origen AND CU.Cuenta_Moneda = TM.Tipo_De_Moneda_Id) AS VARCHAR) + ' de la cuenta ' + CAST(@cuenta_origen AS VARCHAR) + ' a la cuenta ' + CAST(@cuenta_destino AS VARCHAR),
			GETDATE(),
			@costo,
			@cuenta_origen
	)
GO