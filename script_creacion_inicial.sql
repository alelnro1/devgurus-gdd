USE GD1C2015
GO

SET LANGUAGE Spanish

/* ******************************************************************************************************************** */
/*	****************************************	CREACION DEL SCHEMA	*********************************************** */

IF NOT EXISTS (SELECT [schema_id] FROM [sys].[schemas] WHERE [name] = 'DEVGURUS')
BEGIN
	EXECUTE ('CREATE SCHEMA DEVGURUS AUTHORIZATION gd;');
END
GO


/* ******************************************************************************************************************** */
/*	****************************************	BORRO TABLAS DEL SISTEMA	******************************************* */

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Login_Auditoria')
BEGIN
	Print 'La tabla LOGIN AUDITORIA ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Login_Auditoria
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Login_Incorrecto')
BEGIN
	Print 'La tabla LOGIN INCORRECTO ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Login_Incorrecto
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Transaccion_Pendiente')
BEGIN
	Print 'La tabla TRANSACCION PENDIENTE ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Transaccion_Pendiente
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Retiros')
BEGIN
	Print 'La tabla RETIROS ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Retiros
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Cheques')
BEGIN
	Print 'La tabla CHEQUES ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Cheques
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Bancos')
BEGIN
	Print 'La tabla BANCOS ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Bancos
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Transferencia')
BEGIN
	Print 'La tabla TRANSFERENCIAS ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Transferencia
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Items')
BEGIN
	Print 'La tabla ITEMS ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Items
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Facturas')
BEGIN
	Print 'La tabla FACTURAS ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Facturas
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Depositos')
BEGIN
	Print 'La tabla DEPOSITOS ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Depositos
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Cuentas')
BEGIN
	Print 'La tabla CUENTAS ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Cuentas
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Tarjetas')
BEGIN
	Print 'La tabla TARJETAS ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Tarjetas
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Tipo_De_Cuentas')
BEGIN
	Print 'La tabla TIPO DE CUENTAS ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Tipo_De_Cuentas
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Clientes')
BEGIN
	Print 'La tabla CLIENTES ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Clientes
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Rol_X_Usuario')
BEGIN
	Print 'La tabla ROL X USUARIO ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Rol_X_Usuario
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Usuarios')
BEGIN
	Print 'La tabla USUARIOS ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Usuarios
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Roles')
BEGIN
	Print 'La tabla ROLES ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Roles
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Tipo_De_Doc')
BEGIN
	Print 'La tabla TIPO DE DOC ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Tipo_De_Doc
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Paises')
BEGIN
	Print 'La tabla PAISES ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Paises
END

IF EXISTS (SELECT 1 AS existe FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'DEVGURUS' AND  TABLE_NAME = 'Tipo_De_Moneda')
BEGIN
	Print 'La tabla TIPO DE MONEDA ya existe, SE BORRARA';
	DROP TABLE DEVGURUS.Tipo_De_Moneda
END


/* ******************************************************************************************************************** */
/*	********************************************	CREACION DE TABLAS	*********************************************** */

BEGIN TRAN CreacionTablas

/* 	TABLA: PAISES
	DESCRIPCION: Datos de los Paises con su correspondiente Id proveniente del Maestro
*/
Create Table DEVGURUS.Paises	(	Pais_Id numeric (18,0) PRIMARY KEY NOT NULL,
									Pais_Nombre varchar(255) NOT NULL)

/* 	TABLA: Tipo_De_Doc
	DESCRIPCION: Datos de los Tipos de documentos con su correspondiente Id proveniente del Maestro
*/
Create Table DEVGURUS.Tipo_De_Doc (	Tipo_Doc_Id numeric (18,0) PRIMARY KEY NOT NULL,
									Tipo_Doc_Desc varchar(255) NOT NULL)

/* 	TABLA: Roles
	DESCRIPCION: Creacion de Roles con su respectivas funciones como columnas
*/
Create Table DEVGURUS.Roles		(Rol_Id tinyint identity (1,1) PRIMARY KEY NOT NULL,
								Rol_Desc varchar(255) NOT NULL,
								Rol_Estado varchar (20) NOT NULL,
								Func_Extraer varchar (25) NOT NULL,
								Func_Transferir varchar (25) NOT NULL,
								Func_Depositar varchar (25) NOT NULL,
								Func_ABM_Roles varchar (25) NOT NULL,
								Func_ABM_Clientes varchar (25) NOT NULL,
								Func_ABM_Usuarios varchar (25) NOT NULL,
								Func_ABM_Cuentas varchar (25) NOT NULL,
								Func_Asociar_Tarjeta varchar (25) NOT NULL)
	
