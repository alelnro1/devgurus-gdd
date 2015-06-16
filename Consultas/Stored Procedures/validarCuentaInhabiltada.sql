CREATE TRIGGER validarCuentaInhabilitada
ON dbo.Transaccion_Pendiente
AFTER INSERT
AS
	DECLARE @cliente int
	DECLARE @cuenta numeric(18,0)
	DECLARE @contador tinyint
	
	SET @cliente = (select Transaccion_Pendiente_Cliente from INSERTED)
	SET @cuenta = (select Transaccion_Pendiente_Cuenta_Nro from INSERTED)
	SET @contador = (Select COUNT(*) CONTADOR from dbo.Transaccion_Pendiente where Transaccion_Pendiente_Cliente = @cliente
	and Transaccion_Pendiente_Cuenta_Nro = @cuenta)
	
	IF (@contador = 5)
	BEGIN
	update Cuenta_Estado SET Cuenta_Estado = 'Inhabilitado' where Cuenta_Nro = @cuenta
	END
GO