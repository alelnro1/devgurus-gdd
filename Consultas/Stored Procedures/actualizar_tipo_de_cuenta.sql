create procedure [dbo].[actualizar_tipo_de_cuenta]
	@id_cuenta numeric (18,0),
	@nombre_tipo_cuenta varchar(255)
	AS
	
	Declare @tipo_cuenta_id tinyint
	SELECT @tipo_cuenta_id = Tipo_De_Cuentas_Id FROM Tipo_De_Cuentas WHERE Tipo_De_Cuentas_Nombre = @nombre_tipo_cuenta
	
	update dbo.Cuentas set Cuenta_Tipo = @tipo_cuenta_id where Cuenta_Nro = @id_cuenta
	GO