/* 	TABLA: Usuarios
	DESCRIPCION: Creacion de los Usuarios en base a los datos de clientes de la tabla maestra
*/	
Create Table DEVGURUS.Usuarios	(	Usuarios_Id integer identity (1,1) PRIMARY KEY NOT NULL,
									Usuarios_Name varchar(255) UNIQUE NOT NULL,
									Usuarios_Pass varchar(255) NOT NULL,
									Usuarios_FechaCreacion datetime NOT NULL,
									Usuarios_FechaUltimaModificacion datetime NOT NULL,
									Usuarios_PreguntaSecreta varchar(255) NOT NULL,
									Usuarios_RespuestaSecreta varchar (255) NOT NULL)
							
/* 	TABLA: Rol_X_Usuario
	DESCRIPCION: Tabla que relaciona los Roles con los Usuarios (relacion muchos a muchos)
*/							
Create Table DEVGURUS.Rol_X_Usuario(	Rol_X_Usuario_Usuario integer NOT NULL FOREIGN KEY REFERENCES Usuarios(Usuarios_Id),
										Rol_X_Usuario_Rol tinyint NOT NULL FOREIGN KEY REFERENCES Roles(Rol_Id),
										CONSTRAINT Pk_Rol_X_Usuario PRIMARY KEY (Rol_X_Usuario_Usuario,Rol_X_Usuario_Rol))

/* 	TABLA: Clientes
	DESCRIPCION: Creada a partir de los clientes de la tabla maestra
*/	
Create Table DEVGURUS.Clientes (	Cliente_Id integer identity (1,1) PRIMARY KEY NOT NULL,
									Cliente_Nombre varchar(255),
									Cliente_Estado varchar(255) default 'Inhabilitado',
									Cliente_Apellido varchar(255),
									Cliente_Tipo_Doc numeric (18,0) FOREIGN KEY REFERENCES Tipo_De_Doc(Tipo_Doc_Id),
									Cliente_Nro_Doc integer,
									Cliente_Nacionalidad varchar(255),
									Cliente_Pais numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
									Cliente_Localidad varchar(255),
									Cliente_Dom_Calle varchar(255),
									Cliente_Dom_Nro numeric(18,0),
									Cliente_Dom_Piso numeric(18,0),
									Cliente_Dom_Depto varchar(10),
									Cliente_Fecha_Nac datetime,
									Cliente_Mail varchar(255),
									Cliente_User integer FOREIGN KEY REFERENCES Usuarios(Usuarios_ID) unique)

/* 	TABLA: Tipo_De_Cuentas
	DESCRIPCION: Tabla con tipos de cuentas (Inventadas)
*/
Create Table DEVGURUS.Tipo_De_Cuentas(	Tipo_De_Cuentas_Id tinyint identity (1,1) PRIMARY KEY,
										Tipo_De_Cuentas_Nombre varchar(255),
										Tipo_De_Cuentas_Duracion_Dias smallint,
										Tipo_De_Cuentas_Costo numeric (18,2))

/* 	TABLA: Tarjetas
	DESCRIPCION: Tabla migrada de la tabla maestra con los datos de las tarjetas
*/
Create Table DEVGURUS.Tarjetas (		Tarjeta_Id integer IDENTITY (1,1) PRIMARY KEY NOT NULL,
										Tarjeta_Nro varchar(16)  NOT NULL,
										Tarjeta_Cliente integer FOREIGN KEY REFERENCES Clientes(Cliente_Id),
										Tarjeta_Digitos_Visibles varchar(4),
										Tarjeta_Fecha_Emision datetime,
										Tarjeta_Fecha_Vencimiento datetime,
										Tarjeta_Cod_Seg varchar(3),
										Tarjeta_Emisor_Desc varchar (255),
										Tarjeta_Asociada varchar(25) default 'Asociada')

/* 	TABLA: Tipo_De_Moneda
	DESCRIPCION: Tipo de monedas presentes en la tabla maestra
*/						
Create Table DEVGURUS.Tipo_De_Moneda(	Tipo_De_Moneda_Id tinyint identity (1,1) PRIMARY KEY,
										Tipo_De_Moneda_Nombre varchar(255))

