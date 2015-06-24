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
Print 'La tabla PAISES se ha creado con exito';

/* 	TABLA: Tipo_De_Doc
	DESCRIPCION: Datos de los Tipos de documentos con su correspondiente Id proveniente del Maestro
*/
Create Table DEVGURUS.Tipo_De_Doc (	Tipo_Doc_Id numeric (18,0) PRIMARY KEY NOT NULL,
									Tipo_Doc_Desc varchar(255) NOT NULL)
Print 'La tabla TIPO DE DOCUMENTOS se ha creado con exito';

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
Print 'La tabla ROLES se ha creado con exito';
	
/* 	TABLA: Usuarios
	DESCRIPCION: Creacion de los Usuarios en base a los datos de clientes de la tabla maestra
*/	
Create Table DEVGURUS.Usuarios	(	Usuarios_Id integer identity (1,1) PRIMARY KEY NOT NULL,
									Usuarios_Estado varchar(255) default 'Habilitado',
									Usuarios_Name varchar(255) UNIQUE NOT NULL,
									Usuarios_Pass varchar(255) NOT NULL,
									Usuarios_FechaCreacion datetime NOT NULL,
									Usuarios_FechaUltimaModificacion datetime NOT NULL,
									Usuarios_PreguntaSecreta varchar(255) NOT NULL,
									Usuarios_RespuestaSecreta varchar (255) NOT NULL)
Print 'La tabla USUARIOS se ha creado con exito';

/* 	TABLA: Rol_X_Usuario
	DESCRIPCION: Tabla que relaciona los Roles con los Usuarios (relacion muchos a muchos)
*/							
Create Table DEVGURUS.Rol_X_Usuario(	Rol_X_Usuario_Usuario integer NOT NULL FOREIGN KEY REFERENCES DEVGURUS.Usuarios(Usuarios_Id),
										Rol_X_Usuario_Rol tinyint NOT NULL FOREIGN KEY REFERENCES DEVGURUS.Roles(Rol_Id),
										CONSTRAINT Pk_Rol_X_Usuario PRIMARY KEY (Rol_X_Usuario_Usuario,Rol_X_Usuario_Rol))
Print 'La tabla ROL X USUARIOS se ha creado con exito';

/* 	TABLA: Clientes
	DESCRIPCION: Creada a partir de los clientes de la tabla maestra
*/	
Create Table DEVGURUS.Clientes (	Cliente_Id integer identity (1,1) PRIMARY KEY NOT NULL,
									Cliente_Nombre varchar(255),
									Cliente_Estado varchar(255) default 'Habilitado',
									Cliente_Apellido varchar(255),
									Cliente_Tipo_Doc numeric (18,0) FOREIGN KEY REFERENCES DEVGURUS.Tipo_De_Doc(Tipo_Doc_Id),
									Cliente_Nro_Doc integer,
									Cliente_Nacionalidad varchar(255),
									Cliente_Pais numeric (18,0) FOREIGN KEY REFERENCES DEVGURUS.Paises(Pais_Id),
									Cliente_Localidad varchar(255),
									Cliente_Dom_Calle varchar(255),
									Cliente_Dom_Nro numeric(18,0),
									Cliente_Dom_Piso numeric(18,0),
									Cliente_Dom_Depto varchar(10),
									Cliente_Fecha_Nac datetime,
									Cliente_Mail varchar(255),
									Cliente_User integer FOREIGN KEY REFERENCES DEVGURUS.Usuarios(Usuarios_ID) unique)
Print 'La tabla CLIENTES se ha creado con exito';

/* 	TABLA: Tipo_De_Cuentas
	DESCRIPCION: Tabla con tipos de cuentas (Inventadas)
*/
Create Table DEVGURUS.Tipo_De_Cuentas(	Tipo_De_Cuentas_Id tinyint identity (1,1) PRIMARY KEY,
										Tipo_De_Cuentas_Nombre varchar(255),
										Tipo_De_Cuentas_Duracion_Dias smallint,
										Tipo_De_Cuentas_Costo numeric (18,2))
Print 'La tabla TIPO DE CUENTAS se ha creado con exito';

/* 	TABLA: Tarjetas
	DESCRIPCION: Tabla migrada de la tabla maestra con los datos de las tarjetas
*/
Create Table DEVGURUS.Tarjetas (		Tarjeta_Id integer IDENTITY (1,1) PRIMARY KEY NOT NULL,
										Tarjeta_Nro varchar(16)  NOT NULL,
										Tarjeta_Cliente integer FOREIGN KEY REFERENCES DEVGURUS.Clientes(Cliente_Id),
										Tarjeta_Digitos_Visibles varchar(4),
										Tarjeta_Fecha_Emision datetime,
										Tarjeta_Fecha_Vencimiento datetime,
										Tarjeta_Cod_Seg varchar(3),
										Tarjeta_Emisor_Desc varchar (255),
										Tarjeta_Asociada varchar(25) default 'Asociada')
Print 'La tabla TARJETAS se ha creado con exito';

/* 	TABLA: Tipo_De_Moneda
	DESCRIPCION: Tipo de monedas presentes en la tabla maestra
*/						
Create Table DEVGURUS.Tipo_De_Moneda(	Tipo_De_Moneda_Id tinyint identity (1,1) PRIMARY KEY,
										Tipo_De_Moneda_Nombre varchar(255))
Print 'La tabla TIPO DE MONEDA se ha creado con exito';

