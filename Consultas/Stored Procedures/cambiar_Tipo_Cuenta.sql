create PROCEDURE cambiar_Tipo_Cuenta
	@tipo_Cuenta varchar(50),
	@cuenta_Nro numeric(18,0)
AS
	DECLARE @tipo_Cuenta_Vieja tinyint
	DECLARE @cuenta_Cliente int
	DECLARE @tipo_Cuenta_Nueva_Costo numeric (18,2)
	DECLARE @tipo_Cuenta_Nueva_Id tinyint
	
	SET @tipo_Cuenta = (SELECT Tipo_De_Cuentas_Id FROM dbo.Tipo_De_Cuentas WHERE Tipo_De_Cuentas_Nombre = @tipo_Cuenta)
	SET @cuenta_Cliente = (SELECT Cuenta_Cliente FROM dbo.Cuentas WHERE Cuenta_Nro = @cuenta_Nro)
	SET @tipo_Cuenta_Vieja = (SELECT Cuenta_Tipo FROM dbo.Cuentas WHERE Cuenta_Nro = @cuenta_Nro)
	SET @tipo_Cuenta_Nueva_Costo = (Select Tipo_De_Cuentas_Costo from dbo.Tipo_De_Cuentas
	where Tipo_De_Cuentas_Id = @tipo_Cuenta)
	
	IF (@tipo_Cuenta <> @tipo_Cuenta_Vieja)
	BEGIN
	update dbo.Cuentas
	set Cuenta_Tipo = @tipo_Cuenta
	where Cuenta_Nro = @cuenta_Nro
	insert into dbo.Transaccion_Pendiente (Transaccion_Pendiente_Importe, Transaccion_Pendiente_Descr, 
	Transaccion_Pendiente_Cliente, Transaccion_Pendiente_Fecha, Transaccion_Pendiente_Cuenta_Nro)
	values(@tipo_Cuenta_Nueva_Costo, 'Cambio del Tipo de Cuenta', @cuenta_Cliente, GETDATE(), 
	@cuenta_Nro)
	END
GO