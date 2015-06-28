CREATE PROCEDURE actualizar_cliente
	@id_cliente int,@nombre varchar(255),@estado varchar(255),@apellido varchar(255),
	 @tipo_doc varchar(255), @nro_doc int,@nacionalidad varchar(255),@pais varchar(255), @localidad varchar(255),
	@Dom_Calle varchar(255), @Dom_Nro numeric(18,0),@Dom_Piso numeric(18,0), @Dom_Depto varchar(10),@fecha_nacimiento_recibida varchar(255), @Mail varchar(255)

AS
	declare @tipo_documento_id int
	select @tipo_documento_id = Tipo_Doc_Id from Tipo_De_Doc where @tipo_doc = Tipo_Doc_Desc;
	declare @pais_id int
	select  @pais_id = Pais_Id from Paises where Pais_Nombre=@pais;
	declare @fecha_nacimiento_a_insertar datetime
	SELECT  @fecha_nacimiento_a_insertar = CAST(@fecha_nacimiento_recibida AS datetime);
	declare @cliente_pais_id_nacionalidad int
	select  @cliente_pais_id_nacionalidad = Pais_Id from Paises where Pais_Nombre=@nacionalidad;
	
	UPDATE [GD1C2015].[DEVGURUS].[Clientes]
   SET [Cliente_Nombre] = @nombre
	  ,[Cliente_Estado]= @estado
      ,[Cliente_Apellido] = @apellido
      ,[Cliente_Tipo_Doc] = @tipo_documento_id
      ,[Cliente_Nro_Doc] =  @nro_doc 
      ,[Cliente_Nacionalidad] = @cliente_pais_id_nacionalidad
      ,[Cliente_Pais] = @pais_id 
      ,[Cliente_Localidad] = @localidad
      ,[Cliente_Dom_Calle] = @Dom_Calle
      ,[Cliente_Dom_Nro] = @Dom_Nro
      ,[Cliente_Dom_Piso] = @Dom_Piso
      ,[Cliente_Dom_Depto] = @Dom_Depto
      ,[Cliente_Fecha_Nac]= @fecha_nacimiento_a_insertar
      ,[Cliente_Mail] = @Mail
      

 WHERE @id_cliente = Cliente_Id
 
GO
