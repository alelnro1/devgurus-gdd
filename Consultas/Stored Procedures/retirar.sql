CREATE PROCEDURE retirar
	@cuenta numeric (18,0),
	@importe float
AS
	DECLARE @cheque_id numeric (18,0)
	DECLARE @retiro_id numeric (18,0)
	SET @cheque_id = (SELECT TOP 1 Cheque_Id + 1  FROM Cheques ORDER BY Cheque_Id DESC)
	SET @retiro_id = (SELECT TOP 1 Retiro_Id + 1  FROM Retiros ORDER BY Retiro_Id DESC)
	
	INSERT INTO Cheques (Cheque_Id, Cheque_Fecha, Cheque_Importe) 
		VALUES (@cheque_id, GETDATE(), @importe)
	
	INSERT INTO Retiros (Retiro_Id, Retiro_Cheque, Retiro_Cuenta, Retiro_Fecha, Retiro_Importe)
		VALUES (@retiro_id, @cheque_id, @cuenta, GETDATE(), @importe)
	
	UPDATE Cuentas SET Cuenta_Saldo = Cuenta_Saldo - @importe WHERE Cuenta_Nro = @cuenta
GO