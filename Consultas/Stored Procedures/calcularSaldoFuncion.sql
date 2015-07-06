create function DEVGURUS.funcionCalcularSaldo (@cuenta_nro numeric(18,0))

RETURNS float
WITH EXECUTE AS CALLER
AS
BEGIN

declare @importe_total_depositos float
select @importe_total_depositos = sum( Deposito_Importe)from gd_esquema.Maestra  where Cuenta_Numero = @cuenta_nro

declare @importe_total_transferencias_a_la_cuenta float
select @importe_total_transferencias_a_la_cuenta = sum( Trans_Importe) from gd_esquema.Maestra  where Cuenta_Dest_Numero = @cuenta_nro

declare @importe_total_transferencias_desde_la_cuenta float
select @importe_total_transferencias_desde_la_cuenta = sum( Trans_Importe) from gd_esquema.Maestra  where Cuenta_Numero = @cuenta_nro


declare @importe_total_retiros float
select @importe_total_retiros = sum( Retiro_Importe ) from gd_esquema.Maestra  where Cuenta_Numero = @cuenta_nro


declare @saldo float 
select @saldo =  @importe_total_depositos + @importe_total_transferencias_a_la_cuenta  + @importe_total_retiros - @importe_total_transferencias_desde_la_cuenta


RETURN(@saldo)

END;

GO


