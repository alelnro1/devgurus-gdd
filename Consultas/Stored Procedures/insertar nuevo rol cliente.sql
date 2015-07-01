CReate procedure DEVGURUS.insertar_Nuevo_rol_a_usuario(@user int,@rol_desc varchar(255))

AS
declare @id_rol int
select @id_rol = Rol_Id from DEVGURUS.Roles where Rol_Desc = @rol_desc
INSERT INTO DEVGURUS.Rol_X_Usuario(Rol_X_Usuario_Usuario,Rol_X_Usuario_Rol)
VALUES (@user,@id_rol)
GO

