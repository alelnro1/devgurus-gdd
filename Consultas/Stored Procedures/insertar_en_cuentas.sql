/* /////////////////////////////////////////// */
/*       PROCEDURES Y FUNCIONES   */
/* /////////////////////////////////////////// */


create procedure [dbo].[insertarEnCuentas] 
		@Cuenta_PaisOrigen varchar(255),
		@Cuenta_Estado varchar(255),
		@Cuenta_Moneda varchar(255),
		@Cuenta_Tipo varchar(255),
		@Cuenta_PaisAsignado numeric (18,0),
		@Cuenta_Fec_Cierre datetime,
		@Cuenta_Cliente integer
		
			
				as
						Declare @Cuenta_Fec_Cre datetime = GETDATE()
						
						Declare @pais_id int
						select @pais_id = Pais_Id from Paises where Pais_Nombre = @Cuenta_PaisOrigen 
						Declare @tipo_moneda_id tinyint
						SELECT @tipo_moneda_id = Tipo_De_Moneda_Id FROM Tipo_De_Moneda WHERE Tipo_De_Moneda_Nombre = @Cuenta_Moneda
						Declare @tipo_cuenta_id tinyint
						SELECT @tipo_cuenta_id = Tipo_De_Cuentas_Id FROM Tipo_De_Cuentas WHERE Tipo_De_Cuentas_Nombre = @Cuenta_Tipo
							insert into Cuentas(
												[Cuenta_Estado],
												[Cuenta_Moneda],
												[Cuenta_Tipo],
												[Cuenta_PaisOrigen],
												[Cuenta_PaisAsignado],
												[Cuenta_Fec_Cre],
												[Cuenta_Fec_Cierre],
												[Cuenta_Cliente]) 
												
												values(@Cuenta_Estado,@tipo_moneda_id,@tipo_cuenta_id,@pais_id,@pais_id,@Cuenta_Fec_Cre,@Cuenta_Fec_Cierre,@Cuenta_Cliente)
												

				SELECT Cuenta_Nro FROM INSERTED
				
				