/* 	TABLA: Cuentas
	DESCRIPCION: Tabla con todas las cuentas presentes en la tabla maestra
*/
Create Table DEVGURUS.Cuentas (		Cuenta_Nro numeric (18,0) PRIMARY KEY NOT NULL,
									Cuenta_Estado varchar(255) default 'Habilitado',
									Cuenta_Moneda tinyint FOREIGN KEY REFERENCES Tipo_De_Moneda(Tipo_De_Moneda_Id) default 1,
									Cuenta_Tipo tinyint FOREIGN KEY REFERENCES Tipo_De_Cuentas(Tipo_De_Cuentas_Id),
									Cuenta_PaisOrigen numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
									Cuenta_PaisAsignado numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
									Cuenta_Fec_Cre datetime,
									Cuenta_Fec_Cierre datetime,
									Cuenta_Cliente integer FOREIGN KEY REFERENCES Clientes(Cliente_Id),
									Cuenta_Saldo float default 0)

/* 	TABLA: Depositos
	DESCRIPCION: Tabla con Depositos cargados desde la tabla maestra
*/														
Create Table DEVGURUS.Depositos (	Deposito_Id numeric (18,0) PRIMARY KEY NOT NULL,
									Deposito_Fecha datetime,
									Deposito_Importe numeric (18,2) check (Deposito_Importe >= 1),
									Deposito_TipoMoneda varchar(255),
									Deposito_Cuenta numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
									Deposito_Tarjeta integer FOREIGN KEY REFERENCES Tarjetas(Tarjeta_Id))

/* 	TABLA: Facturas
	DESCRIPCION: Tabla con las facturas a cobrar a clientes
*/	
Create Table DEVGURUS.Facturas	(	Factura_Numero numeric (18,0) PRIMARY KEY NOT NULL,
									Factura_Fecha datetime,
									Factura_Descripcion varchar(255),
									Factura_Importe numeric(18,2),
									Factura_Cliente integer FOREIGN KEY REFERENCES Clientes(Cliente_Id))

/* 	TABLA: Items
	DESCRIPCION: Tabla con los Items pertenecientes a las facturas
*/								
Create Table DEVGURUS.Items	(		Items_Numero integer identity(1,1) PRIMARY KEY NOT NULL,
									Items_Descripcion varchar(255),
									Items_Importe numeric(18,2),
									Items_Factura numeric (18,0) FOREIGN KEY REFERENCES Facturas(Factura_Numero))

/* 	TABLA: Transferencia
	DESCRIPCION: Tabla con los Transferencias migradas desde el maestro
*/	
Create Table DEVGURUS.Transferencia (Transferencia_Id integer identity(1,1) PRIMARY KEY NOT NULL,
									Transferencia_Fecha datetime,
									Transferencia_Importe numeric (18,2),
									Transferencia_Costo_Transf numeric (18,2),
									Transferencia_Cuenta_Emisora numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
									Transferencia_Cuenta_Destino numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro))

/* 	TABLA: Bancos
	DESCRIPCION: Tabla que contiene todos los bancos presentes en la tabla maestra
*/	
Create Table DEVGURUS.Bancos	(	Banco_Id numeric (18,0) PRIMARY KEY NOT NULL,
									Banco_Nombre varchar(255),
									Banco_Direccion varchar(255))

/* 	TABLA: Cheques
	DESCRIPCION: Tabla que contiene todos los cheques presentes en la tabla maestra
*/								
Create Table DEVGURUS.Cheques	(	Cheque_Id numeric (18,0) PRIMARY KEY NOT NULL,
									Cheque_Fecha datetime,
									Cheque_Importe numeric (18,2),
									Cheque_Banco numeric (18,0) FOREIGN KEY REFERENCES Bancos(Banco_Id))

/* 	TABLA: Retiros
	DESCRIPCION: Tabla que contiene todos los Retiros presentes en la tabla maestra
*/															
Create Table DEVGURUS.Retiros	(	Retiro_Id numeric (18,0) PRIMARY KEY NOT NULL,
									Retiro_Fecha datetime,
									Retiro_Importe numeric (18,2),
									Retiro_Cuenta numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
									Retiro_Cheque numeric (18,0) FOREIGN KEY REFERENCES Cheques(Cheque_Id))

