create trigger [DEVGURUS].[calcularSaldoDeCuenta]

ON [DEVGURUS].[Cuentas]
AFTER insert
AS
BEGIN

DECLARE @cuenta_nro float
SET @cuenta_nro = (select Cuenta_Nro from inserted)

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


UPDATE DEVGURUSU.Cuentas SET Cuenta_Saldo = @saldo where Cuenta_Nro = @cuenta_nro

END

