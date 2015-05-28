/* DECLARACION DE LA BASE DE DATOS */
USE GD1C2015
GO

				/************************************************
				*************************************************
								CREACION DE TABLAS
				*************************************************
				*************************************************/

/* LOS CAMPOS CON DESCRIPCION "TEMPORAL" SE UTILIZAN PARA LEER DE LA TABLA MAESTRA COMO ESTA ESTE;
UNA VEZ REALIZADO ESTO SE PROCEDE A BORRAR DICHOS CAMPOS Y EN SU LUGAR SE UTILIZA LOS CAMPOS QUE
TENGAN EL MISMO NOMBRE sin "TEMPORAL"	*/

Create Table Paises	(		Pais_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Pais_Nombre varchar(255) NOT NULL)

Create Table Tipo_De_Doc (	Tipo_Doc_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Tipo_Doc_Desc varchar(255) NOT NULL)
							
Create Table Roles		(	Rol_Id tinyint identity (1,1) PRIMARY KEY NOT NULL,
							Rol_Desc varchar(255) NOT NULL,
							Rol_Estado varchar (20) NOT NULL,
							Func_Extraer varchar (25) NOT NULL,
							Func_Transferir varchar (25) NOT NULL,
							Func_Depositar varchar (25) NOT NULL,
							Func_ABM_Roles varchar (25) NOT NULL,
							Func_ABM_Clientes varchar (25) NOT NULL,
							Func_ABM_Usuarios varchar (25) NOT NULL,
							Func_ABM_Cuentas varchar (25) NOT NULL)
							
Create Table Usuarios	(	Usuarios_Id integer identity (1,1) PRIMARY KEY NOT NULL,
							Usuarios_Name varchar(255) UNIQUE NOT NULL,
							Usuarios_Pass varchar(255) NOT NULL,
							Usuarios_FechaCreacion datetime NOT NULL,
							Usuarios_FechaUltimaModificacion datetime NOT NULL,
							Usuarios_PreguntaSecreta varchar(255) NOT NULL,
							Usuarios_RespuestaSecreta varchar (255) NOT NULL)
							
Create Table Rol_X_Usuario(	Rol_X_Usuario_Usuario integer NOT NULL FOREIGN KEY REFERENCES Usuarios(Usuarios_Id),
							Rol_X_Usuario_Rol tinyint NOT NULL FOREIGN KEY REFERENCES Roles(Rol_Id),
							CONSTRAINT Pk_Rol_X_Usuario PRIMARY KEY (Rol_X_Usuario_Usuario,Rol_X_Usuario_Rol))

Create Table Clientes (		Cliente_Id integer identity (1,1) PRIMARY KEY NOT NULL,
							Cliente_Nombre varchar(255),
							Cliente_Apellido varchar(255),
							Cliente_Estado varchar(255),
							Cliente_Tipo_Doc numeric (18,0) FOREIGN KEY REFERENCES Tipo_De_Doc(Tipo_Doc_Id),
							Cliente_Nro_Doc integer,
							Cliente_Pais numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
							Cliente_Dom_Calle varchar(255),
							Cliente_Dom_Nro numeric(18,0),
							Cliente_Dom_Piso numeric(18,0),
							Cliente_Dom_Depto varchar(10),
							Cliente_Fecha_Nac datetime,
							Cliente_Mail varchar(255),
							Cliente_User integer FOREIGN KEY REFERENCES Usuarios(Usuarios_ID) unique)

Create Table Tipo_De_Cuentas(	Tipo_De_Cuentas_Id tinyint identity (1,1) PRIMARY KEY,
								Tipo_De_Cuentas_Nombre varchar(255),
								Tipo_De_Cuentas_Duracion_Dias smallint,
								Tipo_De_Cuentas_Costo numeric (18,2))

Create Table Tarjetas (		Tarjeta_Nro varchar(16) PRIMARY KEY NOT NULL,
							Tarjeta_Fecha_Emision datetime,
							Tarjeta_Fecha_Vencimiento datetime,
							Tarjeta_Cod_Seg varchar(3),
							Tarjeta_Emisor_Desc varchar (255))