/* 	TABLA: Cuentas
	DESCRIPCION: Tabla con todas las cuentas presentes en la tabla maestra
*/
Create Table DEVGURUS.Cuentas (		Cuenta_Nro numeric (18,0) PRIMARY KEY NOT NULL,
									Cuenta_Estado varchar(255) default 'Habilitado',
									Cuenta_Moneda tinyint FOREIGN KEY REFERENCES DEVGURUS.Tipo_De_Moneda(Tipo_De_Moneda_Id) default 1,
									Cuenta_Tipo tinyint FOREIGN KEY REFERENCES DEVGURUS.Tipo_De_Cuentas(Tipo_De_Cuentas_Id),
									Cuenta_PaisOrigen numeric (18,0) FOREIGN KEY REFERENCES DEVGURUS.Paises(Pais_Id),
									Cuenta_PaisAsignado numeric (18,0) FOREIGN KEY REFERENCES DEVGURUS.Paises(Pais_Id),
									Cuenta_Fec_Cre datetime,
									Cuenta_Fec_Cierre datetime,
									Cuenta_Cliente integer FOREIGN KEY REFERENCES DEVGURUS.Clientes(Cliente_Id),
									Cuenta_Saldo float default 0)
Print 'La tabla CUENTAS se ha creado con exito';

/* 	TABLA: Depositos
	DESCRIPCION: Tabla con Depositos cargados desde la tabla maestra
*/														
Create Table DEVGURUS.Depositos (	Deposito_Id numeric (18,0) PRIMARY KEY NOT NULL,
									Deposito_Fecha datetime,
									Deposito_Importe numeric (18,2) check (Deposito_Importe >= 1),
									Deposito_TipoMoneda varchar(255),
									Deposito_Cuenta numeric (18,0) FOREIGN KEY REFERENCES DEVGURUS.Cuentas(Cuenta_Nro),
									Deposito_Tarjeta integer FOREIGN KEY REFERENCES DEVGURUS.Tarjetas(Tarjeta_Id))
Print 'La tabla DEPOSITOS se ha creado con exito';

/* 	TABLA: Facturas
	DESCRIPCION: Tabla con las facturas a cobrar a clientes
*/	
Create Table DEVGURUS.Facturas	(	Factura_Numero numeric (18,0) PRIMARY KEY NOT NULL,
									Factura_Fecha datetime,
									Factura_Descripcion varchar(255),
									Factura_Importe numeric(18,2),
									Factura_Cliente integer FOREIGN KEY REFERENCES DEVGURUS.Clientes(Cliente_Id))
Print 'La tabla FACTURAS se ha creado con exito';

/* 	TABLA: Items
	DESCRIPCION: Tabla con los Items pertenecientes a las facturas
*/								
Create Table DEVGURUS.Items	(		Items_Numero integer identity(1,1) PRIMARY KEY NOT NULL,
									Items_Descripcion varchar(255),
									Items_Importe numeric(18,2),
									Items_Factura numeric (18,0) FOREIGN KEY REFERENCES DEVGURUS.Facturas(Factura_Numero))
Print 'La tabla ITEMS se ha creado con exito';

/* 	TABLA: Transferencia
	DESCRIPCION: Tabla con los Transferencias migradas desde el maestro
*/	
Create Table DEVGURUS.Transferencia (Transferencia_Id integer identity(1,1) PRIMARY KEY NOT NULL,
									Transferencia_Fecha datetime,
									Transferencia_Importe numeric (18,2),
									Transferencia_Costo_Transf numeric (18,2),
									Transferencia_Cuenta_Emisora numeric (18,0) FOREIGN KEY REFERENCES DEVGURUS.Cuentas(Cuenta_Nro),
									Transferencia_Cuenta_Destino numeric (18,0) FOREIGN KEY REFERENCES DEVGURUS.Cuentas(Cuenta_Nro))
Print 'La tabla TRANSFERENCIA se ha creado con exito';

/* 	TABLA: Bancos
	DESCRIPCION: Tabla que contiene todos los bancos presentes en la tabla maestra
*/	
Create Table DEVGURUS.Bancos	(	Banco_Id numeric (18,0) PRIMARY KEY NOT NULL,
									Banco_Nombre varchar(255),
									Banco_Direccion varchar(255))
Print 'La tabla BANCOS se ha creado con exito';

/* 	TABLA: Cheques
	DESCRIPCION: Tabla que contiene todos los cheques presentes en la tabla maestra
*/								
Create Table DEVGURUS.Cheques	(	Cheque_Id numeric (18,0) PRIMARY KEY NOT NULL,
									Cheque_Fecha datetime,
									Cheque_Importe numeric (18,2),
									Cheque_Banco numeric (18,0) FOREIGN KEY REFERENCES DEVGURUS.Bancos(Banco_Id))
Print 'La tabla CHEQUES se ha creado con exito';

/* 	TABLA: Retiros
	DESCRIPCION: Tabla que contiene todos los Retiros presentes en la tabla maestra
*/															
Create Table DEVGURUS.Retiros	(	Retiro_Id numeric (18,0) PRIMARY KEY NOT NULL,
									Retiro_Fecha datetime,
									Retiro_Importe numeric (18,2),
									Retiro_Cuenta numeric (18,0) FOREIGN KEY REFERENCES DEVGURUS.Cuentas(Cuenta_Nro),
									Retiro_Cheque numeric (18,0) FOREIGN KEY REFERENCES DEVGURUS.Cheques(Cheque_Id))
Print 'La tabla RETIROS se ha creado con exito';

/* 	TABLA: Transaccion_Pendiente
	DESCRIPCION: Tabla creada para almacenar transacciones pendientes de pago
*/						
Create Table DEVGURUS.Transaccion_Pendiente	(	Transaccion_Pendiente_Id integer identity (1,1) PRIMARY KEY NOT NULL,
												Transaccion_Pendiente_Importe numeric (18,2),
												Transaccion_Pendiente_Descr varchar(255),
												Transaccion_Pendiente_Cliente integer FOREIGN KEY REFERENCES DEVGURUS.Clientes(Cliente_Id),
												Transaccion_Pendiente_Fecha datetime,
												Transaccion_Pendiente_Cuenta_Nro numeric (18,0) FOREIGN KEY REFERENCES DEVGURUS.Cuentas(Cuenta_Nro))			
Print 'La tabla TRANSACCIONES PENDIENTES se ha creado con exito';

