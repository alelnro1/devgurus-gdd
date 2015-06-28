/* /////////////////////////////////////////// */
/*       PROCEDURES Y FUNCIONES   */
/* /////////////////////////////////////////// */

create procedure [dbo].[insertarEnCuentas] 

		@Cuenta_Estado varchar(255),
		@Cuenta_Moneda varchar(255),
		@Cuenta_Tipo varchar(255),
		@Cuenta_PaisAsignado varchar(255),
		@Cuenta_Fec_Cierre datetime,
		@Cuenta_Cliente integer
		
			
				as
						Declare @Cuenta_Fec_Cre datetime = GETDATE()
						
						Declare @pais_id int
						select @pais_id = Pais_Id from Paises where Pais_Nombre = @Cuenta_PaisAsignado
						
						Declare @tipo_moneda_id tinyint
						SELECT @tipo_moneda_id = Tipo_De_Moneda_Id FROM Tipo_De_Moneda WHERE Tipo_De_Moneda_Nombre = @Cuenta_Moneda
						
						Declare @tipo_cuenta_id tinyint
						SELECT @tipo_cuenta_id = Tipo_De_Cuentas_Id FROM Tipo_De_Cuentas WHERE Tipo_De_Cuentas_Nombre = @Cuenta_Tipo
						
						Declare @pais_id_nacionalidad_cliente int
						SELECT @pais_id_nacionalidad_cliente = Cliente_Nacionalidad FROM Clientes WHERE Cliente_Id = @Cuenta_Cliente
						
						DECLARE @numero_cuenta numeric(18,0)
		
						SET @numero_cuenta = (SELECT MAX(Cuenta_Nro) FROM DEVGURUS.Cuentas)
						SET @numero_cuenta = @numero_cuenta + 1
						
							insert into Cuentas([Cuenta_Nro],
												[Cuenta_Estado],
												[Cuenta_Moneda],
												[Cuenta_Tipo],
												[Cuenta_PaisOrigen],
												[Cuenta_PaisAsignado],
												[Cuenta_Fec_Cre],
												[Cuenta_Fec_Cierre],
												[Cuenta_Cliente]) 
												
												values(@numero_cuenta,@Cuenta_Estado,@tipo_moneda_id,@tipo_cuenta_id,@pais_id_nacionalidad_cliente,@pais_id,@Cuenta_Fec_Cre,@Cuenta_Fec_Cierre,@Cuenta_Cliente)
						

GO