/* 	TABLA: Transaccion_Pendiente
	DESCRIPCION: Tabla creada para almacenar transacciones pendientes de pago
*/						
Create Table DEVGURUS.Transaccion_Pendiente	(	Transaccion_Pendiente_Id integer identity (1,1) PRIMARY KEY NOT NULL,
												Transaccion_Pendiente_Importe numeric (18,2),
												Transaccion_Pendiente_Descr varchar(255),
												Transaccion_Pendiente_Cliente integer FOREIGN KEY REFERENCES Clientes(Cliente_Id),
												Transaccion_Pendiente_Fecha datetime,
												Transaccion_Pendiente_Cuenta_Nro numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro))			

/* 	TABLA: Login Incorrecto
	DESCRIPCION: Tabla creada para almacenar los logeos incorrectos
*/							
Create Table DEVGURUS.Login_Incorrecto	(	Login_Incorrecto_Id integer identity (1,1) Primary key,
											Login_Incorrecto_User integer foreign key references Usuarios(Usuarios_Id),
											Login_Incorrecto_Pass varchar (255),
											Login_Incorrecto_Intento tinyint,
											Login_Incorrecto_Fecha datetime)

/* 	TABLA: LoginAuditoria
	DESCRIPCION: Tabla creada para almacenar los logeos incorrectos, fallidos y correctos
*/									
Create Table DEVGURUS.Login_Auditoria	(	Login_Auditoria_Id integer identity (1,1) Primary key,
											Login_Auditoria_Ingresado varchar(255),
											Login_Auditoria_Fecha datetime,
											Login_Auditoria_Tipo varchar(25),
											Login_Auditoria_Intento tinyint)
											
COMMIT TRAN CreacionTablas


/* ******************************************************************************************************************** */
/* ***************************************** INICIALIZACION DE DATOS ************************************************** */

BEGIN TRAN InicializacionDeDatos


/*	INSERTAMOS PAISES	*/
Insert into DEVGURUS.Paises (Pais_Id, Pais_Nombre)	select distinct Cli_Pais_Codigo, Cli_Pais_Desc from gd_esquema.Maestra union 
													select distinct Cuenta_Pais_Codigo, Cuenta_Pais_Desc from gd_esquema.Maestra union
													select distinct	Cuenta_Dest_Pais_Codigo, Cuenta_Dest_Pais_Desc from gd_esquema.Maestra
													where	Cli_Pais_Codigo <> NULL and
															Cuenta_Pais_Codigo <> NULL and
															Cuenta_Dest_Pais_Codigo <> NULL
UPDATE DEVGURUS.Paises SET Pais_Nombre = (SELECT REPLACE(Paises.Pais_Nombre, ' ', ''))

/*TIPOS DE MONEDA*/
Insert into DEVGURUS.Tipo_De_Moneda(Tipo_De_Moneda_Nombre) values ('Dolar');

/* TIPOS DE DOCUMENTO */
Insert into DEVGURUS.Tipo_De_Doc (Tipo_Doc_Id, Tipo_Doc_Desc) select distinct Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc from gd_esquema.Maestra

