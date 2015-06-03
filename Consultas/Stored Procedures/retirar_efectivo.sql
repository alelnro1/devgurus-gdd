CREATE PROCEDURE retirar_efectivo @Cuenta_Nro nvarchar(18), @importe nvarchar(18)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @saldo_actual numeric(18,0);
	
	SELECT * FROM Cuentas WHERE Cuenta_Nro = @Cuenta_Nro 
END