CREATE TRIGGER trigger_actualizar_importe_factura_nuevo_item_agregado
ON Items
AFTER INSERT
AS
BEGIN
	DECLARE @factura_numero numeric(18,0);
	DECLARE @importe_actual numeric(18,0);
	DECLARE @importe_nuevo numeric(18,0);
	
	SET @factura_numero = (SELECT Items_Factura FROM INSERTED);
	SET @importe_actual = (SELECT Factura_Importe FROM Facturas WHERE Factura_Numero = @factura_numero);
	SET @importe_nuevo = @importe_actual + (SELECT Items_Importe FROM INSERTED)
	
	UPDATE Facturas SET Factura_Importe = @importe_nuevo WHERE Factura_Numero = @factura_numero
END