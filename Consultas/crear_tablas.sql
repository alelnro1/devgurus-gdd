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

Create Table Tipo_De_Moneda(	Tipo_De_Moneda_Id tinyint identity (1,1) PRIMARY KEY,
								Tipo_De_Moneda_Nombre varchar(255))	
								
Create Table Cuentas (		Cuenta_Nro numeric (18,0) IDENTITY(1,1) PRIMARY KEY NOT NULL,
							Cuenta_Estado varchar(255) default 'Habilitado',
							Cuenta_Moneda tinyint FOREIGN KEY REFERENCES Tipo_De_Moneda(Tipo_De_Moneda_Id) default 1,
							Cuenta_Tipo tinyint FOREIGN KEY REFERENCES Tipo_De_Cuentas(Tipo_De_Cuentas_Id),
							Cuenta_PaisOrigen numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
							Cuenta_PaisAsignado numeric (18,0) FOREIGN KEY REFERENCES Paises(Pais_Id),
							Cuenta_Fec_Cre datetime,
							Cuenta_Fec_Cierre datetime,
							Cuenta_Cliente integer FOREIGN KEY REFERENCES Clientes(Cliente_Id),
							cuenta_Tarjeta varchar(16) FOREIGN KEY REFERENCES Tarjetas(Tarjeta_Nro),
							Cuenta_Saldo float default 0)

														
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