/* 	TABLA: Login Incorrecto
	DESCRIPCION: Tabla creada para almacenar los logeos incorrectos
*/							
Create Table DEVGURUS.Login_Incorrecto	(	Login_Incorrecto_Id integer identity (1,1) Primary key,
											Login_Incorrecto_User integer foreign key references DEVGURUS.Usuarios(Usuarios_Id),
											Login_Incorrecto_Pass varchar (255),
											Login_Incorrecto_Intento tinyint,
											Login_Incorrecto_Fecha datetime)
Print 'La tabla LOGIN INCORRECTOS se ha creado con exito';

/* 	TABLA: LoginAuditoria
	DESCRIPCION: Tabla creada para almacenar los logeos incorrectos, fallidos y correctos
*/									
Create Table DEVGURUS.Login_Auditoria	(	Login_Auditoria_Id integer identity (1,1) Primary key,
											Login_Auditoria_Ingresado varchar(255),
											Login_Auditoria_Fecha datetime,
											Login_Auditoria_Tipo varchar(25),
											Login_Auditoria_Intento tinyint)
Print 'La tabla LOGIN AUDITORIA se ha creado con exito';						
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
update DEVGURUS.Paises
set Pais_Nombre = STUFF(Pais_Nombre, CHARINDEX(' ', Pais_Nombre), 1, '')
where Pais_Nombre like ' %'

Print 'La tabla PAISES se ha cargado con exito';

/*TIPOS DE MONEDA*/
Insert into DEVGURUS.Tipo_De_Moneda(Tipo_De_Moneda_Nombre) values ('Dolar');
Print 'La tabla TIPO DE MONEDAS se ha cargado con exito';

/* TIPOS DE DOCUMENTO */
Insert into DEVGURUS.Tipo_De_Doc (Tipo_Doc_Id, Tipo_Doc_Desc) select distinct Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc from gd_esquema.Maestra
Print 'La tabla TIPOS DE DOCUMENTOS se ha cargado con exito';

