/* /////////////////////////////////////////// */
/*       PROCEDURES Y FUNCIONES   */
/* /////////////////////////////////////////// */


create procedure [dbo].[insertarEnCuentas] 
		@Cuenta_PaisOrigen varchar(255),
		@Cuenta_Estado varchar(255),
		@Cuenta_Moneda tinyint,
		@Cuenta_Tipo tinyint,
		@Cuenta_PaisAsignado numeric (18,0),
		@Cuenta_Fec_Cre datetime,
		@Cuenta_Fec_Cierre datetime,
		@Cuenta_Cliente integer,
		@cuenta_Tarjeta varchar(16)
			
				as
						
						Declare @pais_id int
						select @pais_id = Pais_Id from Paises where Pais_Nombre = @Cuenta_PaisOrigen 
							insert into Cuentas(
												[Cuenta_Estado],
												[Cuenta_Moneda],
												[Cuenta_Tipo],
												[Cuenta_PaisOrigen],
												[Cuenta_PaisAsignado],
												[Cuenta_Fec_Cre],
												[Cuenta_Fec_Cierre],
												[Cuenta_Cliente],
												[cuenta_Tarjeta]) 
												values(@Cuenta_Estado,@Cuenta_Moneda,@Cuenta_Tipo,@pais_id,@pais_id,@Cuenta_Fec_Cre,@Cuenta_Fec_Cierre,@Cuenta_Cliente,@cuenta_Tarjeta)
							