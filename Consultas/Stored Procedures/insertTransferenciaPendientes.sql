CREATE trigger insertTransferenciasPendientes
ON dbo.Transferencia
AFTER insert
AS
BEGIN

DECLARE	@Transaccion_Pendiente_Importe numeric(18,2)
DECLARE @Transaccion_Pendiente_Cliente int
DECLARE @Transaccion_Pendiente_Cuenta_Nro numeric(18,0)

SET @Transaccion_Pendiente_Importe = (select Transferencia_Costo_Transf from inserted)
SET @Transaccion_Pendiente_Cuenta_Nro = (select Transferencia_Cuenta_Emisora from inserted)
SET @Transaccion_Pendiente_Cliente = (select Cuenta_Cliente from dbo.Cuentas 
where Cuenta_Nro = @Transaccion_Pendiente_Cuenta_Nro)

insert into dbo.Transaccion_Pendiente (Transaccion_Pendiente_Importe, Transaccion_Pendiente_Descr,
Transaccion_Pendiente_Cliente, Transaccion_Pendiente_Fecha, Transaccion_Pendiente_Cuenta_Nro)
values (@Transaccion_Pendiente_Importe, 'Transferencia', @Transaccion_Pendiente_Cliente,
GETDATE(), @Transaccion_Pendiente_Cuenta_Nro)

END
GO
