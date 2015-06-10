CREATE PROCEDURE insertarNuevoCliente
	@apellido varchar(255), @calle varchar(255), @depto varchar(10), @fec_nac datetime, @mail varchar(255),
	@nombre varchar(255), @nro_doc int, @pais int, @piso int, @tipo_doc int, @cliente_user int
AS
	INSERT INTO Clientes 
		(Cliente_Apellido, Cliente_Dom_Calle, Cliente_Dom_Depto, Cliente_Fecha_Nac, Cliente_Mail,
		 Cliente_Nombre, Cliente_Nro_Doc, Cliente_Pais, Cliente_Dom_Piso, Cliente_Tipo_Doc, Cliente_User)
	VALUES
		(@apellido, @calle, @depto, @fec_nac, @mail, @nombre, @nro_doc, @pais, @piso, @tipo_doc, @cliente_user)
	