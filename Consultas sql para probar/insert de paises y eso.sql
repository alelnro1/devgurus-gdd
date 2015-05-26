
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
 
 
 INSERT into Tipo_De_Cuentas (Tipo_De_Cuentas_Id,Tipo_De_Cuentas_Nombre, Tipo_De_Cuentas_Duracion, Tipo_De_Cuentas_Costo)
        VALUES
                (1,'Oro', 45, 22.88),
                (2,'Plata', 30, 18.99),
                (3,'Bronce', 15, 12.49),
                (4,'Gratuita', 5, 0)
                
         