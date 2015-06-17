CREATE PROCEDURE asignar_Item_A_Factura
	@numero_Factura numeric(18,0),
	@numero_Item int
AS
	DECLARE @items_Desc varchar(255)
	DECLARE @importe numeric(18,2)	
		
	SET @items_Desc = (SELECT Transaccion_Pendiente_Descr FROM dbo.Transaccion_Pendiente WHERE 
	Transaccion_Pendiente_Id = @numero_Item)
	SET @importe = (SELECT Transaccion_Pendiente_Importe FROM dbo.Transaccion_Pendiente WHERE 
	Transaccion_Pendiente_Id = @numero_Item)
	
	insert into dbo.Items (Items_Descripcion, Items_Importe, Items_Factura)
	values (@items_Desc, @importe, @numero_Factura)
	
	update dbo.Facturas set Factura_Importe = Factura_Importe + @importe
	where Factura_Numero = @numero_Factura
GO