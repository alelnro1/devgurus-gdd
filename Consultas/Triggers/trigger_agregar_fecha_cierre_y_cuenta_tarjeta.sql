CREATE TRIGGER trigger_agregar_fecha_cierre_y_cuenta_tarjeta
ON Cuentas 
AFTER INSERT
AS 
BEGIN
	UPDATE Cuentas SET Cuenta_Fec_Cierre = DATEADD(day, 15, Cuenta_Fec_Cre) 
	WHERE Cuenta_Nro IN (SELECT Cuenta_Nro FROM INSERTED);
	
	UPDATE Cuentas
	SET Cuenta_Tarjeta = MA.Tarjeta_Numero from gd_esquema.Maestra MA
	WHERE Cuenta_Nro = MA.Cuenta_Numero and MA.Tarjeta_Numero is not null
END