Create Table Cuentas (		Cuenta_Nro numeric (18,0) PRIMARY KEY NOT NULL,
							Cuenta_Estado varchar(255) default 'Habilitado',
							Cuenta_Moneda varchar(255) default 'Dolar',
							Cuenta_Tipo tinyint FOREIGN KEY REFERENCES Tipo_De_Cuentas(Tipo_De_Cuentas_Id),
							Cuenta_PaisOrigen numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
							Cuenta_PaisAsignado numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
							Cuenta_Fec_Cre datetime,
							Cuenta_Fec_Cierre datetime,
							Cuenta_Cliente integer FOREIGN KEY REFERENCES Clientes(Cliente_Id),
							cuenta_Tarjeta varchar(16) FOREIGN KEY REFERENCES Tarjetas(Tarjeta_Nro))
														
Create Table Depositos (	Deposito_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Deposito_Fecha datetime,
							Deposito_Importe numeric (18,2) check (Deposito_Importe >= 1),
							Deposito_TipoMoneda varchar(255),
							Deposito_Cuenta numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
							Deposito_Tarjeta varchar(16) FOREIGN KEY REFERENCES Tarjetas(Tarjeta_Nro))

Create Table Facturas	(	Factura_Numero numeric (18,0) PRIMARY KEY NOT NULL,
							Factura_Fecha datetime,
							Factura_Descripcion varchar(255),
							Factura_Importe numeric(18,2),
							Factura_Cliente integer FOREIGN KEY REFERENCES Clientes(Cliente_Id))
							
Create Table Items	(		Items_Numero integer identity(1,1) PRIMARY KEY NOT NULL,
							Items_Descripcion varchar(255),
							Items_Importe numeric(18,2),
							Items_Factura numeric (18,0) FOREIGN KEY REFERENCES Facturas(Factura_Numero))

Create Table Transferencia (Transferencia_Id integer identity(1,1) PRIMARY KEY NOT NULL,
							Transferencia_Fecha datetime,
							Transferencia_Importe numeric (18,2),
							Transferencia_Costo_Transf numeric (18,2),
							Transferencia_Cuenta_Emisora numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
							Transferencia_Cuenta_Destino numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro))

Create Table Bancos		(	Banco_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Banco_Nombre varchar(255),
							Banco_Direccion varchar(255))
							
Create Table Cheques	(	Cheque_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Cheque_Fecha datetime,
							Cheque_Importe numeric (18,2),
							Cheque_Banco numeric (18,0) FOREIGN KEY REFERENCES Bancos(Banco_Id))
														
Create Table Retiros	(	Retiro_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Retiro_Fecha datetime,
							Retiro_Importe numeric (18,2),
							Retiro_Cuenta numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
							Retiro_Cheque numeric (18,0) FOREIGN KEY REFERENCES Cheques(Cheque_Id))
							
Create Table Transaccion_Pendiente	(	Transaccion_Pendiente_Id integer identity (1,1) PRIMARY KEY NOT NULL,
										Transaccion_Pendiente_Importe numeric (18,2),
										Transaccion_Pendiente_Descr varchar(255),
										Transaccion_Pendiente_Cliente integer FOREIGN KEY REFERENCES Clientes(Cliente_Id),
										Transaccion_Pendiente_Fecha datetime)			
												
Create Table Login_Incorrecto	(	Login_Incorrecto_Id integer identity (1,1) Primary key,
									Login_Incorrecto_User varchar(255),
									Login_Incorrecto_Pass varchar (255),
									Login_Incorrecto_Intento tinyint,
									Login_Incorrecto_Fecha datetime)
									
Create Table Login_Auditoria	(	Login_Auditoria_Id integer identity (1,1) Primary key,
									Login_Auditoria_Ingresado varchar(255),
									Login_Auditoria_Fecha datetime,
									Login_Auditoria_Tipo varchar(25))

/* BORRAR TODAS LAS TABLAS
Drop Table Login_Auditoria
Drop Table Login_Incorrecto
Drop Table Transaccion_Pendiente
Drop Table Retiros
Drop Table Cheques
Drop Table Bancos
Drop Table Transferencia
Drop Table Items
Drop Table Facturas
Drop Table Depositos
Drop Table Cuentas
Drop Table Tarjetas
Drop Table Tipo_De_Cuentas
Drop Table Clientes 
Drop Table Rol_X_Usuario
Drop Table Usuarios
Drop Table Roles
Drop Table Tipo_De_Doc
Drop Table Paises
*/

				/************************************************
				*************************************************
				INSERT DE DATOS EN LAS TABLAS DESDE TABLA MAESTRA
				*************************************************
				*************************************************/

