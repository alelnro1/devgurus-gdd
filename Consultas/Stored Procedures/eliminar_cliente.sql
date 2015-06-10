CREATE procedure dbo.eliminar_Cliente
	@Id_Cliente int
AS
	delete from dbo.Transaccion_Pendiente WHERE Transaccion_Pendiente_Cliente = @Id_Cliente
	delete from Items where Items_Factura in (select factura_numero from Facturas where Factura_Cliente = @Id_Cliente)
	delete from dbo.Facturas WHERE Factura_Cliente = @Id_Cliente
	
	-- DE ACA SE ELIMINA CADA CUENTA DEL CLIENTE
	DECLARE @param numeric(18,0)

	DECLARE curs CURSOR LOCAL FAST_FORWARD FOR
		select cuenta_nro from cuentas where Cuenta_Cliente = @Id_Cliente

	OPEN curs

	FETCH NEXT FROM curs INTO @param

	WHILE @@FETCH_STATUS = 0 BEGIN
		EXEC eliminar_Cuenta  @param
		FETCH NEXT FROM curs INTO @param
	END

	CLOSE curs
	DEALLOCATE curs
	
	delete from dbo.Clientes WHERE Cliente_Id = @Id_Cliente	
GO
