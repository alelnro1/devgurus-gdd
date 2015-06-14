create procedure depositar
	@Id_Cuenta numeric (18,0),
	@tarjeta varchar(4),
	@importe float,
	@moneda varchar(255)
	
AS

	Declare @id_tarjeta numeric (18,0)
	
	SELECT  @id_tarjeta = Tarjeta_Id FROM Tarjetas where Tarjeta_Digitos_Visibles = @tarjeta
	

	INSERT INTO Depositos (Deposito_Id, Deposito_Cuenta, Deposito_Fecha, Deposito_Importe, Deposito_Tarjeta, Deposito_TipoMoneda)
	VALUES ((SELECT TOP 1 Deposito_Id + 1  FROM Depositos ORDER BY Deposito_Id DESC), 
			@Id_Cuenta, 
			GETDATE(), 
			@importe, 
			@id_tarjeta, 
			@moneda)
			
	UPDATE Cuentas SET Cuenta_Saldo = Cuenta_Saldo + @importe WHERE Cuenta_Nro = @Id_Cuenta
GO