/* ROLES */
Insert into DEVGURUS.Roles (Rol_Desc, Rol_Estado, Func_Extraer, Func_Transferir, Func_Depositar, Func_ABM_Roles, Func_ABM_Clientes, Func_ABM_Usuarios, Func_ABM_Cuentas, Func_Asociar_Tarjeta)
values	('Administrador', 'Activo', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Inhabilitado'),
		('Cliente', 'Activo', 'Habilitado', 'Habilitado', 'Habilitado', 'Inhabilitado', 'Inhabilitado', 'Inhabilitado', 'Inhabilitado', 'Habilitado'),
		('Administrador General', 'Activo', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado')
Print 'La tabla ROLES se ha cargado con exito';

/* USUARIOS */
Insert into DEVGURUS.Usuarios (Usuarios_Name, Usuarios_Pass, Usuarios_FechaCreacion, Usuarios_FechaUltimaModificacion, Usuarios_PreguntaSecreta, Usuarios_RespuestaSecreta)
select distinct REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Cli_Apellido +  CAST  (Cli_Nro_Doc AS varchar(255)), 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u'), 
SUBSTRING(Cli_Apellido, 1, 1)+SUBSTRING(Cli_Apellido, 1, 1)+SUBSTRING(Cli_Apellido, 1, 1)+SUBSTRING(Cli_Apellido, 1, 1)+'4321',
GETDATE(), GETDATE(), '¿En que pais naciste?', Cli_Pais_Desc from gd_esquema.Maestra
Print 'La tabla USUARIOS se ha cargado con exito';

/* ROL_X_USUARIO */
Insert into DEVGURUS.Rol_X_Usuario (Rol_X_Usuario_Usuario, Rol_X_Usuario_Rol)
select US.Usuarios_Id, RO.Rol_Id from DEVGURUS.Usuarios US, DEVGURUS.Roles RO
where RO.Rol_Desc = 'Cliente'
Print 'La tabla ROLES X USUARIOS se ha cargado con exito';

/* CLIENTES */
Insert into DEVGURUS.Clientes(	Cliente_Nombre, Cliente_Apellido, Cliente_Tipo_Doc, Cliente_Pais, 
						Cliente_Dom_Calle, Cliente_Dom_Nro, Cliente_Dom_Piso, Cliente_Dom_Depto, 
						Cliente_Fecha_Nac, Cliente_Mail, Cliente_User,Cliente_Nro_Doc)
						select distinct MA.Cli_Nombre, MA.Cli_Apellido, MA.Cli_Tipo_Doc_Cod, 
						MA.Cli_Pais_Codigo, MA.Cli_Dom_Calle, MA.Cli_Dom_Nro, MA.Cli_Dom_Piso, MA.Cli_Dom_Depto, 
						MA.Cli_Fecha_Nac, MA.Cli_Mail, US.Usuarios_Id,MA.Cli_Nro_Doc from gd_esquema.Maestra MA, DEVGURUS.Usuarios US
						where US.Usuarios_Name = REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Cli_Apellido +  CAST  (Cli_Nro_Doc AS varchar(255)), 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u')
Print 'La tabla CLIENTES se ha cargado con exito';

/* TIPO_DE_CUENTAS */
Insert into DEVGURUS.Tipo_De_Cuentas (Tipo_De_Cuentas_Nombre, Tipo_De_Cuentas_Duracion_Dias, Tipo_De_Cuentas_Costo)
values	('Oro', 100, 29.99),
		('Plata', 60, 19.99),
		('Bronce', 30, 12.53),
		('Gratuita', 15, 0.00)
Print 'La tabla TIPOS DE CUENTA se ha cargado con exito';

/* TARJETAS */
/* LAS FECHAS SON FUTURICAS */
Insert into DEVGURUS.Tarjetas (Tarjeta_Nro, Tarjeta_Cliente, Tarjeta_Digitos_Visibles, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, Tarjeta_Cod_Seg, Tarjeta_Emisor_Desc)
select distinct MA.Tarjeta_Numero, CL.Cliente_Id, RIGHT(MA.Tarjeta_Numero,4), MA.Tarjeta_Fecha_Emision, MA.Tarjeta_Fecha_Vencimiento, MA.Tarjeta_Codigo_Seg, 
MA.Tarjeta_Emisor_Descripcion from gd_esquema.Maestra MA, DEVGURUS.Clientes CL
where CL.Cliente_Apellido+CL.Cliente_Nombre = MA.Cli_Apellido+MA.Cli_Nombre and Tarjeta_Numero is not null
Print 'La tabla TARJETAS se ha cargado con exito';

/* CUENTAS */ 
/* VER QUE FECHA CREACION ESTA HARDCODEADO PORQUE EN TABLA MAESTRA LA FECHA NO ES COHERENTE */
Insert into DEVGURUS.Cuentas (Cuenta_Nro, Cuenta_Tipo, Cuenta_PaisOrigen, Cuenta_PaisAsignado, Cuenta_Fec_Cre, Cuenta_Cliente, Cuenta_Saldo)
select distinct MA.Cuenta_Numero, 4, MA.Cuenta_Pais_Codigo, MA.Cli_Pais_Codigo, DATEADD(DAY, -5, GETDATE()), CL.Cliente_Id, 0
from gd_esquema.Maestra MA, DEVGURUS.Clientes CL
where CL.Cliente_Nro_Doc= MA.Cli_Nro_Doc and MA.Cuenta_Numero is not null

update DEVGURUS.Cuentas
set Cuenta_Fec_Cierre = DATEADD(day, 15, Cuenta_Fec_Cre)

Print 'La tabla CUENTAS se ha cargado con exito';

/* DEPOSTIOS */
Insert into DEVGURUS.Depositos (Deposito_Id, Deposito_Fecha, Deposito_Importe, Deposito_TipoMoneda, Deposito_Cuenta, Deposito_Tarjeta)
select distinct MA.Deposito_Codigo, MA.Deposito_Fecha, MA.Deposito_Importe, NULL, MA.Cuenta_Numero, TA.Tarjeta_Id from gd_esquema.Maestra MA, DEVGURUS.Tarjetas TA
where TA.Tarjeta_Nro = MA.Tarjeta_Numero and Deposito_Codigo is not null
Print 'La tabla DEPOSITOS se ha cargado con exito';

/* FACTURAS */
Insert into DEVGURUS.Facturas (Factura_Numero, Factura_Fecha, Factura_Cliente, Factura_Importe)
select distinct MA.Factura_Numero, MA.Factura_Fecha, CL.Cliente_Id, 0 from gd_esquema.Maestra MA, DEVGURUS.Clientes CL
where CL.Cliente_Nombre = MA.Cli_Nombre and CL.Cliente_Apellido = MA.Cli_Apellido
and MA.Factura_Numero is not null
Print 'La tabla FACTURAS se ha cargado con exito';

/* ITEMS */
Insert into DEVGURUS.Items (Items_Descripcion, Items_Importe, Items_Factura)
select MA.Item_Factura_Descr, MA.Item_Factura_Importe, FA.Factura_Numero from gd_esquema.Maestra MA, DEVGURUS.Facturas FA
where MA.Factura_Numero = FA.Factura_Numero
Print 'La tabla ITEMS se ha cargado con exito';

/* TRANSFERENCIA */
Insert into DEVGURUS.Transferencia (Transferencia_Fecha, Transferencia_Importe, Transferencia_Costo_Transf, Transferencia_Cuenta_Emisora, Transferencia_Cuenta_Destino)
select  MA.Transf_Fecha, MA.Trans_Importe, MA.Trans_Costo_Trans, MA.Cuenta_Numero, MA.Cuenta_Dest_Numero from gd_esquema.Maestra MA
where MA.Cuenta_Dest_Numero is not null and MA.Cuenta_Numero is not null
Print 'La tabla TRANSFERENCIAS se ha cargado con exito';

/* BANCOS */
Insert into DEVGURUS.Bancos (Banco_Id, Banco_Nombre, Banco_Direccion)
select distinct Banco_Cogido, Banco_Nombre, Banco_Direccion from gd_esquema.Maestra
where Banco_Cogido is not null
Print 'La tabla BANCOS se ha cargado con exito';

/* CHEQUES */
Insert into DEVGURUS.Cheques (Cheque_Id, Cheque_Fecha, Cheque_Importe, Cheque_Banco)
select distinct Cheque_Numero, Cheque_Fecha, Cheque_Importe, Banco_Cogido from gd_esquema.Maestra
where Cheque_Numero is not null
Print 'La tabla CHEQUES se ha cargado con exito';

/* RETIROS */
/* LA FECHA DE LA TABLA MAESTRA ES CUALQUIER COSA */
Insert into DEVGURUS.Retiros (Retiro_Id, Retiro_Fecha, Retiro_Importe, Retiro_Cuenta, Retiro_Cheque)
select distinct Retiro_Codigo, Retiro_Fecha, Retiro_Importe, Cuenta_Numero, Cheque_Numero from gd_esquema.Maestra
where Retiro_Codigo is not null
Print 'La tabla RETIROS se ha cargado con exito';

COMMIT TRAN InicializacionDeDatos


/* ******************************************************************************************************************** */
/* ***************************************** Procedures y triggers **************************************************** */

BEGIN TRAN InicializacionDeProcedures

/* EL PROCEDIMIENTO ACTUALIZA LOS DATOS DE UN CLIENTE UTILIZANDO UN UPDATE */
IF EXISTS (SELECT id FROM sys.sysobjects WHERE name = 'actualizar_cliente')
	DROP PROCEDURE DEVGURUS.actualizar_cliente;
	Print 'El procedimiento ACTUALIZAR CLIENTE ya existe, SE BORRARA';
GO

CREATE PROCEDURE DEVGURUS.actualizar_cliente
	@id_cliente int,@nombre varchar(255),@estado varchar(255),@apellido varchar(255),
	 @tipo_doc varchar(255), @nro_doc int,@nacionalidad varchar(255),@pais varchar(255), @localidad varchar(255),
	@Dom_Calle varchar(255), @Dom_Nro numeric(18,0),@Dom_Piso numeric(18,0), @Dom_Depto varchar(10),@Mail varchar(255)

AS
	declare @tipo_documento_id int
	select @tipo_documento_id = Tipo_Doc_Id from DEVGURUS.Tipo_De_Doc where @tipo_doc = Tipo_Doc_Desc;
	declare @pais_id int
	select  @pais_id = Pais_Id from DEVGURUS.Paises where Pais_Nombre=@pais;

	UPDATE DEVGURUS.Clientes
   SET [Cliente_Nombre] = @nombre
	  ,[Cliente_Estado]= @estado
      ,[Cliente_Apellido] = @apellido
      ,[Cliente_Tipo_Doc] = @tipo_documento_id
      ,[Cliente_Nro_Doc] =  @nro_doc 
      ,[Cliente_Nacionalidad] = @nacionalidad
      ,[Cliente_Pais] = @pais_id 
      ,[Cliente_Localidad] = @localidad
      ,[Cliente_Dom_Calle] = @Dom_Calle
      ,[Cliente_Dom_Nro] = @Dom_Nro
      ,[Cliente_Dom_Piso] = @Dom_Piso
      ,[Cliente_Dom_Depto] = @Dom_Depto
      ,[Cliente_Mail] = @Mail

WHERE @id_cliente = Cliente_Id
GO
Print 'El procedimiento ACTUALIZAR CLIENTE se ha creado correctamente';



/* EL PROCEDIMIENTO ASIGNA LOGICAMENTE ITEMS A UNA FACTURA */
IF EXISTS (SELECT id FROM sys.sysobjects WHERE name = 'asignar_Item_A_Factura')
	DROP PROCEDURE DEVGURUS.asignar_Item_A_Factura;
	Print 'El procedimiento ASIGNAR ITEM A FACTURA ya existe, SE BORRARA';
GO

CREATE PROCEDURE DEVGURUS.asignar_Item_A_Factura
	@numero_Factura numeric(18,0),
	@numero_Item int
AS
	DECLARE @items_Desc varchar(255)
	DECLARE @importe numeric(18,2)	
		
	SET @items_Desc = (SELECT Transaccion_Pendiente_Descr FROM DEVGURUS.Transaccion_Pendiente WHERE 
	Transaccion_Pendiente_Id = @numero_Item)
	SET @importe = (SELECT Transaccion_Pendiente_Importe FROM DEVGURUS.Transaccion_Pendiente WHERE 
	Transaccion_Pendiente_Id = @numero_Item)
	
	insert into DEVGURUS.Items (Items_Descripcion, Items_Importe, Items_Factura)
	values (@items_Desc, @importe, @numero_Factura)
	
	update DEVGURUS.Facturas set Factura_Importe = Factura_Importe + @importe
	where Factura_Numero = @numero_Factura
	
	delete from DEVGURUS.Transaccion_Pendiente
	where Transaccion_Pendiente_Id = @numero_Item
GO	
	Print 'El procedimiento ASIGNAR ITEM A FACTURA se ha creado correctamente';



/* EL PROCEDIMIENTO ADMINISTRA LA ENTRADA DEL USUARIO AL SISTEMA */
IF EXISTS (SELECT id FROM sys.sysobjects WHERE name = 'logearse')
	DROP PROCEDURE DEVGURUS.logearse;
	Print 'El procedimiento LOGEARSE ya existe, SE BORRARA';
GO

CREATE PROCEDURE DEVGURUS.logearse
	@rol varchar (255),
	@usuario varchar (255),
	@password varchar (255)
AS
	DECLARE @rol_Id tinyint
	DECLARE @usuario_Id int
	DECLARE @usuario_Pass varchar (255)
	DECLARE @nro_Intento tinyint
	DECLARE @validation_Rol int
	DECLARE @estatus_Usuario varchar (255)
	
	SET @rol_Id = (SELECT Rol_Id FROM DEVGURUS.Roles WHERE Rol_Desc = @rol)
	SET @usuario_Id = (SELECT Usuarios_Id FROM DEVGURUS.Usuarios WHERE Usuarios_Name = @usuario)
	SET @usuario_Pass = (SELECT Usuarios_Pass FROM DEVGURUS.Usuarios WHERE Usuarios_Name = @usuario)
	SET @nro_Intento = (SELECT MAX(LO.Login_Incorrecto_Intento) FROM DEVGURUS.Login_Incorrecto LO WHERE 
	@usuario_Id = LO.Login_Incorrecto_User)
	SET @validation_Rol = (SELECT Rol_X_Usuario_Usuario from DEVGURUS.Rol_X_Usuario where 
	Rol_X_Usuario_Usuario = @usuario_Id and Rol_X_Usuario_Rol = @rol_Id)
	SET @estatus_Usuario = (SELECT Usuarios_Estado from DEVGURUS.Usuarios where Usuarios_Id = @usuario_Id)

	
	IF (@estatus_Usuario = 'Pendiente')
	BEGIN
	select 'No aprobado' MENSAJE
	END
	
	IF (@usuario_Id is null)
	BEGIN
	select 'No existe' MENSAJE
	insert into DEVGURUS.Login_Auditoria (Login_Auditoria_Ingresado, Login_Auditoria_Fecha, Login_Auditoria_Tipo)
	values (@usuario, GETDATE(), 'Incorrecto')
	END
	
	ELSE IF (@validation_Rol is null)
	BEGIN
	select 'No rol valido' MENSAJE
	insert into DEVGURUS.Login_Auditoria (Login_Auditoria_Ingresado, Login_Auditoria_Fecha, Login_Auditoria_Tipo)
	values (@usuario, GETDATE(), 'Incorrecto')
	END
	
	ELSE IF (@nro_Intento = 3)
	BEGIN
	select 'Bloqueado' MENSAJE
	insert into DEVGURUS.Login_Auditoria (Login_Auditoria_Ingresado, Login_Auditoria_Fecha, Login_Auditoria_Tipo, Login_Auditoria_Intento)
	values (@usuario, GETDATE(), 'Fallido', @nro_Intento + 1)
	END
	
	ELSE IF (@usuario_Pass <> @password)
	BEGIN
	select 'Incorrecto' MENSAJE
	
		IF (@nro_Intento is null)
		BEGIN
		insert into DEVGURUS.Login_Incorrecto (Login_Incorrecto_User, Login_Incorrecto_Pass, Login_Incorrecto_Intento, Login_Incorrecto_Fecha)
		values (@usuario_Id, @password, 1, GETDATE())
		insert into DEVGURUS.Login_Auditoria (Login_Auditoria_Ingresado, Login_Auditoria_Fecha, Login_Auditoria_Tipo, Login_Auditoria_Intento)
		values (@usuario, GETDATE(), 'Fallido', 1)
		END
		ELSE
		BEGIN
		insert into DEVGURUS.Login_Incorrecto (Login_Incorrecto_User, Login_Incorrecto_Pass, Login_Incorrecto_Intento, Login_Incorrecto_Fecha)
		values (@usuario_Id, @password, @nro_Intento + 1, GETDATE())
		insert into DEVGURUS.Login_Auditoria (Login_Auditoria_Ingresado, Login_Auditoria_Fecha, Login_Auditoria_Tipo, Login_Auditoria_Intento)
		values (@usuario, GETDATE(), 'Fallido', @nro_Intento + 1)
		END
	END
	
	ELSE
	BEGIN
	select 'Correcto' MENSAJE
	insert into DEVGURUS.Login_Auditoria (Login_Auditoria_Ingresado, Login_Auditoria_Fecha, Login_Auditoria_Tipo)
	values (@usuario, GETDATE(), 'Correcto')
	delete from DEVGURUS.Login_Incorrecto where Login_Incorrecto_User = @usuario_Id
	END
GO	
	Print 'El procedimiento LOGEARSE se ha creado correctamente';



/* EL TRIGGER GENERA REGISTROS EN LA TABLA TRANSACCIONES PENDIENTES*/
IF EXISTS (SELECT id FROM sys.sysobjects WHERE name = 'insertAperturasPendientes')
	DROP TRIGGER DEVGURUS.insertAperturasPendientes;
	Print 'El trigger INSERTAR APERTURAS PENDIENTES ya existe, SE BORRARA';
GO

CREATE trigger DEVGURUS.insertAperturasPendientes
ON DEVGURUS.Cuentas
AFTER insert
AS
BEGIN

DECLARE @Apertura_Tipo_Cuenta tinyint
DECLARE	@Apertura_Tipo_Cuenta_Costo numeric(18,2)
DECLARE @Apertura_Cliente int
DECLARE @Apertura_Cuenta_Nro numeric(18,0)

SET @Apertura_Tipo_Cuenta = (select Cuenta_Tipo from inserted)
SET @Apertura_Tipo_Cuenta_Costo = (select Tipo_De_Cuentas_Costo from DEVGURUS.Tipo_De_Cuentas 
where Tipo_De_Cuentas_Id = @Apertura_Tipo_Cuenta)
SET @Apertura_Cliente = (select Cuenta_Cliente from inserted)
SET @Apertura_Cuenta_Nro = (select Cuenta_Nro from inserted)

insert into DEVGURUS.Transaccion_Pendiente (Transaccion_Pendiente_Importe, Transaccion_Pendiente_Descr,
Transaccion_Pendiente_Cliente, Transaccion_Pendiente_Fecha, Transaccion_Pendiente_Cuenta_Nro)
values (@Apertura_Tipo_Cuenta_Costo, 'Apertura', @Apertura_Cliente,
GETDATE(), @Apertura_Cuenta_Nro)

END
GO
	Print 'El trigger INSERTAR APERTURAS PENDIENTES se ha creado correctamente';



/* EL PROCEDIMIENTO GENERA REGISTROS EN LA TABLA CUENTAS*/
IF EXISTS (SELECT id FROM sys.sysobjects WHERE name = 'insertarEnCuentas')
	DROP PROCEDURE DEVGURUS.insertarEnCuentas;
	Print 'El procedimiento INSERTAR EN CUENTAS ya existe, SE BORRARA';
GO

create procedure DEVGURUS.insertarEnCuentas
		@Cuenta_PaisOrigen varchar(255),
		@Cuenta_Estado varchar(255),
		@Cuenta_Moneda varchar(255),
		@Cuenta_Tipo varchar(255),
		@Cuenta_PaisAsignado numeric (18,0),
		@Cuenta_Fec_Cierre datetime,
		@Cuenta_Cliente integer
AS
		Declare @Cuenta_Fec_Cre datetime = GETDATE()
		Declare @pais_id int
		select @pais_id = Pais_Id from DEVGURUS.Paises where Pais_Nombre = @Cuenta_PaisOrigen 
		Declare @tipo_moneda_id tinyint
		SELECT @tipo_moneda_id = Tipo_De_Moneda_Id FROM DEVGURUS.Tipo_De_Moneda WHERE Tipo_De_Moneda_Nombre = @Cuenta_Moneda
		Declare @tipo_cuenta_id tinyint
		SELECT @tipo_cuenta_id = Tipo_De_Cuentas_Id FROM DEVGURUS.Tipo_De_Cuentas WHERE Tipo_De_Cuentas_Nombre = @Cuenta_Tipo
		DECLARE @ultimo_Id numeric(18,0)
		SET @ultimo_Id = (select MAX(Cuenta_Nro) from DEVGURUS.Cuentas)
		SET @ultimo_Id = @ultimo_Id + 1

		insert into Cuentas(
			Cuenta_Nro,
			[Cuenta_Estado],
			[Cuenta_Moneda],
			[Cuenta_Tipo],
			[Cuenta_PaisOrigen],
			[Cuenta_PaisAsignado],
			[Cuenta_Fec_Cre],
			[Cuenta_Fec_Cierre],
			[Cuenta_Cliente]) 
												
values(@ultimo_Id, @Cuenta_Estado,@tipo_moneda_id,@tipo_cuenta_id,@pais_id,@pais_id,@Cuenta_Fec_Cre,@Cuenta_Fec_Cierre,@Cuenta_Cliente)
		
SELECT Cuenta_Nro, Cuenta_Fec_Cre  FROM DEVGURUS.Cuentas where Cuenta_Fec_Cre = (select max(Cuenta_Fec_Cre) from Cuentas )
GO
	Print 'El procedimiento INSERTAR EN CUENTAS se ha creado correctamente';



/* EL PROCEDIMIENTO GENERA REGISTROS EN LA TABLA CLIENTES*/
IF EXISTS (SELECT id FROM sys.sysobjects WHERE name = 'insertarNuevoCliente')
	DROP PROCEDURE DEVGURUS.insertarNuevoCliente;
	Print 'El procedimiento INSERTAR NUEVO CLIENTE ya existe, SE BORRARA';
GO

CREATE PROCEDURE DEVGURUS.insertarNuevoCliente
	@apellido varchar(255), @calle varchar(255), @depto varchar(10), @fec_nac datetime, @mail varchar(255),
	@nombre varchar(255), @nro_doc int, @pais int, @piso int, @tipo_doc int, @cliente_user int
AS
	INSERT INTO DEVGURUS.Clientes 
		(Cliente_Apellido, Cliente_Dom_Calle, Cliente_Dom_Depto, Cliente_Fecha_Nac, Cliente_Mail,
		 Cliente_Nombre, Cliente_Nro_Doc, Cliente_Pais, Cliente_Dom_Piso, Cliente_Tipo_Doc, Cliente_User)
	VALUES
		(@apellido, @calle, @depto, @fec_nac, @mail, @nombre, @nro_doc, @pais, @piso, @tipo_doc, @cliente_user)
GO
	Print 'El procedimiento INSERTAR NUEVO CLIENTE se ha creado correctamente';



/* EL PROCEDIMIENTO GENERA REGISTROS EN LA TABLA USUARIOS*/
IF EXISTS (SELECT id FROM sys.sysobjects WHERE name = 'insertarNuevoUsuario')
	DROP PROCEDURE DEVGURUS.insertarNuevoUsuario;
	Print 'El procedimiento INSERTAR NUEVO USUARIO ya existe, SE BORRARA';
GO

create PROCEDURE DEVGURUS.insertarNuevoUsuario
	@nombre varchar(255),
	@password varchar(255), 
	@rol varchar(25), 
	@pregunta varchar(255), 
	@respuesta varchar(255),
	@estado varchar(255)
AS
	DECLARE @id_Rol int
	DECLARE @id_User int
	
	SET @id_Rol = (select Rol_Id from DEVGURUS.Roles where Rol_Desc = @rol)
	
	INSERT INTO DEVGURUS.Usuarios 
		(	Usuarios_Name, Usuarios_Pass, Usuarios_FechaCreacion, Usuarios_FechaUltimaModificacion, 
			Usuarios_PreguntaSecreta, Usuarios_RespuestaSecreta, Usuarios_Estado)
	VALUES
		(@nombre, @password, GETDATE(), GETDATE(), @pregunta, @respuesta, @estado)
	
	
	SET @id_User = (select MAX(Usuarios_Id) from DEVGURUS.Usuarios)
	
	insert into DEVGURUS.Rol_X_Usuario values (@id_User, @id_Rol)
	select 'Correcto' MENSAJE
GO	
	Print 'El procedimiento INSERTAR NUEVO USUARIO se ha creado correctamente';



/* EL PROCEDIMIENTO GENERA REGISTROS EN LA TABLA TRANSFERENCIAS*/
IF EXISTS (SELECT id FROM sys.sysobjects WHERE name = 'insertTransferenciasPendientes')
	DROP TRIGGER DEVGURUS.insertTransferenciasPendientes;
	Print 'El procedimiento INSERTAR TRANSFERENCIAS PENDIENTES ya existe, SE BORRARA';
GO

CREATE trigger DEVGURUS.insertTransferenciasPendientes
ON DEVGURUS.Transferencia
AFTER insert
AS
BEGIN

DECLARE	@Transaccion_Pendiente_Importe numeric(18,2)
DECLARE @Transaccion_Pendiente_Cliente int
DECLARE @Transaccion_Pendiente_Cuenta_Nro numeric(18,0)

SET @Transaccion_Pendiente_Importe = (select Transferencia_Costo_Transf from inserted)
SET @Transaccion_Pendiente_Cuenta_Nro = (select Transferencia_Cuenta_Emisora from inserted)
SET @Transaccion_Pendiente_Cliente = (select Cuenta_Cliente from DEVGURUS.Cuentas 
where Cuenta_Nro = @Transaccion_Pendiente_Cuenta_Nro)

insert into DEVGURUS.Transaccion_Pendiente (Transaccion_Pendiente_Importe, Transaccion_Pendiente_Descr,
Transaccion_Pendiente_Cliente, Transaccion_Pendiente_Fecha, Transaccion_Pendiente_Cuenta_Nro)
values (@Transaccion_Pendiente_Importe, 'Transferencia', @Transaccion_Pendiente_Cliente,
GETDATE(), @Transaccion_Pendiente_Cuenta_Nro)

END
GO
	Print 'El procedimiento INSERTAR TRANSFERENCIAS PENDIENTES se ha creado correctamente';



/* EL PROCEDIMIENTO SE UTILIZA PARA REALIZAR UNA TRANSFERENCIA */
IF EXISTS (SELECT id FROM sys.sysobjects WHERE name = 'realizar_transferencia')
	DROP PROCEDURE DEVGURUS.realizar_transferencia;
	Print 'El procedimiento REALIZAR TRANSFERENCIAS ya existe, SE BORRARA';
GO

CREATE PROCEDURE DEVGURUS.realizar_transferencia
	@cuenta_origen numeric (18,0),
	@cuenta_destino numeric (18,0),
	@importe float,
	@mismo_usuario int
AS
	UPDATE DEVGURUS.Cuentas SET Cuenta_Saldo = Cuenta_Saldo - @importe WHERE Cuenta_Nro = @cuenta_origen
	UPDATE DEVGURUS.Cuentas SET Cuenta_Saldo = Cuenta_Saldo + @importe WHERE Cuenta_Nro = @cuenta_destino
	DECLARE @costo numeric(18,2);

	IF @mismo_usuario = 1
	SET @costo = 0
	ELSE
		SET @costo = (SELECT Tipo_De_Cuentas_Costo FROM DEVGURUS.Tipo_De_Cuentas WHERE Tipo_De_Cuentas_Id = (SELECT Cuenta_Tipo FROM Cuentas WHERE Cuenta_Nro = @cuenta_origen))
	
	INSERT INTO DEVGURUS.Transaccion_Pendiente (Transaccion_Pendiente_Cliente, Transaccion_Pendiente_Descr, 
			Transaccion_Pendiente_Fecha, Transaccion_Pendiente_Importe, Transaccion_Pendiente_Cuenta_Nro)
	VALUES ((SELECT Cuenta_Cliente FROM Cuentas WHERE Cuenta_Nro = @cuenta_origen),   
			'Transferencia de ' + CAST(@importe AS VARCHAR) + ' ' + CAST((SELECT TM.Tipo_De_Moneda_Nombre FROM Cuentas CU, Tipo_De_Moneda TM WHERE Cuenta_Nro = @cuenta_origen AND CU.Cuenta_Moneda = TM.Tipo_De_Moneda_Id) AS VARCHAR) + ' de la cuenta ' + CAST(@cuenta_origen AS VARCHAR) + ' a la cuenta ' + CAST(@cuenta_destino AS VARCHAR),
			GETDATE(),
			@costo,
			@cuenta_origen)
GO	
	Print 'El procedimiento REALIZAR TRANSFERENCIAS se ha creado correctamente';



/* EL PROCEDIMIENTO SE UTILIZA PARA REALIZAR UN RETIRAR */
IF EXISTS (SELECT id FROM sys.sysobjects WHERE name = 'retirar')
	DROP PROCEDURE DEVGURUS.retirar;
	Print 'El procedimiento RETIRAR ya existe, SE BORRARA';
GO

CREATE PROCEDURE DEVGURUS.retirar
	@cuenta numeric (18,0),
	@importe float
AS
	DECLARE @cheque_id numeric (18,0)
	DECLARE @retiro_id numeric (18,0)
	SET @cheque_id = (SELECT TOP 1 Cheque_Id + 1  FROM DEVGURUS.Cheques ORDER BY Cheque_Id DESC)
	SET @retiro_id = (SELECT TOP 1 Retiro_Id + 1  FROM DEVGURUS.Retiros ORDER BY Retiro_Id DESC)
	
	INSERT INTO DEVGURUS.Cheques (Cheque_Id, Cheque_Fecha, Cheque_Importe) 
		VALUES (@cheque_id, GETDATE(), @importe)
	
	INSERT INTO DEVGURUS.Retiros (Retiro_Id, Retiro_Cheque, Retiro_Cuenta, Retiro_Fecha, Retiro_Importe)
		VALUES (@retiro_id, @cheque_id, @cuenta, GETDATE(), @importe)
	
	UPDATE DEVGURUS.Cuentas SET Cuenta_Saldo = Cuenta_Saldo - @importe WHERE Cuenta_Nro = @cuenta
GO	
	Print 'El procedimiento RETIRAR se ha creado correctamente';



/* EL GATILLO SE UTILIZA PARA VERIFICAR SI UNA CUENTA SE ENCUENTRA INHABILITADA DESPUES DE UN MOVIMIENTO*/
IF EXISTS (SELECT id FROM sys.sysobjects WHERE name = 'validarCuentaInhabilitada')
	DROP Trigger DEVGURUS.validarCuentaInhabilitada;
	Print 'El gatillo VALIDAR CUENTA INHABILITADA ya existe, SE BORRARA';
GO

CREATE TRIGGER DEVGURUS.validarCuentaInhabilitada
ON DEVGURUS.Transaccion_Pendiente
AFTER INSERT
AS
	DECLARE @cliente int
	DECLARE @cuenta numeric(18,0)
	DECLARE @contador tinyint
	
	SET @cliente = (select Transaccion_Pendiente_Cliente from INSERTED)
	SET @cuenta = (select Transaccion_Pendiente_Cuenta_Nro from INSERTED)
	SET @contador = (Select COUNT(*) CONTADOR from DEVGURUS.Transaccion_Pendiente where Transaccion_Pendiente_Cliente = @cliente
	and Transaccion_Pendiente_Cuenta_Nro = @cuenta)
	
	IF (@contador = 5)
	BEGIN
	update Cuenta_Estado SET Cuenta_Estado = 'Inhabilitado' where Cuenta_Nro = @cuenta
	END
GO	
	Print 'El gatillo VALIDAR CUENTA INHABILITADA se ha creado correctamente';


Print 'Se ha creado el lote de PROCEDURES y TRIGGERS correctamente';

COMMIT TRAN InicializacionDeProcedures


/* SE CREAN LOS CUATRO USUARIOS DE DESARROLLADORES Y EL USUARIO 'ADMIN'*/
EXECUTE DEVGURUS.insertarNuevoUsuario
	@nombre = 'admin',
	@password = 'w23e', 
	@rol = 'Administrador General', 
	@pregunta = '¿En que pais naciste?', 
	@respuesta = 'Argentina',
	@estado = 'Habilitado';
Print 'Se ha creado el usuario "ADMIN" con password "w23e" y rol de "Administrador General"';

EXECUTE DEVGURUS.insertarNuevoUsuario
	@nombre = 'lbenitez',
	@password = '1558', 
	@rol = 'Administrador', 
	@pregunta = '¿En que pais naciste?', 
	@respuesta = 'Argentina',
	@estado = 'Habilitado';
Print 'Se ha creado el usuario "lbenitez" con password "1558" y rol de "Administrador"';