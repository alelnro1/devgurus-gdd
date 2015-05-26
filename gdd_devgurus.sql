
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
							

							

							
Create Table Usuarios	(	Usuarios_Id numeric(18,0) Identity(1,1) Primary key NOT NULL,
							Usuarios_Name varchar(255) UNIQUE NOT NULL,
							Usuarios_Pass varchar(255) NOT NULL,
							Usuarios_FechaCreacion datetime NOT NULL,
							Usuarios_FechaUltimaModificacion datetime NOT NULL,
							Usuarios_PreguntaSecreta varchar(255) NOT NULL,
							Usuarios_RespuestaSecreta varchar (255) NOT NULL)

Create Table Funciones	(	Funcion_Id numeric (18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
							Funcion_Desc varchar(255) NOT NULL)
							
Create Table Roles		(	Rol_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Rol_Desc varchar(255),
							Rol_Estado varchar (20) NOT NULL,
							Rol_Funcion numeric (18,0) FOREIGN KEY REFERENCES Funciones(Funcion_Id) NOT NULL)

Create Table Rol_X_Usuario(	Rol_X_Usuario_Usuario numeric (18,0) NOT NULL FOREIGN KEY REFERENCES Usuarios(Usuarios_Id),
							Rol_X_Usuario_Rol numeric (18,0)  NOT NULL FOREIGN KEY REFERENCES Roles(Rol_Id),
							CONSTRAINT Pk_Rol_X_Usuario PRIMARY KEY (Rol_X_Usuario_Usuario,Rol_X_Usuario_Rol))
							
							

							

														
Create Table Clientes (		Cliente_Id numeric (18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
							Cliente_Nombre varchar(255),
							Cliente_Apellido varchar(255),
							Cliente_Estado varchar(255),
							Cliente_Tipo_Doc numeric (18,0) FOREIGN KEY REFERENCES Tipo_De_Doc(Tipo_Doc_Id),
							Cliente_Nro_Doc numeric (18,0),
							Cliente_Pais numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
							Cliente_Dom_Calle varchar(255),
							Cliente_Dom_Nro numeric (8,0),
							Cliente_Dom_Piso numeric (3,0),
							Cliente_Dom_Depto varchar(1),
							Cliente_Fecha_Nac datetime,
							Cliente_Mail varchar(255),
							Cliente_User numeric(18,0) FOREIGN KEY REFERENCES Usuarios(Usuarios_ID) unique)
						
Create Table Tipo_De_Cuentas(	Tipo_De_Cuentas_Id numeric(18,0) PRIMARY KEY,
								Tipo_De_Cuentas_Nombre varchar(255),
								Tipo_De_Cuentas_Duracion numeric (18,0),
								Tipo_De_Cuentas_Costo numeric (18,2))
	
							
Create Table Cuentas (		Cuenta_Nro numeric (18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
							Cuenta_Estado numeric(1,0),
							Cuenta_Moneda varchar(255) default 'Dolar',
							Cuenta_Tipo numeric(18,0) FOREIGN KEY REFERENCES Tipo_De_Cuentas(Tipo_De_Cuentas_Id),
							Cuenta_PaisOrigen numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
							Cuenta_PaisAsignado numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
							Cuenta_Fec_Cre datetime,
							Cuenta_Fec_Cierre datetime,
							Cuenta_Cliente numeric (18,0) FOREIGN KEY REFERENCES Clientes(Cliente_Id))
							
														
Create Table Tarjetas (		Tarjeta_Nro numeric(18,0) PRIMARY KEY NOT NULL,
							Tarjeta_Fecha_Emision datetime,
							Tarjeta_Fecha_Vencimiento datetime,
							Tarjeta_Cod_Seg varchar(3),
							Tarjeta_Emisor_Desc varchar (255),
							Tarjeta_cuenta numeric(18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro))
							
Create Table Depositos (	Deposito_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Deposito_Fecha datetime,
							Deposito_Importe numeric (18,2) check (Deposito_Importe >= 1),
							Deposito_TipoMoneda varchar(255),
							Deposito_Cuenta numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
							Deposito_Tarjeta numeric(18,0) FOREIGN KEY REFERENCES Tarjetas(Tarjeta_Nro))
							
Create Table Facturas	(	Factura_Numero numeric (18,0) PRIMARY KEY NOT NULL,
							Factura_Fecha datetime,
							Factura_Descripcion varchar(255),
							Factura_Importe numeric(18,0),
							Factura_Cliente numeric(18,0) FOREIGN KEY REFERENCES Clientes(Cliente_Id))
							
Create Table Transferencia (Transferencia_Id numeric (18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
							Transferencia_Fecha datetime,
							Transferencia_Importe numeric (18,2),
							Transferencia_Costo_Transf numeric (18,2),
							Transferencia_Cuenta_Emisora numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
							Transferencia_Cuenta_Destino numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro))

											

Create Table Bancos		(	Banco_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Banco_Nombre varchar(20),
							Banco_Direccion numeric (18,0))
							
Create Table Cheques	(	Cheque_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Cheque_Fecha datetime,
							Cheque_Importe numeric (18,2),
							Cheque_Banco numeric (18,0) FOREIGN KEY REFERENCES Bancos(Banco_Id))
														
Create Table Retiros	(	Retiro_Id numeric (18,0) PRIMARY KEY NOT NULL,
							Retiro_Fecha datetime,
							Retiro_Importe numeric (18,2),
							Retiro_Cuenta numeric (18,0) FOREIGN KEY REFERENCES Cuentas(Cuenta_Nro),
							Retiro_Cheque numeric (18,0) FOREIGN KEY REFERENCES Cheques(Cheque_Id))
							
Create Table Transaccion_Pendiente	(	Transaccion_Pendiente_Id numeric (18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
										Transaccion_Pendiente_Importe numeric (18,2),
										Transaccion_Pendiente_Descr varchar(255),
										Transaccion_Pendiente_Cliente numeric (18,0) FOREIGN KEY REFERENCES Clientes(Cliente_Id),
										Transaccion_Pendiente_Fecha datetime)
										
												
Create Table Login_Incorrecto	(	Login_Incorrecto_Id numeric(18,0) Identity(1,1) Primary key,
									Login_Incorrecto_User varchar(255),
									Login_Incorrecto_Pass varchar (255),
									Login_Incorrecto_Intento numeric(1,0),
									Login_Incorrecto_Fecha datetime)
									
Create Table Login_Auditoria	(	Login_Auditoria_Id numeric(18,0) Identity(1,1) Primary key,
									Login_Auditoria_Ingresado varchar(255),
									Login_Auditoria_Fecha datetime,
									Login_Auditoria_Tipo varchar(20))

/* BORRAR TODAS LAS TABLAS
Drop Table Login_Auditoria
Drop Table Login_Incorrecto
Drop Table Rol_X_Usuario
Drop Table Transferencias_Pendientes
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
Insert into Tipo_De_Doc (Tipo_Doc_Id, Tipo_Doc_Desc) select distinct Cli_Tipo_Doc_Cod, Cli_Tipo_Doc_Desc from gd_esquema.Maestra
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
/* CLIENTES */




				/************************************************
				*************************************************
								CONSULTAS
				*************************************************
				*************************************************/
						
select *from dbo.Paises
select *from gd_esquema.Maestra
select *from Tipo_De_Doc
select *from Cuentas
select *from Usuarios
select *from Tipo_De_Cuentas


insert into Cuentas (Cuenta_Estado, Cuenta_Moneda, Cuenta_Tipo, Cuenta_PaisOrigen,
 Cuenta_PaisAsignado, Cuenta_Fec_Cre, Cuenta_Fec_Cierre, Cuenta_Cliente) values (0,'Dolar',1,1,NULL,NULL,NULL,NULL);