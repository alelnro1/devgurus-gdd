CREATE PROCEDURE actualizar_cliente
	@id_cliente int,@nombre varchar(255),@estado varchar(255),@apellido varchar(255), @tipo_doc int, @nro_doc int,@nacionalidad varchar(255),@pais int, @localidad varchar(255),
	@Dom_Calle varchar(255), @Dom_Nro numeric(18,0),@Dom_Piso numeric(18,0), @Dom_Depto varchar(10),@Fecha_Nac datetime,@Mail varchar(255),@User int

AS
	
	UPDATE [GD1C2015].[dbo].[Clientes]
   SET [Cliente_Nombre] = @nombre
	  ,[Cliente_Estado]= @estado
      ,[Cliente_Apellido] = @apellido
      ,[Cliente_Tipo_Doc] = @tipo_doc
      ,[Cliente_Nro_Doc] =  @nro_doc 
      ,[Cliente_Nacionalidad] = @nacionalidad
      ,[Cliente_Pais] = @pais 
      ,[Cliente_Localidad] = @localidad
      ,[Cliente_Dom_Calle] = @Dom_Calle
      ,[Cliente_Dom_Nro] = @Dom_Nro
      ,[Cliente_Dom_Piso] = @Dom_Piso
      ,[Cliente_Dom_Depto] = @Dom_Depto
      ,[Cliente_Fecha_Nac] = @Fecha_Nac
      ,[Cliente_Mail] = @Mail
      ,[Cliente_User] = @User
 WHERE @id_cliente = Cliente_Id

GO