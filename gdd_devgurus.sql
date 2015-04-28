
/* DECLARACION DE LA BASE DE DATOS */
USE GD1C2015
GO

				/************************************************
				*************************************************
								CREACION DE TABLAS
				*************************************************
				*************************************************/


Create Table Paises	(		Pais_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Pais_Nombre varchar(255) NOT NULL)

Create Table Tipo_De_Doc (	Tipo_Doc_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Tipo_Doc_Desc varchar(255) NOT NULL)
							
Create Table Funciones	(	Funcion_Id numeric (18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
							Funcion_Desc varchar(255) NOT NULL)
							
Create Table Roles		(	Rol_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Rol_Desc varchar(255),
							Rol_Estado varchar (20) NOT NULL,
							Rol_Funcion numeric (18,0) FOREIGN KEY REFERENCES Funciones(Funcion_Id) NOT NULL)
							
Create Table Usuarios	(	Usuarios_Id numeric(18,0) Identity(1,1) Primary key NOT NULL,
							Usuarios_Name varchar(255) UNIQUE NOT NULL,
							Usuarios_Pass varchar(255) NOT NULL,
							Usuarios_Rol numeric(18,0) foreign key references Roles(Rol_Id) NOT NULL,
							Usuarios_FechaCreacion datetime NOT NULL,
							Usuarios_FechaUltimaModificacion datetime NOT NULL,
							Usuarios_PreguntaSecreta varchar(255) NOT NULL,
							Usuarios_RespuestaSecreta varchar (255) NOT NULL)
							
Create Table Clientes (		Cliente_Id numeric (18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
							Cliente_Nombre varchar(255),
							Cliente_Apellido varchar(255),
							Cliente_Estado varchar(255),
							Cliente_Tipo_Doc numeric (18,0) FOREIGN KEY REFERENCES Tipo_De_Doc(Tipo_Doc_Id),
							Cliente_Nro_Doc numeric (18,0),
							Cliente_Pais numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
							Cliente_Dom_Calle varchar(255),
							Cliente_Dom_Nro numeric (18,0),
							Cliente_Dom_Piso numeric (18,0),
							Cliente_Dom_Depto varchar(10),
							Cliente_Fecha_Nac datetime,
							Cliente_Mail varchar(255),
							Cliente_User numeric(18,0) foreign key references Usuarios(Usuarios_ID) unique)
						
Create Table Tipo_De_Cuentas(	Tipo_De_Cuentas_Id numeric(18,0) primary key,
								Tipo_De_Cuentas_Nombre varchar (255),
								Tipo_De_Cuentas_Duracion numeric (18,0),
								Tipo_De_Cuentas_Costo numeric (18,2))
								
Create Table Tarjetas (		Tarjeta_Nro varchar(16) PRIMARY KEY NOT NULL,
							Tarjeta_Fecha_Emision datetime,
							Tarjeta_Fecha_Vencimiento datetime,
							Tarjeta_Cod_Seg varchar(3),
							Tarjeta_Emisor_Desc varchar (255))
							
Create Table Cuentas (		Cuenta_Nro numeric (18,0) PRIMARY KEY NOT NULL,
							Cuenta_Estado varchar(255),
							Cuenta_Moneda varchar(255) default 'Dolar',
							Cuenta_Tipo numeric(18,0) foreign key references Tipo_De_Cuenta(Tipo_De_Cuenta_Id),
							Cuenta_PaisOrigen numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
							Cuenta_PaisAsignado numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
							Cuenta_Fec_Cre datetime,
							Cuenta_Fec_Cierre datetime,
							Cuenta_Cliente numeric (18,0) FOREIGN KEY REFERENCES Clientes(Cliente_Id),
							Cuenta_Tarjeta numeric (18,0) Foreign key references Tarjetas(Tarjeta_Nro))
							
Create Table Depositos (	Deposito_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Deposito_Fecha datetime,
							Deposito_Importe numeric (18,2) check (Deposito_Importe >= 1),
							Deposito_TipoMoneda varchar(255),
							Deposito_Cuenta numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
							Deposito_Tarjeta varchar(16) FOREIGN KEY REFERENCES Tarjetas(Tarjeta_Id))
							
Create Table Facturas	(	Factura_Numero numeric (18,0) PRIMARY KEY NOT NULL,
							Factura_Fecha datetime)
							
Create Table Transferencia (Transferencia_Id numeric (18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
							Transferencia_Fecha datetime,
							Transferencia_Importe numeric (18,2),
							Transferencia_Costo_Transf numeric (18,2),
							Transferencia_Cuenta_Emisora numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
							Transferencia_Cuenta_Destino numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
							Transferencia_Factura numeric (18,0) FOREIGN KEY REFERENCES Facturas(Factura_Numero))

Create Table Bancos		(	Banco_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Banco_Nombre datetime,
							Banco_Direccion numeric (18,2))
							
Create Table Cheques	(	Cheque_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Cheque_Fecha datetime,
							Cheque_Importe numeric (18,2),
							Cheque_Banco numeric (18,0) FOREIGN KEY REFERENCES Bancos(Banco_Id))
														
Create Table Retiros	(	Retiro_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Retiro_Fecha datetime,
							Retiro_Importe numeric (18,2),
							Retiro_Cuenta numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
							Retiro_Cheque numeric (18,0) FOREIGN KEY REFERENCES Cheques(Cheque_Id))
							
Create Table Items		(	Item_Id numeric (18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
							Item_Importe numeric (18,2),
							Item_Descr varchar(255),
							Item_Factura numeric (18,0) FOREIGN KEY REFERENCES Facturas(Factura_Numero))
							
Create Table ClienteXRol(	ClienteXRol_Cliente numeric (18,0) NOT NULL FOREIGN KEY REFERENCES Clientes(Cliente_Id),
							ClienteXRol_Rol numeric (18,0)  NOT NULL FOREIGN KEY REFERENCES Roles(Rol_Id),
							CONSTRAINT Pk_ClienteXRol PRIMARY KEY (ClienteXRol_Cliente,ClienteXRol_Rol))
							
Create Table Login_Incorrecto	(	Login_Incorrecto_Id numeric(18,0) Identity(1,1) Primary key,
									Login_Incorrecto_User varchar(255),
									Login_Incorrecto_Pass varchar (255),
									Login_Incorrecto_Intento numeric(18,0),
									Login_Incorrecto_Fecha datetime)
									
Create Table Login_Auditoria	(	Login_Auditoria_Id numeric(18,0) Identity(1,1) Primary key,
									Login_Auditoria_Ingresado varchar(255),
									Login_Auditoria_Fecha datetime,
									Login_Auditoria_Tipo varchar(20),
									Login_Auditoria_NroIntentoFallido numeric(18,0))

/* BORRAR TODAS LAS TABLAS
Drop Table Login_Auditoria
Drop Table Login_Incorrecto
Drop Table ClienteXRol
Drop Table Items
Drop Table Retiros
Drop Table Cheques
Drop Table Bancos
Drop Table Transferencia
Drop Table Facturas
Drop Table Depositos
Drop Table Cuentas
Drop Table Tarjetas
Drop Table Tipo_De_Cuentas
Drop Table Clientes
Drop Table Usuarios
Drop Table Roles
Drop Table Funciones
Drop Table Tipo_De_Doc
Drop Table Paises
*/

				/************************************************
				*************************************************
				INSERT DE DATOS EN LAS TABLAS DESDE TABLA MAESTRA
				*************************************************
				*************************************************/

/* PAISES */
Insert into Paises (Pais_Id, Pais_Nombre) select distinct Cli_Pais_Codigo, Cli_Pais_Desc from gd_esquema.Maestra
/* TIPOS DE DOCUMENTO */
Insert into Tipo_De_Doc (Tipo_Doc_Desc) select distinct Cli_Tipo_Doc_Desc from gd_esquema.Maestra
/* CLIENTES */
Insert into Clientes	(Cliente_Nombre, Cliente_Apellido, 
						Cliente_Dom_Calle, Cliente_Dom_Nro, Cliente_Dom_Piso,
						Cliente_Dom_Depto, Cliente_Fecha_Nac, Cliente_Mail)
						select Cli_Nombre, Cli_Apellido, Cli_Dom_Calle, Cli_Dom_Nro,
						Cli_Dom_Piso, Cli_Dom_Depto, Cli_Fecha_Nac, Cli_Mail
						from gd_esquema.Maestra
						
Insert into Clientes	(Cliente_Tipo_Doc) select Tipo_Doc_Id from Tipo_De_Doc
						where Tipo_De_Doc.Tipo_Doc_Desc = gd_esquema.Maestra.Cli_Tipo_Doc_Desc
						
Insert into Clientes	(Cliente_Pais) select Pais_Id from Paises
						where Paises.Pais_Nombre = gd_esquema.Maestra.Cli_Pais_Desc


				/************************************************
				*************************************************
								CONSULTAS
				*************************************************
				*************************************************/
						
select *from dbo.Paises