/* ROLES */
Insert into DEVGURUS.Roles (Rol_Desc, Rol_Estado, Func_Extraer, Func_Transferir, Func_Depositar, Func_ABM_Roles, Func_ABM_Clientes, Func_ABM_Usuarios, Func_ABM_Cuentas, Func_Asociar_Tarjeta)
values	('Administrador', 'Activo', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Inhabilitado'),
		('Cliente', 'Activo', 'Habilitado', 'Habilitado', 'Habilitado', 'Inhabilitado', 'Inhabilitado', 'Inhabilitado', 'Inhabilitado', 'Habilitado'),
		('Administrador General', 'Activo', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado')

/* USUARIOS */
Insert into DEVGURUS.Usuarios (Usuarios_Name, Usuarios_Pass, Usuarios_FechaCreacion, Usuarios_FechaUltimaModificacion, Usuarios_PreguntaSecreta, Usuarios_RespuestaSecreta)
select distinct REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Cli_Apellido +  CAST  (Cli_Nro_Doc AS varchar(255)), 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u'), 
SUBSTRING(Cli_Apellido, 1, 1)+SUBSTRING(Cli_Apellido, 1, 1)+SUBSTRING(Cli_Apellido, 1, 1)+SUBSTRING(Cli_Apellido, 1, 1)+'4321',
GETDATE(), GETDATE(), '¿En que pais naciste?', Cli_Pais_Desc from gd_esquema.Maestra

/* ROL_X_USUARIO */
Insert into DEVGURUS.Rol_X_Usuario (Rol_X_Usuario_Usuario, Rol_X_Usuario_Rol)
select US.Usuarios_Id, RO.Rol_Id from DEVGURUS.Usuarios US, DEVGURUS.Roles RO
where RO.Rol_Desc = 'Cliente'

/* CLIENTES */
Insert into DEVGURUS.Clientes(	Cliente_Nombre, Cliente_Apellido, Cliente_Tipo_Doc, Cliente_Pais, 
						Cliente_Dom_Calle, Cliente_Dom_Nro, Cliente_Dom_Piso, Cliente_Dom_Depto, 
						Cliente_Fecha_Nac, Cliente_Mail, Cliente_User,Cliente_Nro_Doc)
						select distinct MA.Cli_Nombre, MA.Cli_Apellido, MA.Cli_Tipo_Doc_Cod, 
						MA.Cli_Pais_Codigo, MA.Cli_Dom_Calle, MA.Cli_Dom_Nro, MA.Cli_Dom_Piso, MA.Cli_Dom_Depto, 
						MA.Cli_Fecha_Nac, MA.Cli_Mail, US.Usuarios_Id,MA.Cli_Nro_Doc from gd_esquema.Maestra MA, DEVGURUS.Usuarios US
						where US.Usuarios_Name = REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Cli_Apellido +  CAST  (Cli_Nro_Doc AS varchar(255)), 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u')


/* TIPO_DE_CUENTAS */
SET IDENTITY_INSERT Cuentas ON
Insert into DEVGURUS.Tipo_De_Cuentas (Tipo_De_Cuentas_Nombre, Tipo_De_Cuentas_Duracion_Dias, Tipo_De_Cuentas_Costo)
values	('Oro', 100, 29.99),
		('Plata', 60, 19.99),
		('Bronce', 30, 12.53),
		('Gratuita', 15, 0.00)

/* TARJETAS */
/* LAS FECHAS SON FUTURICAS */
Insert into DEVGURUS.Tarjetas (Tarjeta_Nro, Tarjeta_Cliente, Tarjeta_Digitos_Visibles, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, Tarjeta_Cod_Seg, Tarjeta_Emisor_Desc)
select distinct MA.Tarjeta_Numero, CL.Cliente_Id, RIGHT(MA.Tarjeta_Numero,4), MA.Tarjeta_Fecha_Emision, MA.Tarjeta_Fecha_Vencimiento, MA.Tarjeta_Codigo_Seg, 
MA.Tarjeta_Emisor_Descripcion from gd_esquema.Maestra MA, DEVGURUS.Clientes CL
where CL.Cliente_Apellido+CL.Cliente_Nombre = MA.Cli_Apellido+MA.Cli_Nombre and Tarjeta_Numero is not null

/* CUENTAS */ 
/* VER QUE FECHA CREACION ESTA HARDCODEADO PORQUE EN TABLA MAESTRA LA FECHA NO ES COHERENTE */
Insert into DEVGURUS.Cuentas (Cuenta_Nro, Cuenta_Tipo, Cuenta_PaisOrigen, Cuenta_PaisAsignado, Cuenta_Fec_Cre, Cuenta_Cliente, Cuenta_Saldo)
select distinct MA.Cuenta_Numero, 4, MA.Cuenta_Pais_Codigo, MA.Cli_Pais_Codigo, DATEADD(DAY, -5, GETDATE()), CL.Cliente_Id, 0
from gd_esquema.Maestra MA, DEVGURUS.Clientes CL
where CL.Cliente_Nro_Doc= MA.Cli_Nro_Doc and MA.Cuenta_Numero is not null
/*
select * from gd_esquema.Maestra where Cuenta_Numero = Cuenta_Dest_Numero
*/
--select distinct Cuenta_Dest_Numero,,Cuenta_Dest_Pais_Codigo,Cuenta_Pais_Codigo from gd_esquema.Maestra where Cuenta_Dest_Numero is not null and Cuenta_Numero =  Cuenta_Dest_Numero
/*
Insert into Cuentas (Cuenta_Nro, Cuenta_Tipo, Cuenta_PaisOrigen, Cuenta_PaisAsignado, Cuenta_Fec_Cre, Cuenta_Cliente, Cuenta_Saldo)
select distinct MA.Cuenta_Dest_Numero, 4, MA.Cuenta_Dest_Pais_Codigo, MA.Cli_Pais_Codigo, DATEADD(DAY, -5, GETDATE()), CL.Cliente_Id, 0
from gd_esquema.Maestra MA, Clientes CL
where CL.Cliente_Nombre = MA.Cli_Nombre and CL.Cliente_Apellido = MA.Cli_Apellido and MA.Cuenta_Numero is not null
*/
update DEVGURUS.Cuentas
set Cuenta_Fec_Cierre = DATEADD(day, 15, Cuenta_Fec_Cre)
		
/* DEPOSTIOS */
Insert into DEVGURUS.Depositos (Deposito_Id, Deposito_Fecha, Deposito_Importe, Deposito_TipoMoneda, Deposito_Cuenta, Deposito_Tarjeta)
select distinct MA.Deposito_Codigo, MA.Deposito_Fecha, MA.Deposito_Importe, NULL, MA.Cuenta_Numero, TA.Tarjeta_Id from gd_esquema.Maestra MA, DEVGURUS.Tarjetas TA
where TA.Tarjeta_Nro = MA.Tarjeta_Numero and Deposito_Codigo is not null

/* FACTURAS */
Insert into DEVGURUS.Facturas (Factura_Numero, Factura_Fecha, Factura_Cliente, Factura_Importe)
select distinct MA.Factura_Numero, MA.Factura_Fecha, CL.Cliente_Id, 0 from gd_esquema.Maestra MA, DEVGURUS.Clientes CL
where CL.Cliente_Nombre = MA.Cli_Nombre and CL.Cliente_Apellido = MA.Cli_Apellido
and MA.Factura_Numero is not null
		/* QUEDA PENDIENTE SUMAR EL IMPORTE PERO SE PUEDE REALIZAR AL MOMENTO DE LA CONSULTA */

/* ITEMS */
Insert into DEVGURUS.Items (Items_Descripcion, Items_Importe, Items_Factura)
select MA.Item_Factura_Descr, MA.Item_Factura_Importe, FA.Factura_Numero from gd_esquema.Maestra MA, DEVGURUS.Facturas FA
where MA.Factura_Numero = FA.Factura_Numero

/* TRANSFERENCIA */
Insert into DEVGURUS.Transferencia (Transferencia_Fecha, Transferencia_Importe, Transferencia_Costo_Transf, Transferencia_Cuenta_Emisora, Transferencia_Cuenta_Destino)
select  MA.Transf_Fecha, MA.Trans_Importe, MA.Trans_Costo_Trans, MA.Cuenta_Numero, MA.Cuenta_Dest_Numero from gd_esquema.Maestra MA
where MA.Cuenta_Dest_Numero is not null and MA.Cuenta_Numero is not null

/* BANCOS */
Insert into DEVGURUS.Bancos (Banco_Id, Banco_Nombre, Banco_Direccion)
select distinct Banco_Cogido, Banco_Nombre, Banco_Direccion from gd_esquema.Maestra
where Banco_Cogido is not null

/* CHEQUES */
Insert into DEVGURUS.Cheques (Cheque_Id, Cheque_Fecha, Cheque_Importe, Cheque_Banco)
select distinct Cheque_Numero, Cheque_Fecha, Cheque_Importe, Banco_Cogido from gd_esquema.Maestra
where Cheque_Numero is not null

/* RETIROS */
/* LA FECHA DE LA TABLA MAESTRA ES CUALQUIER COSA */
Insert into DEVGURUS.Retiros (Retiro_Id, Retiro_Fecha, Retiro_Importe, Retiro_Cuenta, Retiro_Cheque)
select distinct Retiro_Codigo, Retiro_Fecha, Retiro_Importe, Cuenta_Numero, Cheque_Numero from gd_esquema.Maestra
where Retiro_Codigo is not null

/* CARGA DE USUARIOS PARA PRUEBAS DE DESARROLLO */
Insert into DEVGURUS.Usuarios (Usuarios_Name, Usuarios_Pass, Usuarios_FechaCreacion, Usuarios_FechaUltimaModificacion, Usuarios_PreguntaSecreta, Usuarios_RespuestaSecreta)
values	('admin', 'w23e', GETDATE(), GETDATE(), '¿Pais de origen?', 'Argentina')
insert into DEVGURUS.Rol_X_Usuario values (166, 3)

COMMIT TRAN InicializacionDeDatos


/* ******************************************************************************************************************** */
/* ***************************************** Procedures y triggers **************************************************** */

IF EXISTS (SELECT id FROM sys.sysobjects WHERE name = 'logearse')
	DROP PROCEDURE DEVGURUS.logearse;
GO

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