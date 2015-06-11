CREATE procedure depositar
	@Id_Cuenta numeric (18,0),
	@tarjeta varchar(16),
	@importe float,
	@moneda tinyint
AS
	INSERT INTO Depositos (Deposito_Id, Deposito_Cuenta, Deposito_Fecha, Deposito_Importe, Deposito_Tarjeta, Deposito_TipoMoneda)
	VALUES ((SELECT TOP 1 Deposito_Id + 1  FROM Depositos ORDER BY Deposito_Id DESC), 
			@Id_Cuenta, 
			GETDATE(), 
			@importe, 
			@tarjeta, 
			@moneda)
			
	UPDATE Cuentas SET Cuenta_Saldo = Cuenta_Saldo + @importe WHERE Cuenta_Nro = @Id_Cuenta
GO
