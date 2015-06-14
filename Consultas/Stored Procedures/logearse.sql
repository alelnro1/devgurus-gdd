CREATE PROCEDURE logearse
	@rol varchar (255),
	@usuario varchar (255),
	@password varchar (255)
AS
	DECLARE @rol_Id tinyint
	DECLARE @usuario_Id int
	DECLARE @usuario_Pass varchar (255)
	DECLARE @nro_Intento tinyint
	DECLARE @validation_Rol int
	
	SET @rol_Id = (SELECT Rol_Id FROM dbo.Roles WHERE Rol_Desc = @rol)
	SET @usuario_Id = (SELECT Usuarios_Id FROM dbo.Usuarios WHERE Usuarios_Name = @usuario)
	SET @usuario_Pass = (SELECT Usuarios_Pass FROM dbo.Usuarios WHERE Usuarios_Name = @usuario)
	SET @nro_Intento = (SELECT MAX(LO.Login_Incorrecto_Intento) FROM dbo.Login_Incorrecto LO WHERE 
	@usuario_Id = LO.Login_Incorrecto_User)
	SET @validation_Rol = (SELECT Rol_X_Usuario_Usuario from dbo.Rol_X_Usuario where 
	Rol_X_Usuario_Usuario = @usuario_Id and Rol_X_Usuario_Rol = @rol_Id)

	IF (@usuario_Id is null)
	BEGIN
	select 'No existe' MENSAJE
	insert into Login_Auditoria (Login_Auditoria_Ingresado, Login_Auditoria_Fecha, Login_Auditoria_Tipo)
	values (@usuario, GETDATE(), 'Incorrecto')
	END
	
	ELSE IF (@validation_Rol is null)
	BEGIN
	select 'No rol valido' MENSAJE
	insert into Login_Auditoria (Login_Auditoria_Ingresado, Login_Auditoria_Fecha, Login_Auditoria_Tipo)
	values (@usuario, GETDATE(), 'Incorrecto')
	END
	
	ELSE IF (@nro_Intento = 3)
	BEGIN
	select 'Bloqueado' MENSAJE
	insert into Login_Auditoria (Login_Auditoria_Ingresado, Login_Auditoria_Fecha, Login_Auditoria_Tipo, Login_Auditoria_Intento)
	values (@usuario, GETDATE(), 'Fallido', @nro_Intento + 1)
	END
	
	ELSE IF (@usuario_Pass <> @password)
	BEGIN
	select 'Incorrecto' MENSAJE
	
		IF (@nro_Intento is null)
		BEGIN
		insert into dbo.Login_Incorrecto (Login_Incorrecto_User, Login_Incorrecto_Pass, Login_Incorrecto_Intento, Login_Incorrecto_Fecha)
		values (@usuario_Id, @password, 1, GETDATE())
		insert into Login_Auditoria (Login_Auditoria_Ingresado, Login_Auditoria_Fecha, Login_Auditoria_Tipo, Login_Auditoria_Intento)
		values (@usuario, GETDATE(), 'Fallido', 1)
		END
		ELSE
		BEGIN
		insert into dbo.Login_Incorrecto (Login_Incorrecto_User, Login_Incorrecto_Pass, Login_Incorrecto_Intento, Login_Incorrecto_Fecha)
		values (@usuario_Id, @password, @nro_Intento + 1, GETDATE())
		insert into Login_Auditoria (Login_Auditoria_Ingresado, Login_Auditoria_Fecha, Login_Auditoria_Tipo, Login_Auditoria_Intento)
		values (@usuario, GETDATE(), 'Fallido', @nro_Intento + 1)
		END
	END
	
	ELSE
	BEGIN
	select 'Correcto' MENSAJE
	insert into Login_Auditoria (Login_Auditoria_Ingresado, Login_Auditoria_Fecha, Login_Auditoria_Tipo)
	values (@usuario, GETDATE(), 'Correcto')
	delete from dbo.Login_Incorrecto where Login_Incorrecto_User = @usuario_Id
	END
GO