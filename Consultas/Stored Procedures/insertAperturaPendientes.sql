CREATE trigger insertAperturasPendientes
ON dbo.Cuentas
AFTER insert
AS
BEGIN

DECLARE @Apertura_Tipo_Cuenta tinyint
DECLARE	@Apertura_Tipo_Cuenta_Costo numeric(18,2)
DECLARE @Apertura_Cliente int
DECLARE @Apertura_Cuenta_Nro numeric(18,0)

SET @Apertura_Tipo_Cuenta = (select Cuenta_Tipo from inserted)
SET @Apertura_Tipo_Cuenta_Costo = (select Tipo_De_Cuentas_Costo from dbo.Tipo_De_Cuentas 
where Tipo_De_Cuentas_Id = @Apertura_Tipo_Cuenta)
SET @Apertura_Cliente = (select Cuenta_Cliente from inserted)
SET @Apertura_Cuenta_Nro = (select Cuenta_Nro from inserted)

insert into dbo.Transaccion_Pendiente (Transaccion_Pendiente_Importe, Transaccion_Pendiente_Descr,
Transaccion_Pendiente_Cliente, Transaccion_Pendiente_Fecha, Transaccion_Pendiente_Cuenta_Nro)
values (@Apertura_Tipo_Cuenta_Costo, 'Apertura', @Apertura_Cliente,
GETDATE(), @Apertura_Cuenta_Nro)

END
GO