/* PAISES */
Insert into Paises (Pais_Id, Pais_Nombre)	select distinct Cli_Pais_Codigo, Cli_Pais_Desc from gd_esquema.Maestra union 
													select distinct Cuenta_Pais_Codigo, Cuenta_Pais_Desc from gd_esquema.Maestra union
													select distinct	Cuenta_Dest_Pais_Codigo, Cuenta_Dest_Pais_Desc from gd_esquema.Maestra
													where	Cli_Pais_Codigo <> NULL and
															Cuenta_Pais_Codigo <> NULL and
															Cuenta_Dest_Pais_Codigo <> NULL

/* TIPOS DE DOCUMENTO */
Insert into Tipo_De_Doc (Tipo_Doc_Id, Tipo_Doc_Desc) select distinct Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc from gd_esquema.Maestra

/* ROLES */
Insert into Roles (Rol_Desc, Rol_Estado, Func_Extraer, Func_Transferir, Func_Depositar, Func_ABM_Roles, Func_ABM_Clientes, Func_ABM_Usuarios, Func_ABM_Cuentas)
values	('Administrador', 'Activo', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado', 'Habilitado'),
		('Cliente', 'Activo', 'Habilitado', 'Habilitado', 'Habilitado', 'Inhabilitado', 'Inhabilitado', 'Inhabilitado', 'Inhabilitado')

/* USUARIOS */
Insert into Usuarios (Usuarios_Name, Usuarios_Pass, Usuarios_FechaCreacion, Usuarios_FechaUltimaModificacion, Usuarios_PreguntaSecreta, Usuarios_RespuestaSecreta)
select distinct Cli_Apellido + Cli_Nombre, SUBSTRING(Cli_Apellido, 1, 1)+SUBSTRING(Cli_Apellido, 1, 1)+SUBSTRING(Cli_Apellido, 1, 1)+SUBSTRING(Cli_Apellido, 1, 1)+'4321',
GETDATE(), GETDATE(), '¿En que pais naciste?', Cli_Pais_Desc from gd_esquema.Maestra

/* ROL_X_USUARIO */
Insert into Rol_X_Usuario (Rol_X_Usuario_Usuario, Rol_X_Usuario_Rol)
select US.Usuarios_Id, RO.Rol_Id from Usuarios US, Roles RO
where RO.Rol_Desc = 'Cliente'

/* CLIENTES */
Insert into Clientes(	Cliente_Nombre, Cliente_Apellido, Cliente_Estado, Cliente_Tipo_Doc, Cliente_Pais, 
						Cliente_Dom_Calle, Cliente_Dom_Nro, Cliente_Dom_Piso, Cliente_Dom_Depto, 
						Cliente_Fecha_Nac, Cliente_Mail, Cliente_User)
						select distinct MA.Cli_Nombre, MA.Cli_Apellido, 'Habilitado', MA.Cli_Tipo_Doc_Cod, 
						MA.Cli_Pais_Codigo, MA.Cli_Dom_Calle, MA.Cli_Dom_Nro, MA.Cli_Dom_Piso, MA.Cli_Dom_Depto, 
						MA.Cli_Fecha_Nac, MA.Cli_Mail, US.Usuarios_Id from gd_esquema.Maestra MA, Usuarios US
						where US.Usuarios_Name = Cli_Apellido + Cli_Nombre

/* TIPO_DE_CUENTAS */
Insert into Tipo_De_Cuentas (Tipo_De_Cuentas_Nombre, Tipo_De_Cuentas_Duracion_Dias, Tipo_De_Cuentas_Costo)
values	('Oro', 100, 29.99),
		('Plata', 60, 19.99),
		('Bronce', 30, 12.53),
		('Gratuita', 15, 0.00)

/* TARJETAS */
Insert into Tarjetas (Tarjeta_Nro, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, Tarjeta_Cod_Seg, Tarjeta_Emisor_Desc)
select distinct Tarjeta_Numero, Tarjeta_Fecha_Emision, Tarjeta_Fecha_Vencimiento, Tarjeta_Codigo_Seg, Tarjeta_Emisor_Descripcion from gd_esquema.Maestra
where Tarjeta_Numero is not null

/* CUENTAS */
Insert into Cuentas (Cuenta_Nro, Cuenta_Tipo, Cuenta_PaisOrigen, Cuenta_PaisAsignado, Cuenta_Fec_Cre, Cuenta_Cliente)
select distinct MA.Cuenta_Numero, 4, MA.Cuenta_Pais_Codigo, MA.Cli_Pais_Codigo, MA.Cuenta_Fecha_Creacion, CL.Cliente_Id
from gd_esquema.Maestra MA, Clientes CL
where CL.Cliente_Nombre = MA.Cli_Nombre and CL.Cliente_Apellido = MA.Cli_Apellido and MA.Cuenta_Numero is not null

update Cuentas
set Cuenta_Fec_Cierre = DATEADD(day, 15, Cuenta_Fec_Cre)

update Cuentas
set Cuenta_Tarjeta = MA.Tarjeta_Numero from gd_esquema.Maestra MA
where Cuenta_Nro = MA.Cuenta_Numero and MA.Tarjeta_Numero is not null
		
/* DEPOSTIOS */
Insert into Depositos (Deposito_Id, Deposito_Fecha, Deposito_Importe, Deposito_TipoMoneda, Deposito_Cuenta, Deposito_Tarjeta)
select distinct Deposito_Codigo, Deposito_Fecha, Deposito_Importe, NULL, Cuenta_Numero, Tarjeta_Numero from gd_esquema.Maestra
where Deposito_Codigo is not null

/* FACTURAS */
Insert into Facturas (Factura_Numero, Factura_Fecha, Factura_Cliente)
select distinct MA.Factura_Numero, MA.Factura_Fecha, CL.Cliente_Id from gd_esquema.Maestra MA, Clientes CL
where CL.Cliente_Nombre = MA.Cli_Nombre and CL.Cliente_Apellido = MA.Cli_Apellido
and MA.Factura_Numero is not null
		/* QUEDA PENDIENTE SUMAR EL IMPORTE PERO SE PUEDE REALIZAR AL MOMENTO DE LA CONSULTA */

/* ITEMS */
Insert into Items (Items_Descripcion, Items_Importe, Items_Factura)
select Item_Factura_Descr, Item_Factura_Importe, Factura_Numero from gd_esquema.Maestra
where Factura_Numero is not null

/* TRANSFERENCIA */
Insert into Transferencia (Transferencia_Fecha, Transferencia_Importe, Transferencia_Costo_Transf, Transferencia_Cuenta_Emisora, Transferencia_Cuenta_Destino)
select distinct Transf_Fecha, Trans_Importe, Trans_Costo_Trans, Cuenta_Numero, Cuenta_Dest_Numero from gd_esquema.Maestra
where Cuenta_Dest_Numero is not null

/* BANCOS */
Insert into Bancos (Banco_Id, Banco_Nombre, Banco_Direccion)
select distinct Banco_Cogido, Banco_Nombre, Banco_Direccion from gd_esquema.Maestra
where Banco_Cogido is not null

/* CHEQUES */
Insert into Cheques (Cheque_Id, Cheque_Fecha, Cheque_Importe, Cheque_Banco)
select distinct Cheque_Numero, Cheque_Fecha, Cheque_Importe, Banco_Cogido from gd_esquema.Maestra
where Cheque_Numero is not null

/* RETIROS */
Insert into Retiros (Retiro_Id, Retiro_Fecha, Retiro_Importe, Retiro_Cuenta, Retiro_Cheque)
select distinct Retiro_Codigo, Retiro_Fecha, Retiro_Importe, Cuenta_Numero, Cheque_Numero from gd_esquema.Maestra
where Retiro_Codigo is not null

/* CARGA DE USUARIOS PARA PRUEBAS DE DESARROLLO */
Insert into Usuarios (Usuarios_Name, Usuarios_Pass, Usuarios_FechaCreacion, Usuarios_FechaUltimaModificacion, Usuarios_PreguntaSecreta, Usuarios_RespuestaSecreta)
values ('lbenitez', '1558', GETDATE(), GETDATE(), '¿Como se llamaba tu primer mascota?', 'Chicho')
				/************************************************
				*************************************************
								CONSULTAS
				*************************************************
				*************************************************/