CREATE PROCEDURE generar_Nueva_Factura
	@numero_Cliente int
AS
	DECLARE @numero_Factura numeric(18,0)
		
	SET @numero_Factura = (SELECT MAX(Factura_Numero) FROM dbo.Facturas)
	SET @numero_Factura = @numero_Factura + 1
	
	insert into dbo.Facturas (Factura_Numero, Factura_Fecha, Factura_Descripcion, Factura_Importe,
	Factura_Cliente)
	values (@numero_Factura, GETDATE(), 'Facturación Bancaria', 0, @numero_Cliente)
	
	select @numero_Factura Numero_Factura
GO