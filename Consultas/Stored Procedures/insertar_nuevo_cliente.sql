CREATE PROCEDURE insertarNuevoCliente
	@apellido varchar(255), @calle varchar(255), @depto varchar(10), @mail varchar(255),
	@nombre varchar(255), @nro_doc int, @pais varchar(255), @piso int, @tipo_doc varchar(255), @cliente_user int, @cliente_localidad varchar(255),
	 @fec_nac varchar(255),@nro_calle numeric(18,0), @nacionalidad varchar(255)
AS
	declare @tipo_documento_id int
	select @tipo_documento_id = Tipo_Doc_Id from Tipo_De_Doc where @tipo_doc = Tipo_Doc_Desc;
	declare @pais_id int
	select  @pais_id = Pais_Id from Paises where Pais_Nombre=@pais;
	declare @fecha_nacimiento_a_insertar datetime
	SELECT  @fecha_nacimiento_a_insertar = CAST( @fec_nac  AS datetime);
	
	INSERT INTO Clientes 
		(Cliente_Apellido, Cliente_Dom_Calle, Cliente_Dom_Depto, Cliente_Mail,
		 Cliente_Nombre, Cliente_Nro_Doc, Cliente_Pais, Cliente_Dom_Piso, Cliente_Tipo_Doc, Cliente_User, Cliente_Localidad,Cliente_Fecha_Nac,Cliente_Dom_Nro,Cliente_Nacionalidad)
	VALUES
		(@apellido, @calle, @depto, @mail, @nombre, @nro_doc, @pais_id, @piso, @tipo_documento_id, @cliente_user, @cliente_localidad,@fecha_nacimiento_a_insertar,@nro_calle,@nacionalidad)
	INSERT INTO Rol_X_Usuario
		(Rol_X_Usuario_Usuario,Rol_X_Usuario_Rol)
		VALUES (@cliente_user,2)
		
		GO
