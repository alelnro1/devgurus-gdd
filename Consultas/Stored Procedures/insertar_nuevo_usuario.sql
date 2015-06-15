create PROCEDURE insertarNuevoUsuario
	@nombre varchar(255),
	@password varchar(255), 
	@rol varchar(25), 
	@pregunta varchar(255), 
	@respuesta varchar(255)
AS
	DECLARE @id_Rol int
	DECLARE @id_User int
	
	SET @id_Rol = (select Rol_Id from dbo.Roles where Rol_Desc = @rol)
	
	INSERT INTO Usuarios 
		(	Usuarios_Name, Usuarios_Pass, Usuarios_FechaCreacion, Usuarios_FechaUltimaModificacion, 
			Usuarios_PreguntaSecreta, Usuarios_RespuestaSecreta)
	VALUES
		(@nombre, @password, GETDATE(), GETDATE(), @pregunta, @respuesta)
	
	
	SET @id_User = (select MAX(Usuarios_Id) from dbo.Usuarios)
	
	insert into Rol_X_Usuario values (@id_User, @id_Rol)
	select 'Correcto' MENSAJE
GO