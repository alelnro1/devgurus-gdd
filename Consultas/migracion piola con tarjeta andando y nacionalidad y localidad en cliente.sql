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

/* PAISES */
Insert into Paises (Pais_Id, Pais_Nombre)	select distinct Cli_Pais_Codigo, Cli_Pais_Desc from gd_esquema.Maestra union 
													select distinct Cuenta_Pais_Codigo, Cuenta_Pais_Desc from gd_esquema.Maestra union
													select distinct	Cuenta_Dest_Pais_Codigo, Cuenta_Dest_Pais_Desc from gd_esquema.Maestra
													where	Cli_Pais_Codigo <> NULL and
															Cuenta_Pais_Codigo <> NULL and
															Cuenta_Dest_Pais_Codigo <> NULL

UPDATE Paises SET Pais_Nombre = (SELECT REPLACE(Paises.Pais_Nombre, ' ', ''))

/*TIPOS DE MONEDA*/


Insert into Tipo_De_Moneda(Tipo_De_Moneda_Nombre) values ('Dolar');

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
Insert into Clientes(	Cliente_Nombre, Cliente_Apellido, Cliente_Tipo_Doc, Cliente_Pais, 
						Cliente_Dom_Calle, Cliente_Dom_Nro, Cliente_Dom_Piso, Cliente_Dom_Depto, 
						Cliente_Fecha_Nac, Cliente_Mail, Cliente_User)
						select distinct MA.Cli_Nombre, MA.Cli_Apellido, MA.Cli_Tipo_Doc_Cod, 
						MA.Cli_Pais_Codigo, MA.Cli_Dom_Calle, MA.Cli_Dom_Nro, MA.Cli_Dom_Piso, MA.Cli_Dom_Depto, 
						MA.Cli_Fecha_Nac, MA.Cli_Mail, US.Usuarios_Id from gd_esquema.Maestra MA, Usuarios US
						where US.Usuarios_Name = Cli_Apellido + Cli_Nombre

/* TIPO_DE_CUENTAS */
SET IDENTITY_INSERT Cuentas ON
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
select distinct MA.Cuenta_Numero, 4, MA.Cuenta_Pais_Codigo, MA.Cli_Pais_Codigo, DATEADD(YEAR, -2, MA.Cuenta_Fecha_Creacion), CL.Cliente_Id
from gd_esquema.Maestra MA, Clientes CL
where CL.Cliente_Nombre = MA.Cli_Nombre and CL.Cliente_Apellido = MA.Cli_Apellido and MA.Cuenta_Numero is not null

update Cuentas
set Cuenta_Fec_Cierre = DATEADD(day, 15, Cuenta_Fec_Cre)


		
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
insert into Rol_X_Usuario
values (166, 1)